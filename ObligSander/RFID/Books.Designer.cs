namespace RFID
{
    partial class Books
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
            this.dgvViewBook = new System.Windows.Forms.DataGridView();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnChangeBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.textBoxDeleteBook = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewBook
            // 
            this.dgvViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBook.Location = new System.Drawing.Point(419, 12);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.RowHeadersWidth = 51;
            this.dgvViewBook.RowTemplate.Height = 29;
            this.dgvViewBook.Size = new System.Drawing.Size(750, 488);
            this.dgvViewBook.TabIndex = 0;
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(176, 100);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(151, 29);
            this.btnViewBook.TabIndex = 1;
            this.btnViewBook.Text = "View Books";
            this.btnViewBook.UseVisualStyleBackColor = true;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(176, 135);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(151, 29);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnChangeBook
            // 
            this.btnChangeBook.Location = new System.Drawing.Point(176, 170);
            this.btnChangeBook.Name = "btnChangeBook";
            this.btnChangeBook.Size = new System.Drawing.Size(151, 29);
            this.btnChangeBook.TabIndex = 3;
            this.btnChangeBook.Text = "Change Book";
            this.btnChangeBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(176, 316);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(151, 29);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // textBoxDeleteBook
            // 
            this.textBoxDeleteBook.Location = new System.Drawing.Point(176, 283);
            this.textBoxDeleteBook.Name = "textBoxDeleteBook";
            this.textBoxDeleteBook.Size = new System.Drawing.Size(151, 27);
            this.textBoxDeleteBook.TabIndex = 5;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 512);
            this.Controls.Add(this.textBoxDeleteBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnChangeBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.dgvViewBook);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvViewBook;
        private Button btnViewBook;
        private Button btnAddBook;
        private Button btnChangeBook;
        private Button btnDeleteBook;
        private TextBox textBoxDeleteBook;
    }
}