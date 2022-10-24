namespace RFID
{
    partial class UserProfile
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
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.btnUploadProfilePic = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.textBoxDeleteAccount = new System.Windows.Forms.TextBox();
            this.btnUpdateUsernamePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(0, 0);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(159, 175);
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
            // 
            // btnUploadProfilePic
            // 
            this.btnUploadProfilePic.Location = new System.Drawing.Point(25, 196);
            this.btnUploadProfilePic.Name = "btnUploadProfilePic";
            this.btnUploadProfilePic.Size = new System.Drawing.Size(231, 29);
            this.btnUploadProfilePic.TabIndex = 1;
            this.btnUploadProfilePic.Text = "Upload picture";
            this.btnUploadProfilePic.UseVisualStyleBackColor = true;
            this.btnUploadProfilePic.Click += new System.EventHandler(this.btnUploadProfilePic_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(25, 239);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(231, 34);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.Text = "Update Personlia";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(25, 350);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(231, 29);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete Account";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // textBoxDeleteAccount
            // 
            this.textBoxDeleteAccount.Location = new System.Drawing.Point(278, 352);
            this.textBoxDeleteAccount.Name = "textBoxDeleteAccount";
            this.textBoxDeleteAccount.Size = new System.Drawing.Size(125, 27);
            this.textBoxDeleteAccount.TabIndex = 20;
            // 
            // btnUpdateUsernamePassword
            // 
            this.btnUpdateUsernamePassword.Location = new System.Drawing.Point(25, 299);
            this.btnUpdateUsernamePassword.Name = "btnUpdateUsernamePassword";
            this.btnUpdateUsernamePassword.Size = new System.Drawing.Size(231, 31);
            this.btnUpdateUsernamePassword.TabIndex = 21;
            this.btnUpdateUsernamePassword.Text = "Update Uername/ Password";
            this.btnUpdateUsernamePassword.UseVisualStyleBackColor = true;
            this.btnUpdateUsernamePassword.Click += new System.EventHandler(this.btnUpdateUsernamePassword_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 581);
            this.Controls.Add(this.btnUpdateUsernamePassword);
            this.Controls.Add(this.textBoxDeleteAccount);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnUploadProfilePic);
            this.Controls.Add(this.pbProfilePic);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbProfilePic;
        private Button btnUploadProfilePic;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private TextBox textBoxDeleteAccount;
        private Button btnUpdateUsernamePassword;
    }
}