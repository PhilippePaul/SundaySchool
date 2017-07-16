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
        private string DataFilePath = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\SecuriteEcoleDuDimanche.json";
        private List<Profile> AllProfiles = new List<Profile>();
        private string WindowTitle = "Sécurité École du Dimanche";

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
                }
                else
                {
                    File.Create(DataFilePath);
                }
            }
            catch(Exception e)
            {
                //Handle exception
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
                    LoadProfile(profile);
                }
                else
                {
                    this.Text = $"{WindowTitle} - L'identifiant ne correspond à aucun profile existant";
                }
            }
            else
            {
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
                return false;
            }
            else if(string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                //Display error message
                return false;
            }
            else if(!int.TryParse(barcodeTxtBox.Text, out barCode))
            {
                //Display error message
                return false;
            }
            return true;
        }

        #endregion
    }
}
