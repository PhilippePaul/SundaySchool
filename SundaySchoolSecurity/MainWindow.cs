using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace SundaySchool
{
    public partial class MainWindow : Form, IDisposable
    {
        private static string AppFolder = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)}\\Application_EDD\\";
        private static string PictureFilePath = $"{AppFolder}Photos_EDD\\";
        private static string ProfilesFilePath = $"{AppFolder}Profils_EDD.json";
        private static string CheckinFilePath = $"{AppFolder}Inscriptions_EDD.json";
        private static string ReportFilePath = $"{AppFolder}RapportInscriptions_EDD.xls";
        private static string WindowTitle = "Inscriptions École du Dimanche";

        private SortableBindingList<Profile> AllProfiles = new SortableBindingList<Profile>();
        private SortableBindingList<CheckinEntry> AllCheckinEntries = new SortableBindingList<CheckinEntry>();
        private DBConnection dbConnection = new DBConnection();

        private CreateProfileWindow m_createProfileWindow = new CreateProfileWindow();

        public MainWindow()
        {
            InitializeComponent();
            m_profileEditor.SaveProfileEventHandler += SaveProfile;

            this.Text = WindowTitle;
            try
            {
                Directory.CreateDirectory(PictureFilePath);
                Directory.CreateDirectory(AppFolder);

                AllProfiles = dbConnection.GetAllProfiles();
                if (File.Exists(ProfilesFilePath))
                {
                    string serializedJson = File.ReadAllText(ProfilesFilePath);
                    //AllProfiles = JsonConvert.DeserializeObject<SortableBindingList<Profile>>(serializedJson) ?? new SortableBindingList<Profile>();

                }
                else
                {
                    File.Create(ProfilesFilePath);
                }
                if (File.Exists(CheckinFilePath))
                {
                    string serializedJson = File.ReadAllText(CheckinFilePath);
                    AllCheckinEntries = JsonConvert.DeserializeObject<SortableBindingList<CheckinEntry>>(serializedJson) ?? new SortableBindingList<CheckinEntry>();
                }
                else
                {
                    File.Create(ProfilesFilePath);
                }

                registeredProfilesDataGridView.DataSource = AllProfiles;
                checkinDataGridView.DataSource = AllCheckinEntries;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur a eu lieu lors du chargement des profiles. {ex.Message}");
            }
        }

        #region Events

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            int id;
            if (int.TryParse(txtBox.Text, out id))
            {
                //Get profile by id
                Profile profile = AllProfiles.FirstOrDefault(p => p.Id == id);
                if (profile != null)
                {
                    this.Text = WindowTitle;
                    m_profileEditor.LoadProfile(profile);
                }
                else
                {
                    this.Text = $"{WindowTitle} - L'identifiant ne correspond à aucun profile existant.";
                    m_profileEditor.ClearProfile();
                }
            }
            else
            {
                this.Text = $"{WindowTitle} - L'identifiant ne peut être composé que de chiffres.";
                txtBox.Text = "";
            }
        }

        private void SaveProfile(object sender, EventArgs e)
        {
            if (m_profileEditor.ValidateProfile())
            {
                var profile = m_profileEditor.GetProfile();
                if (profile.Id != -1 && AllProfiles.FirstOrDefault(p => p.Id == profile.Id) == null)
                    MessageBox.Show("Il semble il y avoir un problème avec le profil sélectionné.");
                else
                    UpdateProfile(profile);
            }
        }

        private void registeredProfilesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (registeredProfilesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = registeredProfilesDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    m_profileEditor.LoadProfile(selectedRow.DataBoundItem as Profile);
                }
            }
        }

        private void choosePhotoBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = selectFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //photoFileNameTextBox.Text = selectFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Find profile and add
            int id = -1;
            int.TryParse(textBox1.Text.Trim(), out id);
            var profile = AllProfiles.FirstOrDefault(p => p.Id == id);
            if (profile != null)
            {
                CheckinEntry entry = new CheckinEntry()
                {
                    CheckinTime = DateTime.Now,
                    Person = profile
                };
                AllCheckinEntries.Add(entry);
            }
            else
            {
                //Display invalid id number
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Find profile and update
            int id = -1;
            int.TryParse(textBox1.Text.Trim(), out id);
            var entry = AllCheckinEntries.FirstOrDefault(x => x.Person.Id == id);
            if (entry != null)
            {
                entry.CheckoutTime = DateTime.Now;
                checkinDataGridView.Refresh();
            }
            else
            {
                //Display invalid id number
            }
        }

        private void createProfileBtn_Click(object sender, EventArgs e)
        {
            var result = m_createProfileWindow.ShowDialog();
            if (result == DialogResult.OK)
                CreateProfile(m_createProfileWindow.ProfileEditor.GetProfile());
        }

        private void deleteProfileBtn_Click(object sender, EventArgs e)
        {
            if (registeredProfilesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = registeredProfilesDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce profil? Cette opération est irréversible.", "Attention!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        Profile profile = selectedRow.DataBoundItem as Profile;
                        dbConnection.DeleteProfile(profile);
                        var removedProfile = AllProfiles.FirstOrDefault(p => p.Id == profile.Id);
                        if (removedProfile != null)
                            AllProfiles.Remove(removedProfile);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un profil.");
            }
        }

        #endregion

        #region Private methods

        private void UpdateProfile(Profile updatedProfile)
        {
            try
            {
                //Do this to update the profiles list through INotifyPropertyChanged
                Profile profile = AllProfiles.FirstOrDefault(p => p.Id == updatedProfile.Id);
                profile.FirstName = updatedProfile.FirstName;
                profile.LastName = updatedProfile.LastName;
                profile.Age = updatedProfile.Age;
                profile.Gender = updatedProfile.Gender;
                profile.Allergies = updatedProfile.Allergies;
                profile.WaitForParent = updatedProfile.WaitForParent;
                profile.PictureFileName = updatedProfile.PictureFileName;
                dbConnection.UpdateProfile(profile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Il y a eu une erreur lors de l'enregistrement du profile. {ex.Message}");
            }
        }

        private void CreateProfile(Profile profile)
        {
            try
            {
                //File.WriteAllText(ProfilesFilePath, JsonConvert.SerializeObject(AllProfiles));
                profile = dbConnection.CreateProfile(profile);
                AllProfiles.Add(profile);
                this.Text = $"{WindowTitle} - Le profile a été enregistré.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Il y a eu une erreur lors de l'enregistrement du profile. {ex.Message}");
            }
        }

        private void ExportToExcel()
        {
            if (File.Exists(CheckinFilePath))
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(CheckinFilePath);
                foreach (Excel.Worksheet sheet in wb.Sheets)
                {
                    if (sheet.Name == DateTime.Today.ToString())
                    {

                    }
                }
            }
            else
            {
                File.Create(CheckinFilePath);
            }
        }

        private void checkinDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (checkinDataGridView.Rows[e.RowIndex].DataBoundItem != null && checkinDataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains('.'))
                e.Value = BindProperty(checkinDataGridView.Rows[e.RowIndex].DataBoundItem, checkinDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        private void SaveCheckinEntries()
        {
            try
            {
                File.WriteAllText(CheckinFilePath, JsonConvert.SerializeObject(AllCheckinEntries));
            }
            catch (Exception ex)
            {
                //Handle exception
                this.Text = $"{WindowTitle} - Il y a eu une erreur lors de l'enregistrement du fichier.";
            }
        }

        #endregion

    }
}
