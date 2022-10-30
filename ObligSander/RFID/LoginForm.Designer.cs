namespace RFID
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtBoxPin = new System.Windows.Forms.TextBox();
            this.txtBoxTag = new System.Windows.Forms.TextBox();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(156, 454);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(214, 32);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtBoxPin
            // 
            this.txtBoxPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.txtBoxPin.Location = new System.Drawing.Point(204, 401);
            this.txtBoxPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPin.Name = "txtBoxPin";
            this.txtBoxPin.PasswordChar = '*';
            this.txtBoxPin.Size = new System.Drawing.Size(158, 22);
            this.txtBoxPin.TabIndex = 1;
            // 
            // txtBoxTag
            // 
            this.txtBoxTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.txtBoxTag.Location = new System.Drawing.Point(204, 320);
            this.txtBoxTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTag.Name = "txtBoxTag";
            this.txtBoxTag.Size = new System.Drawing.Size(158, 22);
            this.txtBoxTag.TabIndex = 0;
            this.txtBoxTag.TextChanged += new System.EventHandler(this.txtBoxTag_TextChanged);
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnRegistrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrate.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrate.ForeColor = System.Drawing.Color.White;
            this.btnRegistrate.Location = new System.Drawing.Point(156, 508);
            this.btnRegistrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(214, 32);
            this.btnRegistrate.TabIndex = 1;
            this.btnRegistrate.Text = "Registrate";
            this.btnRegistrate.UseVisualStyleBackColor = false;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(156, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(204, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(156, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RFID.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(156, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RFID.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(156, 401);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(156, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 734);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxPin);
            this.Controls.Add(this.txtBoxTag);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLogIn;
        private TextBox txtBoxPin;
        private TextBox txtBoxTag;
        private Button btnRegistrate;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
    }
}