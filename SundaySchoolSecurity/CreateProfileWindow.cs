using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SundaySchool
{
    public partial class CreateProfileWindow : Form
    {
        public ProfileEditor ProfileEditor
        {
            get { return profileEditor1; }
        }

        public CreateProfileWindow()
        {
            InitializeComponent();
            profileEditor1.SaveProfileEventHandler += SaveProfile;
        }

        private void SaveProfile(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
