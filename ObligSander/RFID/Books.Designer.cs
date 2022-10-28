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
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.textBoxDeleteBook = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewBook
            // 
            this.dgvViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBook.Location = new System.Drawing.Point(367, 9);
            this.dgvViewBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.RowHeadersWidth = 51;
            this.dgvViewBook.RowTemplate.Height = 29;
            this.dgvViewBook.Size = new System.Drawing.Size(997, 537);
            this.dgvViewBook.TabIndex = 0;
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(154, 75);
            this.btnViewBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(132, 22);
            this.btnViewBook.TabIndex = 1;
            this.btnViewBook.Text = "View Books";
            this.btnViewBook.UseVisualStyleBackColor = true;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(154, 101);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(132, 22);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(154, 237);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(132, 22);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // textBoxDeleteBook
            // 
            this.textBoxDeleteBook.Location = new System.Drawing.Point(154, 212);
            this.textBoxDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteBook.Name = "textBoxDeleteBook";
            this.textBoxDeleteBook.Size = new System.Drawing.Size(133, 23);
            this.textBoxDeleteBook.TabIndex = 5;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(18, 8);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(149, 23);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 666);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.textBoxDeleteBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.dgvViewBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Button btnDeleteBook;
        private TextBox textBoxDeleteBook;
        private Button btnBackToMenu;
    }
}