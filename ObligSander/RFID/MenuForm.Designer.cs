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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.bntBorrowBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(15, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 22);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(200, 130);
            this.btnViewProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(82, 79);
            this.btnViewProfile.TabIndex = 1;
            this.btnViewProfile.Text = "View Pefile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(301, 130);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(82, 78);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "View Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // bntBorrowBook
            // 
            this.bntBorrowBook.Location = new System.Drawing.Point(409, 130);
            this.bntBorrowBook.Name = "bntBorrowBook";
            this.bntBorrowBook.Size = new System.Drawing.Size(82, 78);
            this.bntBorrowBook.TabIndex = 3;
            this.bntBorrowBook.Text = "Borrow Book";
            this.bntBorrowBook.UseVisualStyleBackColor = true;
            this.bntBorrowBook.Click += new System.EventHandler(this.bntBorrowBook_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.bntBorrowBook);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogOut;
        private Button btnViewProfile;
        private Button btnBooks;
        private Button bntBorrowBook;
    }
}