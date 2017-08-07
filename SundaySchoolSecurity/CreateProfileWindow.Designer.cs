namespace SundaySchool
{
    partial class CreateProfileWindow
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
            this.profileEditor1 = new SundaySchool.ProfileEditor();
            this.SuspendLayout();
            // 
            // profileEditor1
            // 
            this.profileEditor1.AutoSize = true;
            this.profileEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileEditor1.Location = new System.Drawing.Point(0, 0);
            this.profileEditor1.Name = "profileEditor1";
            this.profileEditor1.Size = new System.Drawing.Size(530, 476);
            this.profileEditor1.TabIndex = 0;
            // 
            // CreateProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(530, 476);
            this.Controls.Add(this.profileEditor1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProfileWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProfileEditor profileEditor1;
    }
}