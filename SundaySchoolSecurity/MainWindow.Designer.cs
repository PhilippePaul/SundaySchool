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
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.registeredProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitForParentCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileListGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createProfileBtn = new System.Windows.Forms.Button();
            this.deleteProfileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainwindowTabControl = new System.Windows.Forms.TabControl();
            this.profilesTabPage = new System.Windows.Forms.TabPage();
            this.checkinTabPage = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkinDataGridView = new System.Windows.Forms.DataGridView();
            this.profileFirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileLastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileWaitForParentCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkinTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_profileEditor = new SundaySchool.ProfileEditor();
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.profileListGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainwindowTabControl.SuspendLayout();
            this.profilesTabPage.SuspendLayout();
            this.checkinTabPage.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinDataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTxtBox
            // 
            this.idTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.idTxtBox.Location = new System.Drawing.Point(56, 5);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(279, 20);
            this.idTxtBox.TabIndex = 1;
            this.idTxtBox.TextChanged += new System.EventHandler(this.idTxtBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(0, 5);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(56, 13);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "Identifiant:";
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
            this.idCol,
            this.pictureFileNameCol});
            this.registeredProfilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registeredProfilesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.registeredProfilesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.registeredProfilesDataGridView.MultiSelect = false;
            this.registeredProfilesDataGridView.Name = "registeredProfilesDataGridView";
            this.registeredProfilesDataGridView.ReadOnly = true;
            this.registeredProfilesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registeredProfilesDataGridView.Size = new System.Drawing.Size(656, 419);
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
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Identifiant";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
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
            this.panel2.Size = new System.Drawing.Size(662, 523);
            this.panel2.TabIndex = 22;
            // 
            // profileListGroupBox
            // 
            this.profileListGroupBox.Controls.Add(this.registeredProfilesDataGridView);
            this.profileListGroupBox.Controls.Add(this.groupBox1);
            this.profileListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileListGroupBox.Location = new System.Drawing.Point(0, 32);
            this.profileListGroupBox.Name = "profileListGroupBox";
            this.profileListGroupBox.Size = new System.Drawing.Size(662, 491);
            this.profileListGroupBox.TabIndex = 21;
            this.profileListGroupBox.TabStop = false;
            this.profileListGroupBox.Text = "Liste des profils";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createProfileBtn);
            this.groupBox1.Controls.Add(this.deleteProfileBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 435);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(656, 53);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // createProfileBtn
            // 
            this.createProfileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.createProfileBtn.Location = new System.Drawing.Point(418, 13);
            this.createProfileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.createProfileBtn.Name = "createProfileBtn";
            this.createProfileBtn.Size = new System.Drawing.Size(123, 40);
            this.createProfileBtn.TabIndex = 22;
            this.createProfileBtn.Text = "Ajouter..";
            this.createProfileBtn.UseVisualStyleBackColor = true;
            this.createProfileBtn.Click += new System.EventHandler(this.createProfileBtn_Click);
            // 
            // deleteProfileBtn
            // 
            this.deleteProfileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteProfileBtn.Location = new System.Drawing.Point(541, 13);
            this.deleteProfileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteProfileBtn.Name = "deleteProfileBtn";
            this.deleteProfileBtn.Size = new System.Drawing.Size(115, 40);
            this.deleteProfileBtn.TabIndex = 21;
            this.deleteProfileBtn.Text = "Supprimer";
            this.deleteProfileBtn.UseVisualStyleBackColor = true;
            this.deleteProfileBtn.Click += new System.EventHandler(this.deleteProfileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idTxtBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(662, 32);
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
            this.mainwindowTabControl.Size = new System.Drawing.Size(1134, 555);
            this.mainwindowTabControl.TabIndex = 27;
            // 
            // profilesTabPage
            // 
            this.profilesTabPage.Controls.Add(this.panel2);
            this.profilesTabPage.Controls.Add(this.m_profileEditor);
            this.profilesTabPage.Location = new System.Drawing.Point(4, 22);
            this.profilesTabPage.Name = "profilesTabPage";
            this.profilesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profilesTabPage.Size = new System.Drawing.Size(1126, 529);
            this.profilesTabPage.TabIndex = 0;
            this.profilesTabPage.Text = "Profils";
            this.profilesTabPage.UseVisualStyleBackColor = true;
            // 
            // checkinTabPage
            // 
            this.checkinTabPage.Controls.Add(this.panel5);
            this.checkinTabPage.Location = new System.Drawing.Point(4, 22);
            this.checkinTabPage.Name = "checkinTabPage";
            this.checkinTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkinTabPage.Size = new System.Drawing.Size(1126, 529);
            this.checkinTabPage.TabIndex = 1;
            this.checkinTabPage.Text = "Présences";
            this.checkinTabPage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkinDataGridView);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1120, 523);
            this.panel5.TabIndex = 1;
            // 
            // checkinDataGridView
            // 
            this.checkinDataGridView.AllowUserToAddRows = false;
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
            this.checkinDataGridView.Location = new System.Drawing.Point(0, 34);
            this.checkinDataGridView.Name = "checkinDataGridView";
            this.checkinDataGridView.Size = new System.Drawing.Size(1120, 489);
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
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1120, 34);
            this.panel6.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Désinscrire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inscrire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 0;
            // 
            // m_profileEditor
            // 
            this.m_profileEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_profileEditor.Location = new System.Drawing.Point(665, 3);
            this.m_profileEditor.Name = "m_profileEditor";
            this.m_profileEditor.Size = new System.Drawing.Size(458, 523);
            this.m_profileEditor.TabIndex = 23;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 555);
            this.Controls.Add(this.mainwindowTabControl);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.registeredProfilesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.profileListGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainwindowTabControl.ResumeLayout(false);
            this.profilesTabPage.ResumeLayout(false);
            this.checkinTabPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinDataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView registeredProfilesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waitForParentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureFileNameCol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox profileListGroupBox;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button createProfileBtn;
        private System.Windows.Forms.Button deleteProfileBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProfileEditor m_profileEditor;
    }
}

