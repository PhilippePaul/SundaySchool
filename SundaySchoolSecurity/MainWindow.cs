using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SundaySchoolSecurity
{
    public partial class MainWindow : Form
    {
        private string DataFilePath = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\InscriptionsEcoleDuDimanche.json";
        private List<Profile> AllProfiles = new List<Profile>();
        private string WindowTitle = "Inscriptions École du Dimanche";

        public MainWindow()
        {
            InitializeComponent();
            this.Text = WindowTitle;
            try
            {
                if (File.Exists(DataFilePath))
                {
                    string serializedJson = File.ReadAllText(DataFilePath);
                    AllProfiles = JsonConvert.DeserializeObject<List<Profile>>(serializedJson) ?? new List<Profile>();
                    registeredProfilesDataGridView.DataSource = AllProfiles;
                }
                else
                {
                    File.Create(DataFilePath);
                }
            }
            catch(Exception e)
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
                Profile profile = AllProfiles.Find(p => p.BarCode == barCode);
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
                    File.WriteAllText(DataFilePath, JsonConvert.SerializeObject(AllProfiles));
                    this.Text = $"{WindowTitle} - Le profile a été enregistré.";
                }
                catch (Exception ex)
                {
                    //Handle exception
                    this.Text = $"{WindowTitle} - Il y a eu une erreur lors de l'enregistrement du fichier.";
                }
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
                BarCode = int.Parse(barcodeTxtBox.Text)
            };
            return profile;
        }
        
        private bool ValidateProfile()
        {
            int barCode;
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                //Display error message
                this.Text = $"{WindowTitle} - Vous ne pouvez pas laissez le champ 'Prénom' vide.";
                return false;
            }
            else if(string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                //Display error message
                this.Text = $"{WindowTitle} - Vous ne pouvez pas laissez le champ 'Nom' vide.";
                return false;
            }
            else if(!int.TryParse(barcodeTxtBox.Text, out barCode))
            {
                //Display error message
                this.Text = $"{WindowTitle} - L'identifiant ne peut être composé que de chiffres.";
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
            allergiesTextBox.Lines = new string[]{ };
            waitForParentYesBtn.Checked = true;
        }

        #endregion
    }
}
