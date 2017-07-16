namespace SundaySchoolSecurity
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderMaleBtn = new System.Windows.Forms.RadioButton();
            this.genderFemaleBtn = new System.Windows.Forms.RadioButton();
            this.ageLabel = new System.Windows.Forms.Label();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.saveProfileBtn = new System.Windows.Forms.Button();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.allergiesLabel = new System.Windows.Forms.Label();
            this.waitForParentLabel = new System.Windows.Forms.Label();
            this.waitForParentGroupBox = new System.Windows.Forms.GroupBox();
            this.waitForParentNoBtn = new System.Windows.Forms.RadioButton();
            this.waitForParentYesBtn = new System.Windows.Forms.RadioButton();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.registeredProfilesLabel = new System.Windows.Forms.Label();
            this.registeredProfilesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.profileGroupBox.SuspendLayout();
            this.waitForParentGroupBox.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Location = new System.Drawing.Point(80, 26);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.Size = new System.Drawing.Size(279, 20);
            this.barcodeTxtBox.TabIndex = 1;
            this.barcodeTxtBox.TextChanged += new System.EventHandler(this.barcodeTxtBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(95, 34);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(95, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(98, 99);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(47, 20);
            this.ageUpDown.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(43, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(46, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "Prénom:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(57, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(32, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Nom:";
            // 
            // genderMaleBtn
            // 
            this.genderMaleBtn.AutoSize = true;
            this.genderMaleBtn.Checked = true;
            this.genderMaleBtn.Location = new System.Drawing.Point(7, 16);
            this.genderMaleBtn.Name = "genderMaleBtn";
            this.genderMaleBtn.Size = new System.Drawing.Size(60, 17);
            this.genderMaleBtn.TabIndex = 13;
            this.genderMaleBtn.TabStop = true;
            this.genderMaleBtn.Text = "Garçon";
            this.genderMaleBtn.UseVisualStyleBackColor = true;
            // 
            // genderFemaleBtn
            // 
            this.genderFemaleBtn.AutoSize = true;
            this.genderFemaleBtn.Location = new System.Drawing.Point(81, 16);
            this.genderFemaleBtn.Name = "genderFemaleBtn";
            this.genderFemaleBtn.Size = new System.Drawing.Size(43, 17);
            this.genderFemaleBtn.TabIndex = 14;
            this.genderFemaleBtn.TabStop = true;
            this.genderFemaleBtn.Text = "Fille";
            this.genderFemaleBtn.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(60, 101);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Age:";
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.saveProfileBtn);
            this.profileGroupBox.Controls.Add(this.allergiesTextBox);
            this.profileGroupBox.Controls.Add(this.allergiesLabel);
            this.profileGroupBox.Controls.Add(this.waitForParentLabel);
            this.profileGroupBox.Controls.Add(this.waitForParentGroupBox);
            this.profileGroupBox.Controls.Add(this.genderGroupBox);
            this.profileGroupBox.Controls.Add(this.pictureBox);
            this.profileGroupBox.Controls.Add(this.firstNameLabel);
            this.profileGroupBox.Controls.Add(this.ageLabel);
            this.profileGroupBox.Controls.Add(this.firstNameTextBox);
            this.profileGroupBox.Controls.Add(this.lastNameTextBox);
            this.profileGroupBox.Controls.Add(this.ageUpDown);
            this.profileGroupBox.Controls.Add(this.lastNameLabel);
            this.profileGroupBox.Location = new System.Drawing.Point(381, 26);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(527, 464);
            this.profileGroupBox.TabIndex = 16;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profile";
            // 
            // saveProfileBtn
            // 
            this.saveProfileBtn.Location = new System.Drawing.Point(318, 435);
            this.saveProfileBtn.Name = "saveProfileBtn";
            this.saveProfileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveProfileBtn.TabIndex = 22;
            this.saveProfileBtn.Text = "Enregistrer";
            this.saveProfileBtn.UseVisualStyleBackColor = true;
            this.saveProfileBtn.Click += new System.EventHandler(this.saveProfileBtn_Click);
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.Location = new System.Drawing.Point(315, 236);
            this.allergiesTextBox.Multiline = true;
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(206, 174);
            this.allergiesTextBox.TabIndex = 21;
            // 
            // allergiesLabel
            // 
            this.allergiesLabel.AutoSize = true;
            this.allergiesLabel.Location = new System.Drawing.Point(315, 219);
            this.allergiesLabel.Name = "allergiesLabel";
            this.allergiesLabel.Size = new System.Drawing.Size(46, 13);
            this.allergiesLabel.TabIndex = 20;
            this.allergiesLabel.Text = "Allergies";
            // 
            // waitForParentLabel
            // 
            this.waitForParentLabel.AutoSize = true;
            this.waitForParentLabel.Location = new System.Drawing.Point(6, 139);
            this.waitForParentLabel.Name = "waitForParentLabel";
            this.waitForParentLabel.Size = new System.Drawing.Size(83, 13);
            this.waitForParentLabel.TabIndex = 18;
            this.waitForParentLabel.Text = "Attendre parent:";
            // 
            // waitForParentGroupBox
            // 
            this.waitForParentGroupBox.Controls.Add(this.waitForParentNoBtn);
            this.waitForParentGroupBox.Controls.Add(this.waitForParentYesBtn);
            this.waitForParentGroupBox.Location = new System.Drawing.Point(98, 125);
            this.waitForParentGroupBox.Name = "waitForParentGroupBox";
            this.waitForParentGroupBox.Size = new System.Drawing.Size(138, 41);
            this.waitForParentGroupBox.TabIndex = 17;
            this.waitForParentGroupBox.TabStop = false;
            // 
            // waitForParentNoBtn
            // 
            this.waitForParentNoBtn.AutoSize = true;
            this.waitForParentNoBtn.Location = new System.Drawing.Point(81, 14);
            this.waitForParentNoBtn.Name = "waitForParentNoBtn";
            this.waitForParentNoBtn.Size = new System.Drawing.Size(45, 17);
            this.waitForParentNoBtn.TabIndex = 1;
            this.waitForParentNoBtn.TabStop = true;
            this.waitForParentNoBtn.Text = "Non";
            this.waitForParentNoBtn.UseVisualStyleBackColor = true;
            // 
            // waitForParentYesBtn
            // 
            this.waitForParentYesBtn.AutoSize = true;
            this.waitForParentYesBtn.Checked = true;
            this.waitForParentYesBtn.Location = new System.Drawing.Point(7, 14);
            this.waitForParentYesBtn.Name = "waitForParentYesBtn";
            this.waitForParentYesBtn.Size = new System.Drawing.Size(41, 17);
            this.waitForParentYesBtn.TabIndex = 0;
            this.waitForParentYesBtn.TabStop = true;
            this.waitForParentYesBtn.Text = "Oui";
            this.waitForParentYesBtn.UseVisualStyleBackColor = true;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.genderMaleBtn);
            this.genderGroupBox.Controls.Add(this.genderFemaleBtn);
            this.genderGroupBox.Location = new System.Drawing.Point(98, 172);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.genderGroupBox.Size = new System.Drawing.Size(138, 41);
            this.genderGroupBox.TabIndex = 17;
            this.genderGroupBox.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(315, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(206, 178);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Location = new System.Drawing.Point(18, 29);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(56, 13);
            this.barCodeLabel.TabIndex = 17;
            this.barCodeLabel.Text = "Identifiant:";
            // 
            // registeredProfilesLabel
            // 
            this.registeredProfilesLabel.AutoSize = true;
            this.registeredProfilesLabel.Location = new System.Drawing.Point(13, 62);
            this.registeredProfilesLabel.Name = "registeredProfilesLabel";
            this.registeredProfilesLabel.Size = new System.Drawing.Size(92, 13);
            this.registeredProfilesLabel.TabIndex = 19;
            this.registeredProfilesLabel.Text = "Liste d\'inscriptions";
            // 
            // registeredProfilesDataGridView
            // 
            this.registeredProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredProfilesDataGridView.Location = new System.Drawing.Point(12, 81);
            this.registeredProfilesDataGridView.Name = "registeredProfilesDataGridView";
            this.registeredProfilesDataGridView.Size = new System.Drawing.Size(347, 409);
            this.registeredProfilesDataGridView.TabIndex = 20;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 502);
            this.Controls.Add(this.registeredProfilesDataGridView);
            this.Controls.Add(this.registeredProfilesLabel);
            this.Controls.Add(this.barCodeLabel);
            this.Controls.Add(this.profileGroupBox);
            this.Controls.Add(this.barcodeTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.profileGroupBox.ResumeLayout(false);
            this.profileGroupBox.PerformLayout();
            this.waitForParentGroupBox.ResumeLayout(false);
            this.waitForParentGroupBox.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.RadioButton genderMaleBtn;
        private System.Windows.Forms.RadioButton genderFemaleBtn;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox waitForParentGroupBox;
        private System.Windows.Forms.Label allergiesLabel;
        private System.Windows.Forms.Label waitForParentLabel;
        private System.Windows.Forms.RadioButton waitForParentNoBtn;
        private System.Windows.Forms.RadioButton waitForParentYesBtn;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.Button saveProfileBtn;
        private System.Windows.Forms.Label registeredProfilesLabel;
        private System.Windows.Forms.DataGridView registeredProfilesDataGridView;
    }
}

