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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewBook
            // 
            this.dgvViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.dgvViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBook.Location = new System.Drawing.Point(360, 9);
            this.dgvViewBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.RowHeadersWidth = 51;
            this.dgvViewBook.RowTemplate.Height = 29;
            this.dgvViewBook.Size = new System.Drawing.Size(997, 387);
            this.dgvViewBook.TabIndex = 0;
            // 
            // btnViewBook
            // 
            this.btnViewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewBook.ForeColor = System.Drawing.Color.White;
            this.btnViewBook.Location = new System.Drawing.Point(156, 75);
            this.btnViewBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(132, 35);
            this.btnViewBook.TabIndex = 1;
            this.btnViewBook.Text = "View Books";
            this.btnViewBook.UseVisualStyleBackColor = false;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(18, 74);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(132, 36);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(41, 153);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(183, 22);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // textBoxDeleteBook
            // 
            this.textBoxDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.textBoxDeleteBook.Location = new System.Drawing.Point(91, 79);
            this.textBoxDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteBook.Name = "textBoxDeleteBook";
            this.textBoxDeleteBook.Size = new System.Drawing.Size(133, 23);
            this.textBoxDeleteBook.TabIndex = 5;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(18, 8);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(149, 23);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnDeleteBook);
            this.groupBox1.Controls.Add(this.textBoxDeleteBook);
            this.groupBox1.Location = new System.Drawing.Point(18, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Title to Delete";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(41, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID.Properties.Resources.bin;
            this.pictureBox1.Location = new System.Drawing.Point(52, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.dgvViewBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvViewBook;
        private Button btnViewBook;
        private Button btnAddBook;
        private Button btnDeleteBook;
        private TextBox textBoxDeleteBook;
        private Button btnBackToMenu;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}