using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
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

        public MainWindow()
        {
            InitializeComponent();
            this.Text = WindowTitle;
            try
            {
                Directory.CreateDirectory(PictureFilePath);
                Directory.CreateDirectory(AppFolder);
                if (File.Exists(ProfilesFilePath))
                {
                    string serializedJson = File.ReadAllText(ProfilesFilePath);
                    AllProfiles = JsonConvert.DeserializeObject<SortableBindingList<Profile>>(serializedJson) ?? new SortableBindingList<Profile>();
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
                //Handle exception
                this.Text = $"{WindowTitle} - Il y a eu un problème lors du chargement des données.";
            }
        }

        #region Events

        private void barcodeTxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            int barCode;
            if (int.TryParse(txtBox.Text, out barCode))
            {
                //Get profile by barcode
                Profile profile = AllProfiles.FirstOrDefault(p => p.BarCode == barCode);
                if (profile != null)
                {
                    this.Text = WindowTitle;
                    LoadProfile(profile);
                }
                else
                {
                    this.Text = $"{WindowTitle} - L'identifiant ne correspond à aucun profile existant.";
                    ClearFields();
                }
            }
            else
            {
                this.Text = $"{WindowTitle} - L'identifiant ne peut être composé que de chiffres.";
                txtBox.Text = "";
            }
        }

        private void saveProfileBtn_Click(object sender, EventArgs e)
        {
            if (ValidateProfile())
            {
                AllProfiles.Add(ExtractProfile());
                try
                {
                    File.WriteAllText(ProfilesFilePath, JsonConvert.SerializeObject(AllProfiles));
                    this.Text = $"{WindowTitle} - Le profile a été enregistré.";
                }
                catch (Exception ex)
                {
                    //Handle exception
                    this.Text = $"{WindowTitle} - Il y a eu une erreur lors de l'enregistrement du fichier.";
                }
            }
        }

        private void registeredProfilesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (registeredProfilesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = registeredProfilesDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    LoadProfile(selectedRow.DataBoundItem as Profile);
                }
            }
        }

        private void choosePhotoBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = selectFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                photoFileNameTextBox.Text = selectFileDialog.FileName;
            }
        }

        #endregion

        #region Private methods

        private void LoadProfile(Profile profile)
        {
            firstNameTextBox.Text = profile.FirstName;
            lastNameTextBox.Text = profile.LastName;
            ageUpDown.Value = profile.Age;
            genderFemaleBtn.Checked = profile.Gender == Gender.Female;
            genderMaleBtn.Checked = profile.Gender == Gender.Male;
            allergiesTextBox.Lines = profile.Allergies.ToArray();
            waitForParentYesBtn.Checked = profile.WaitForParent;
            waitForParentNoBtn.Checked = !profile.WaitForParent;
            photoFileNameTextBox.Text = profile.PictureFileName;
        }

        private Profile ExtractProfile()
        {
            Profile profile = new Profile()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Age = (int)ageUpDown.Value,
                Gender = genderFemaleBtn.Checked ? Gender.Female : Gender.Male,
                Allergies = allergiesTextBox.Lines.ToList(),
                WaitForParent = waitForParentYesBtn.Checked,
                PictureFileName = photoFileNameTextBox.Text,
                BarCode = int.Parse(barcodeTxtBox.Text)
            };
            return profile;
        }

        private bool ValidateProfile()
        {
            int barCode;
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                this.Text = $"{WindowTitle} - Vous ne pouvez pas laissez le champ 'Prénom' vide.";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                this.Text = $"{WindowTitle} - Vous ne pouvez pas laissez le champ 'Nom' vide.";
                return false;
            }
            else if (!int.TryParse(barcodeTxtBox.Text, out barCode))
            {
                this.Text = $"{WindowTitle} - L'identifiant ne peut être composé que de chiffres.";
                return false;
            }
            else if (!File.Exists($"{PictureFilePath}{photoFileNameTextBox.Text}"))
            {
                this.Text = $"{WindowTitle} - Le fichier de photo est introuvable.";
                return false;
            }
            this.Text = WindowTitle;
            return true;
        }

        private void ClearFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageUpDown.Value = 0;
            genderMaleBtn.Checked = true;
            allergiesTextBox.Lines = new string[] { };
            waitForParentYesBtn.Checked = true;
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
