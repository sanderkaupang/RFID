﻿namespace RFID
{
    partial class UpdateUsernamePassword
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
            this.groupBoxUsernamePassword = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lablePassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Phone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.btnUpdateUsernmanePassword = new System.Windows.Forms.Button();
            this.groupBoxUsernamePassword.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsernamePassword
            // 
            this.groupBoxUsernamePassword.Controls.Add(this.label1);
            this.groupBoxUsernamePassword.Controls.Add(this.textBoxConfirmPassword);
            this.groupBoxUsernamePassword.Controls.Add(this.labelUsername);
            this.groupBoxUsernamePassword.Controls.Add(this.textBoxUsername);
            this.groupBoxUsernamePassword.Controls.Add(this.lablePassword);
            this.groupBoxUsernamePassword.Controls.Add(this.textBoxPassword);
            this.groupBoxUsernamePassword.Location = new System.Drawing.Point(12, 21);
            this.groupBoxUsernamePassword.Name = "groupBoxUsernamePassword";
            this.groupBoxUsernamePassword.Size = new System.Drawing.Size(250, 317);
            this.groupBoxUsernamePassword.TabIndex = 17;
            this.groupBoxUsernamePassword.TabStop = false;
            this.groupBoxUsernamePassword.Text = "Username and Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(6, 228);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxConfirmPassword.TabIndex = 14;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(6, 60);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 20);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 83);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(125, 27);
            this.textBoxUsername.TabIndex = 10;
            // 
            // lablePassword
            // 
            this.lablePassword.AutoSize = true;
            this.lablePassword.Location = new System.Drawing.Point(6, 133);
            this.lablePassword.Name = "lablePassword";
            this.lablePassword.Size = new System.Drawing.Size(70, 20);
            this.lablePassword.TabIndex = 13;
            this.lablePassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 156);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateUsernmanePassword);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Location = new System.Drawing.Point(305, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 295);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm with phone";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(6, 111);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(101, 20);
            this.Phone.TabIndex = 12;
            this.Phone.Text = "Phonenumber";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(6, 134);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(125, 27);
            this.textBoxPhone.TabIndex = 11;
            // 
            // btnUpdateUsernmanePassword
            // 
            this.btnUpdateUsernmanePassword.Location = new System.Drawing.Point(6, 193);
            this.btnUpdateUsernmanePassword.Name = "btnUpdateUsernmanePassword";
            this.btnUpdateUsernmanePassword.Size = new System.Drawing.Size(125, 40);
            this.btnUpdateUsernmanePassword.TabIndex = 13;
            this.btnUpdateUsernmanePassword.Text = "Update";
            this.btnUpdateUsernmanePassword.UseVisualStyleBackColor = true;
            this.btnUpdateUsernmanePassword.Click += new System.EventHandler(this.btnUpdateUsernmanePassword_Click);
            // 
            // UpdateUsernamePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUsernamePassword);
            this.Name = "UpdateUsernamePassword";
            this.Text = "UpdateUsernamePassword";
            this.Load += new System.EventHandler(this.UpdateUsernamePassword_Load);
            this.groupBoxUsernamePassword.ResumeLayout(false);
            this.groupBoxUsernamePassword.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxUsernamePassword;
        private Label label1;
        private TextBox textBoxConfirmPassword;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label lablePassword;
        private TextBox textBoxPassword;
        private GroupBox groupBox1;
        private Label Phone;
        private TextBox textBoxPhone;
        private Button btnUpdateUsernmanePassword;
    }
}