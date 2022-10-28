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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelphonenumber = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(31, 89);
            this.pbProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(202, 174);
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
            // 
            // btnUploadProfilePic
            // 
            this.btnUploadProfilePic.Location = new System.Drawing.Point(31, 267);
            this.btnUploadProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadProfilePic.Name = "btnUploadProfilePic";
            this.btnUploadProfilePic.Size = new System.Drawing.Size(202, 22);
            this.btnUploadProfilePic.TabIndex = 1;
            this.btnUploadProfilePic.Text = "Upload picture";
            this.btnUploadProfilePic.UseVisualStyleBackColor = true;
            this.btnUploadProfilePic.Click += new System.EventHandler(this.btnUploadProfilePic_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(329, 139);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(202, 26);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.Text = "Update Personlia";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(17, 116);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(202, 22);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete Account";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // textBoxDeleteAccount
            // 
            this.textBoxDeleteAccount.Location = new System.Drawing.Point(64, 77);
            this.textBoxDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteAccount.Name = "textBoxDeleteAccount";
            this.textBoxDeleteAccount.Size = new System.Drawing.Size(110, 23);
            this.textBoxDeleteAccount.TabIndex = 20;
            // 
            // btnUpdateUsernamePassword
            // 
            this.btnUpdateUsernamePassword.Location = new System.Drawing.Point(329, 174);
            this.btnUpdateUsernamePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateUsernamePassword.Name = "btnUpdateUsernamePassword";
            this.btnUpdateUsernamePassword.Size = new System.Drawing.Size(202, 23);
            this.btnUpdateUsernamePassword.TabIndex = 21;
            this.btnUpdateUsernamePassword.Text = "Update Uername/ Password";
            this.btnUpdateUsernamePassword.UseVisualStyleBackColor = true;
            this.btnUpdateUsernamePassword.Click += new System.EventHandler(this.btnUpdateUsernamePassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelphonenumber);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.textBoxDeleteAccount);
            this.groupBox1.Location = new System.Drawing.Point(596, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Account";
            // 
            // labelphonenumber
            // 
            this.labelphonenumber.AutoSize = true;
            this.labelphonenumber.Location = new System.Drawing.Point(61, 50);
            this.labelphonenumber.Name = "labelphonenumber";
            this.labelphonenumber.Size = new System.Drawing.Size(113, 15);
            this.labelphonenumber.TabIndex = 21;
            this.labelphonenumber.Text = "Enter phonenumber";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(40, 24);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(147, 23);
            this.buttonBackToMenu.TabIndex = 23;
            this.buttonBackToMenu.Text = "Back To Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(242, 24);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(110, 23);
            this.textBoxUsername.TabIndex = 24;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 545);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdateUsernamePassword);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnUploadProfilePic);
            this.Controls.Add(this.pbProfilePic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label labelphonenumber;
        private Button buttonBackToMenu;
        private TextBox textBoxUsername;
    }
}