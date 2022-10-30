namespace RFID
{
    partial class MenuForm
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbViewProfile = new System.Windows.Forms.PictureBox();
            this.labelViewProfile = new System.Windows.Forms.Label();
            this.pbBorrowBooks = new System.Windows.Forms.PictureBox();
            this.pbViewBook = new System.Windows.Forms.PictureBox();
            this.labelViewBooks = new System.Windows.Forms.Label();
            this.labelBorrowBook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(79, 113);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(82, 16);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 358);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hei";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID.Properties.Resources.profile_user1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbViewProfile
            // 
            this.pbViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewProfile.Image = global::RFID.Properties.Resources.ViewProfile;
            this.pbViewProfile.Location = new System.Drawing.Point(169, 89);
            this.pbViewProfile.Name = "pbViewProfile";
            this.pbViewProfile.Size = new System.Drawing.Size(151, 118);
            this.pbViewProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewProfile.TabIndex = 9;
            this.pbViewProfile.TabStop = false;
            this.pbViewProfile.Click += new System.EventHandler(this.pbViewProfile_Click);
            // 
            // labelViewProfile
            // 
            this.labelViewProfile.AutoSize = true;
            this.labelViewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.labelViewProfile.Location = new System.Drawing.Point(210, 56);
            this.labelViewProfile.Name = "labelViewProfile";
            this.labelViewProfile.Size = new System.Drawing.Size(69, 15);
            this.labelViewProfile.TabIndex = 10;
            this.labelViewProfile.Text = "View Profile";
            // 
            // pbBorrowBooks
            // 
            this.pbBorrowBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBorrowBooks.Image = global::RFID.Properties.Resources.borrow;
            this.pbBorrowBooks.Location = new System.Drawing.Point(527, 89);
            this.pbBorrowBooks.Name = "pbBorrowBooks";
            this.pbBorrowBooks.Size = new System.Drawing.Size(166, 118);
            this.pbBorrowBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBorrowBooks.TabIndex = 11;
            this.pbBorrowBooks.TabStop = false;
            this.pbBorrowBooks.Click += new System.EventHandler(this.pbBorrowBooks_Click);
            // 
            // pbViewBook
            // 
            this.pbViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewBook.Image = global::RFID.Properties.Resources.book;
            this.pbViewBook.Location = new System.Drawing.Point(357, 89);
            this.pbViewBook.Name = "pbViewBook";
            this.pbViewBook.Size = new System.Drawing.Size(148, 118);
            this.pbViewBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewBook.TabIndex = 12;
            this.pbViewBook.TabStop = false;
            this.pbViewBook.Click += new System.EventHandler(this.pbViewBook_Click);
            // 
            // labelViewBooks
            // 
            this.labelViewBooks.AutoSize = true;
            this.labelViewBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.labelViewBooks.Location = new System.Drawing.Point(393, 56);
            this.labelViewBooks.Name = "labelViewBooks";
            this.labelViewBooks.Size = new System.Drawing.Size(67, 15);
            this.labelViewBooks.TabIndex = 13;
            this.labelViewBooks.Text = "View Books";
            // 
            // labelBorrowBook
            // 
            this.labelBorrowBook.AutoSize = true;
            this.labelBorrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.labelBorrowBook.Location = new System.Drawing.Point(570, 56);
            this.labelBorrowBook.Name = "labelBorrowBook";
            this.labelBorrowBook.Size = new System.Drawing.Size(75, 15);
            this.labelBorrowBook.TabIndex = 14;
            this.labelBorrowBook.Text = "Borrow Book";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 359);
            this.Controls.Add(this.labelBorrowBook);
            this.Controls.Add(this.labelViewBooks);
            this.Controls.Add(this.pbViewBook);
            this.Controls.Add(this.pbBorrowBooks);
            this.Controls.Add(this.labelViewProfile);
            this.Controls.Add(this.pbViewProfile);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogOut;
        private Button btnViewProfile;
        private TextBox textBoxUsername;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pbViewProfile;
        private Label labelViewProfile;
        private PictureBox pbBorrowBooks;
        private PictureBox pbViewBooks;
        private PictureBox pbViewBook;
        private Label labelViewBooks;
        private Label labelBorrowBook;
    }
}