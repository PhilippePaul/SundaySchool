namespace SundaySchool
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
            SaveCheckinEntries();
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
            this.photoFileNameTextBox = new System.Windows.Forms.TextBox();
            this.choosePhotoBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.waitForParentNoBtn = new System.Windows.Forms.RadioButton();
            this.waitForParentYesBtn = new System.Windows.Forms.RadioButton();
            this.saveProfileBtn = new System.Windows.Forms.Button();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.allergiesLabel = new System.Windows.Forms.Label();
            this.waitForParentLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.registeredProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitForParentCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileListGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainwindowTabControl = new System.Windows.Forms.TabControl();
            this.profilesTabPage = new System.Windows.Forms.TabPage();
            this.checkinTabPage = new System.Windows.Forms.TabPage();
            this.checkinDataGridView = new System.Windows.Forms.DataGridView();
            this.profileFirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileLastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileWaitForParentCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkinTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.profileGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.profileListGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainwindowTabControl.SuspendLayout();
            this.profilesTabPage.SuspendLayout();
            this.checkinTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.barcodeTxtBox.Location = new System.Drawing.Point(190, 5);
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
            this.genderMaleBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.genderMaleBtn.Location = new System.Drawing.Point(0, 0);
            this.genderMaleBtn.Name = "genderMaleBtn";
            this.genderMaleBtn.Size = new System.Drawing.Size(60, 27);
            this.genderMaleBtn.TabIndex = 13;
            this.genderMaleBtn.TabStop = true;
            this.genderMaleBtn.Text = "Garçon";
            this.genderMaleBtn.UseVisualStyleBackColor = true;
            // 
            // genderFemaleBtn
            // 
            this.genderFemaleBtn.AutoSize = true;
            this.genderFemaleBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.genderFemaleBtn.Location = new System.Drawing.Point(68, 0);
            this.genderFemaleBtn.Name = "genderFemaleBtn";
            this.genderFemaleBtn.Size = new System.Drawing.Size(43, 27);
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
            this.profileGroupBox.Controls.Add(this.photoFileNameTextBox);
            this.profileGroupBox.Controls.Add(this.choosePhotoBtn);
            this.profileGroupBox.Controls.Add(this.panel4);
            this.profileGroupBox.Controls.Add(this.panel3);
            this.profileGroupBox.Controls.Add(this.saveProfileBtn);
            this.profileGroupBox.Controls.Add(this.allergiesTextBox);
            this.profileGroupBox.Controls.Add(this.allergiesLabel);
            this.profileGroupBox.Controls.Add(this.waitForParentLabel);
            this.profileGroupBox.Controls.Add(this.pictureBox);
            this.profileGroupBox.Controls.Add(this.firstNameLabel);
            this.profileGroupBox.Controls.Add(this.ageLabel);
            this.profileGroupBox.Controls.Add(this.firstNameTextBox);
            this.profileGroupBox.Controls.Add(this.lastNameTextBox);
            this.profileGroupBox.Controls.Add(this.ageUpDown);
            this.profileGroupBox.Controls.Add(this.lastNameLabel);
            this.profileGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.profileGroupBox.Location = new System.Drawing.Point(472, 3);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(527, 470);
            this.profileGroupBox.TabIndex = 16;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profil";
            // 
            // photoFileNameTextBox
            // 
            this.photoFileNameTextBox.Location = new System.Drawing.Point(364, 282);
            this.photoFileNameTextBox.Name = "photoFileNameTextBox";
            this.photoFileNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.photoFileNameTextBox.TabIndex = 26;
            // 
            // choosePhotoBtn
            // 
            this.choosePhotoBtn.Location = new System.Drawing.Point(279, 281);
            this.choosePhotoBtn.Name = "choosePhotoBtn";
            this.choosePhotoBtn.Size = new System.Drawing.Size(79, 23);
            this.choosePhotoBtn.TabIndex = 25;
            this.choosePhotoBtn.Text = "Choisir photo";
            this.choosePhotoBtn.UseVisualStyleBackColor = true;
            this.choosePhotoBtn.Click += new System.EventHandler(this.choosePhotoBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.genderFemaleBtn);
            this.panel4.Controls.Add(this.genderMaleBtn);
            this.panel4.Location = new System.Drawing.Point(100, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 27);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.waitForParentNoBtn);
            this.panel3.Controls.Add(this.waitForParentYesBtn);
            this.panel3.Location = new System.Drawing.Point(100, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 34);
            this.panel3.TabIndex = 23;
            // 
            // waitForParentNoBtn
            // 
            this.waitForParentNoBtn.AutoSize = true;
            this.waitForParentNoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.waitForParentNoBtn.Location = new System.Drawing.Point(66, 0);
            this.waitForParentNoBtn.Name = "waitForParentNoBtn";
            this.waitForParentNoBtn.Size = new System.Drawing.Size(45, 34);
            this.waitForParentNoBtn.TabIndex = 1;
            this.waitForParentNoBtn.TabStop = true;
            this.waitForParentNoBtn.Text = "Non";
            this.waitForParentNoBtn.UseVisualStyleBackColor = true;
            // 
            // waitForParentYesBtn
            // 
            this.waitForParentYesBtn.AutoSize = true;
            this.waitForParentYesBtn.Checked = true;
            this.waitForParentYesBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.waitForParentYesBtn.Location = new System.Drawing.Point(0, 0);
            this.waitForParentYesBtn.Name = "waitForParentYesBtn";
            this.waitForParentYesBtn.Size = new System.Drawing.Size(41, 34);
            this.waitForParentYesBtn.TabIndex = 0;
            this.waitForParentYesBtn.TabStop = true;
            this.waitForParentYesBtn.Text = "Oui";
            this.waitForParentYesBtn.UseVisualStyleBackColor = true;
            // 
            // saveProfileBtn
            // 
            this.saveProfileBtn.Location = new System.Drawing.Point(9, 467);
            this.saveProfileBtn.Name = "saveProfileBtn";
            this.saveProfileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveProfileBtn.TabIndex = 22;
            this.saveProfileBtn.Text = "Enregistrer";
            this.saveProfileBtn.UseVisualStyleBackColor = true;
            this.saveProfileBtn.Click += new System.EventHandler(this.saveProfileBtn_Click);
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.Location = new System.Drawing.Point(9, 237);
            this.allergiesTextBox.Multiline = true;
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(249, 174);
            this.allergiesTextBox.TabIndex = 21;
            // 
            // allergiesLabel
            // 
            this.allergiesLabel.AutoSize = true;
            this.allergiesLabel.Location = new System.Drawing.Point(9, 220);
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
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::SundaySchool.Properties.Resources.photo_par_defaut;
            this.pictureBox.Location = new System.Drawing.Point(279, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(242, 241);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.barCodeLabel.Location = new System.Drawing.Point(0, 5);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(56, 13);
            this.barCodeLabel.TabIndex = 17;
            this.barCodeLabel.Text = "Identifiant:";
            // 
            // registeredProfilesDataGridView
            // 
            this.registeredProfilesDataGridView.AllowUserToAddRows = false;
            this.registeredProfilesDataGridView.AllowUserToDeleteRows = false;
            this.registeredProfilesDataGridView.AllowUserToResizeColumns = false;
            this.registeredProfilesDataGridView.AllowUserToResizeRows = false;
            this.registeredProfilesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registeredProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredProfilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameCol,
            this.lastNameCol,
            this.ageCol,
            this.genderCol,
            this.allergiesCol,
            this.waitForParentCol,
            this.barCodeCol,
            this.pictureFileNameCol});
            this.registeredProfilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registeredProfilesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.registeredProfilesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.registeredProfilesDataGridView.MultiSelect = false;
            this.registeredProfilesDataGridView.Name = "registeredProfilesDataGridView";
            this.registeredProfilesDataGridView.ReadOnly = true;
            this.registeredProfilesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registeredProfilesDataGridView.Size = new System.Drawing.Size(463, 419);
            this.registeredProfilesDataGridView.TabIndex = 20;
            this.registeredProfilesDataGridView.SelectionChanged += new System.EventHandler(this.registeredProfilesDataGridView_SelectionChanged);
            // 
            // firstNameCol
            // 
            this.firstNameCol.DataPropertyName = "FirstName";
            this.firstNameCol.HeaderText = "Prénom";
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.ReadOnly = true;
            // 
            // lastNameCol
            // 
            this.lastNameCol.DataPropertyName = "LastName";
            this.lastNameCol.HeaderText = "Nom";
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.ReadOnly = true;
            // 
            // ageCol
            // 
            this.ageCol.DataPropertyName = "Age";
            this.ageCol.HeaderText = "Age";
            this.ageCol.Name = "ageCol";
            this.ageCol.ReadOnly = true;
            // 
            // genderCol
            // 
            this.genderCol.DataPropertyName = "Gender";
            this.genderCol.HeaderText = "Sexe";
            this.genderCol.Name = "genderCol";
            this.genderCol.ReadOnly = true;
            this.genderCol.Visible = false;
            // 
            // allergiesCol
            // 
            this.allergiesCol.DataPropertyName = "Allergies";
            this.allergiesCol.HeaderText = "Allergies";
            this.allergiesCol.Name = "allergiesCol";
            this.allergiesCol.ReadOnly = true;
            this.allergiesCol.Visible = false;
            // 
            // waitForParentCol
            // 
            this.waitForParentCol.DataPropertyName = "WaitForParent";
            this.waitForParentCol.HeaderText = "Attendre Parent";
            this.waitForParentCol.Name = "waitForParentCol";
            this.waitForParentCol.ReadOnly = true;
            // 
            // barCodeCol
            // 
            this.barCodeCol.DataPropertyName = "BarCode";
            this.barCodeCol.HeaderText = "Identifiant";
            this.barCodeCol.Name = "barCodeCol";
            this.barCodeCol.ReadOnly = true;
            this.barCodeCol.Visible = false;
            // 
            // pictureFileNameCol
            // 
            this.pictureFileNameCol.DataPropertyName = "PictureFileName";
            this.pictureFileNameCol.HeaderText = "Photo";
            this.pictureFileNameCol.Name = "pictureFileNameCol";
            this.pictureFileNameCol.ReadOnly = true;
            this.pictureFileNameCol.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.profileListGroupBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 470);
            this.panel2.TabIndex = 22;
            // 
            // profileListGroupBox
            // 
            this.profileListGroupBox.Controls.Add(this.registeredProfilesDataGridView);
            this.profileListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileListGroupBox.Location = new System.Drawing.Point(0, 32);
            this.profileListGroupBox.Name = "profileListGroupBox";
            this.profileListGroupBox.Size = new System.Drawing.Size(469, 438);
            this.profileListGroupBox.TabIndex = 21;
            this.profileListGroupBox.TabStop = false;
            this.profileListGroupBox.Text = "Liste des profils";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barCodeLabel);
            this.panel1.Controls.Add(this.barcodeTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(469, 32);
            this.panel1.TabIndex = 22;
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.InitialDirectory = "C:\\Users\\Public\\Documents";
            // 
            // mainwindowTabControl
            // 
            this.mainwindowTabControl.Controls.Add(this.profilesTabPage);
            this.mainwindowTabControl.Controls.Add(this.checkinTabPage);
            this.mainwindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainwindowTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainwindowTabControl.Name = "mainwindowTabControl";
            this.mainwindowTabControl.SelectedIndex = 0;
            this.mainwindowTabControl.Size = new System.Drawing.Size(1010, 502);
            this.mainwindowTabControl.TabIndex = 27;
            // 
            // profilesTabPage
            // 
            this.profilesTabPage.Controls.Add(this.panel2);
            this.profilesTabPage.Controls.Add(this.profileGroupBox);
            this.profilesTabPage.Location = new System.Drawing.Point(4, 22);
            this.profilesTabPage.Name = "profilesTabPage";
            this.profilesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profilesTabPage.Size = new System.Drawing.Size(1002, 476);
            this.profilesTabPage.TabIndex = 0;
            this.profilesTabPage.Text = "Profils";
            this.profilesTabPage.UseVisualStyleBackColor = true;
            // 
            // checkinTabPage
            // 
            this.checkinTabPage.Controls.Add(this.checkinDataGridView);
            this.checkinTabPage.Location = new System.Drawing.Point(4, 22);
            this.checkinTabPage.Name = "checkinTabPage";
            this.checkinTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkinTabPage.Size = new System.Drawing.Size(1002, 476);
            this.checkinTabPage.TabIndex = 1;
            this.checkinTabPage.Text = "Présences";
            this.checkinTabPage.UseVisualStyleBackColor = true;
            // 
            // checkinDataGridView
            // 
            this.checkinDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileFirstNameCol,
            this.profileLastNameCol,
            this.profileWaitForParentCol,
            this.checkinTimeCol,
            this.checkoutTimeCol,
            this.commentsCol,
            this.personCol});
            this.checkinDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinDataGridView.Location = new System.Drawing.Point(3, 3);
            this.checkinDataGridView.Name = "checkinDataGridView";
            this.checkinDataGridView.Size = new System.Drawing.Size(996, 470);
            this.checkinDataGridView.TabIndex = 0;
            this.checkinDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.checkinDataGridView_CellFormatting);
            // 
            // profileFirstNameCol
            // 
            this.profileFirstNameCol.DataPropertyName = "Person.FirstName";
            this.profileFirstNameCol.HeaderText = "Prénom";
            this.profileFirstNameCol.Name = "profileFirstNameCol";
            this.profileFirstNameCol.ReadOnly = true;
            // 
            // profileLastNameCol
            // 
            this.profileLastNameCol.DataPropertyName = "Person.LastName";
            this.profileLastNameCol.HeaderText = "Nom";
            this.profileLastNameCol.Name = "profileLastNameCol";
            this.profileLastNameCol.ReadOnly = true;
            // 
            // profileWaitForParentCol
            // 
            this.profileWaitForParentCol.DataPropertyName = "Person.WaitForParent";
            this.profileWaitForParentCol.HeaderText = "Attendre Parent";
            this.profileWaitForParentCol.Name = "profileWaitForParentCol";
            this.profileWaitForParentCol.ReadOnly = true;
            this.profileWaitForParentCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.profileWaitForParentCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // checkinTimeCol
            // 
            this.checkinTimeCol.DataPropertyName = "CheckinTime";
            this.checkinTimeCol.HeaderText = "Enregistré";
            this.checkinTimeCol.Name = "checkinTimeCol";
            this.checkinTimeCol.ReadOnly = true;
            // 
            // checkoutTimeCol
            // 
            this.checkoutTimeCol.DataPropertyName = "CheckoutTime";
            this.checkoutTimeCol.HeaderText = "Quitté";
            this.checkoutTimeCol.Name = "checkoutTimeCol";
            this.checkoutTimeCol.ReadOnly = true;
            // 
            // commentsCol
            // 
            this.commentsCol.DataPropertyName = "Comments";
            this.commentsCol.HeaderText = "Commentaires";
            this.commentsCol.Name = "commentsCol";
            // 
            // personCol
            // 
            this.personCol.DataPropertyName = "Person";
            this.personCol.HeaderText = "Personne";
            this.personCol.Name = "personCol";
            this.personCol.ReadOnly = true;
            this.personCol.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 502);
            this.Controls.Add(this.mainwindowTabControl);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.profileGroupBox.ResumeLayout(false);
            this.profileGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.profileListGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainwindowTabControl.ResumeLayout(false);
            this.profilesTabPage.ResumeLayout(false);
            this.checkinTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkinDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label allergiesLabel;
        private System.Windows.Forms.Label waitForParentLabel;
        private System.Windows.Forms.RadioButton waitForParentNoBtn;
        private System.Windows.Forms.RadioButton waitForParentYesBtn;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.Button saveProfileBtn;
        private System.Windows.Forms.DataGridView registeredProfilesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waitForParentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureFileNameCol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox profileListGroupBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button choosePhotoBtn;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.TextBox photoFileNameTextBox;
        private System.Windows.Forms.TabControl mainwindowTabControl;
        private System.Windows.Forms.TabPage profilesTabPage;
        private System.Windows.Forms.TabPage checkinTabPage;
        private System.Windows.Forms.DataGridView checkinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileFirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileLastNameCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn profileWaitForParentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCol;
    }
}

