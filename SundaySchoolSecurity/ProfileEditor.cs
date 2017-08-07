using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SundaySchool
{
    public partial class ProfileEditor : UserControl
    {
        private int m_profileId;

        public EventHandler SaveProfileEventHandler;

        public ProfileEditor()
        {
            InitializeComponent();
        }

        public Profile GetProfile()
        {
            Profile profile = new Profile()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Age = (uint)ageUpDown.Value,
                Gender = genderFemaleBtn.Checked ? Gender.Female : Gender.Male,
                Allergies = allergiesTextBox.Lines.ToList(),
                WaitForParent = waitForParentYesBtn.Checked,
                //PictureFileName = photoFileNameTextBox.Text,
                Id = m_profileId
            };
            return profile;
        }

        public void LoadProfile(Profile profile)
        {
            firstNameTextBox.Text = profile.FirstName;
            lastNameTextBox.Text = profile.LastName;
            ageUpDown.Value = profile.Age;
            genderFemaleBtn.Checked = profile.Gender == Gender.Female;
            genderMaleBtn.Checked = profile.Gender == Gender.Male;
            allergiesTextBox.Lines = profile.Allergies.ToArray();
            waitForParentYesBtn.Checked = profile.WaitForParent;
            waitForParentNoBtn.Checked = !profile.WaitForParent;
            //photoFileNameTextBox.Text = profile.PictureFileName;
            m_profileId = profile.Id;
            //Load profile picture
        }

        public void ClearProfile()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageUpDown.Value = 0;
            genderMaleBtn.Checked = true;
            allergiesTextBox.Lines = new string[] { };
            waitForParentYesBtn.Checked = true;
            //m_profileId = -1;
        }

        public bool ValidateProfile()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Vous ne pouvez pas laissez le champ 'Prénom' vide.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Vous ne pouvez pas laissez le champ 'Nom' vide.");
                return false;
            }
            /*else if (!string.IsNullOrWhiteSpace(photoFileNameTextBox.Text))// && !File.Exists($"{PictureFilePath}{photoFileNameTextBox.Text}"))
            {
                MessageBox.Show("Le fichier de photo est introuvable.");
                return false;
            }*/
            return true;
        }

        private void saveProfileBtn_Click(object sender, EventArgs e)
        {
            if (SaveProfileEventHandler != null)
                SaveProfileEventHandler(this, e);
        }
    }
}
