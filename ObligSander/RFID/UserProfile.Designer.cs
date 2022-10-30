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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.textBoxDeleteAccount = new System.Windows.Forms.TextBox();
            this.btnUpdateUsernamePassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelphonenumber = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(36, 206);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(141, 41);
            this.btnUpdateUser.TabIndex = 17;
            this.btnUpdateUser.Text = "Update Personlia";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(17, 116);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(202, 22);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete Account";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
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
            this.btnUpdateUsernamePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnUpdateUsernamePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUsernamePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdateUsernamePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsernamePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUsernamePassword.Location = new System.Drawing.Point(36, 144);
            this.btnUpdateUsernamePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateUsernamePassword.Name = "btnUpdateUsernamePassword";
            this.btnUpdateUsernamePassword.Size = new System.Drawing.Size(141, 46);
            this.btnUpdateUsernamePassword.TabIndex = 21;
            this.btnUpdateUsernamePassword.Text = "Update Uername/ Password";
            this.btnUpdateUsernamePassword.UseVisualStyleBackColor = false;
            this.btnUpdateUsernamePassword.Click += new System.EventHandler(this.btnUpdateUsernamePassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelphonenumber);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.textBoxDeleteAccount);
            this.groupBox1.Location = new System.Drawing.Point(268, 89);
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
            this.labelphonenumber.Size = new System.Drawing.Size(61, 15);
            this.labelphonenumber.TabIndex = 21;
            this.labelphonenumber.Text = "Enter RFID";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.buttonBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenu.Location = new System.Drawing.Point(12, 13);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(147, 23);
            this.buttonBackToMenu.TabIndex = 23;
            this.buttonBackToMenu.Text = "Back To Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(45, 90);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(110, 23);
            this.textBoxUsername.TabIndex = 24;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnUpdateUsernamePassword);
            this.panel1.Controls.Add(this.buttonBackToMenu);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 534);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private TextBox textBoxDeleteAccount;
        private Button btnUpdateUsernamePassword;
        private GroupBox groupBox1;
        private Label labelphonenumber;
        private Button buttonBackToMenu;
        private TextBox textBoxUsername;
        private Panel panel1;
        private Label label1;
    }
}