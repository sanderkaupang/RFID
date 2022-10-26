namespace RFID
{
    partial class AddBooks
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
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPagecount = new System.Windows.Forms.Label();
            this.textBoxPagecount = new System.Windows.Forms.TextBox();
            this.labelBookType = new System.Windows.Forms.Label();
            this.textBoxBookType = new System.Windows.Forms.TextBox();
            this.AutherFirstname = new System.Windows.Forms.Label();
            this.textBoxAutherFirstname = new System.Windows.Forms.TextBox();
            this.textBoxAutherLastname = new System.Windows.Forms.TextBox();
            this.AutherLastname = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(70, 56);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(125, 27);
            this.textBoxBookTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Book Title";
            // 
            // labelPagecount
            // 
            this.labelPagecount.AutoSize = true;
            this.labelPagecount.Location = new System.Drawing.Point(70, 104);
            this.labelPagecount.Name = "labelPagecount";
            this.labelPagecount.Size = new System.Drawing.Size(78, 20);
            this.labelPagecount.TabIndex = 2;
            this.labelPagecount.Text = "Pagecount";
            // 
            // textBoxPagecount
            // 
            this.textBoxPagecount.Location = new System.Drawing.Point(70, 137);
            this.textBoxPagecount.Name = "textBoxPagecount";
            this.textBoxPagecount.Size = new System.Drawing.Size(125, 27);
            this.textBoxPagecount.TabIndex = 3;
            // 
            // labelBookType
            // 
            this.labelBookType.AutoSize = true;
            this.labelBookType.Location = new System.Drawing.Point(70, 186);
            this.labelBookType.Name = "labelBookType";
            this.labelBookType.Size = new System.Drawing.Size(78, 20);
            this.labelBookType.TabIndex = 4;
            this.labelBookType.Text = "Book Type";
            // 
            // textBoxBookType
            // 
            this.textBoxBookType.Location = new System.Drawing.Point(70, 218);
            this.textBoxBookType.Name = "textBoxBookType";
            this.textBoxBookType.Size = new System.Drawing.Size(125, 27);
            this.textBoxBookType.TabIndex = 5;
            // 
            // AutherFirstname
            // 
            this.AutherFirstname.AutoSize = true;
            this.AutherFirstname.Location = new System.Drawing.Point(70, 278);
            this.AutherFirstname.Name = "AutherFirstname";
            this.AutherFirstname.Size = new System.Drawing.Size(122, 20);
            this.AutherFirstname.TabIndex = 6;
            this.AutherFirstname.Text = "Author Firstname";
            // 
            // textBoxAutherFirstname
            // 
            this.textBoxAutherFirstname.Location = new System.Drawing.Point(70, 310);
            this.textBoxAutherFirstname.Name = "textBoxAutherFirstname";
            this.textBoxAutherFirstname.Size = new System.Drawing.Size(125, 27);
            this.textBoxAutherFirstname.TabIndex = 7;
            // 
            // textBoxAutherLastname
            // 
            this.textBoxAutherLastname.Location = new System.Drawing.Point(67, 391);
            this.textBoxAutherLastname.Name = "textBoxAutherLastname";
            this.textBoxAutherLastname.Size = new System.Drawing.Size(125, 27);
            this.textBoxAutherLastname.TabIndex = 9;
            // 
            // AutherLastname
            // 
            this.AutherLastname.AutoSize = true;
            this.AutherLastname.Location = new System.Drawing.Point(67, 359);
            this.AutherLastname.Name = "AutherLastname";
            this.AutherLastname.Size = new System.Drawing.Size(121, 20);
            this.AutherLastname.TabIndex = 8;
            this.AutherLastname.Text = "Author Lastname";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(234, 365);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 53);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.textBoxAutherLastname);
            this.Controls.Add(this.AutherLastname);
            this.Controls.Add(this.textBoxAutherFirstname);
            this.Controls.Add(this.AutherFirstname);
            this.Controls.Add(this.textBoxBookType);
            this.Controls.Add(this.labelBookType);
            this.Controls.Add(this.textBoxPagecount);
            this.Controls.Add(this.labelPagecount);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxBookTitle);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBookTitle;
        private Label labelTitle;
        private Label labelPagecount;
        private TextBox textBoxPagecount;
        private Label labelBookType;
        private TextBox textBoxBookType;
        private Label AutherFirstname;
        private TextBox textBoxAutherFirstname;
        private TextBox textBoxAutherLastname;
        private Label AutherLastname;
        private Button btnAddBook;
    }
}