namespace RFID
{
    partial class BorrowBook
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.brnReturn = new System.Windows.Forms.Button();
            this.textBoxRfidTag = new System.Windows.Forms.TextBox();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.textBoxFromDate = new System.Windows.Forms.TextBox();
            this.textBoxToDate = new System.Windows.Forms.TextBox();
            this.textBoxReturnBook = new System.Windows.Forms.TextBox();
            this.btnViewBorrowedBooks = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxViewBooksBorrowed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "From Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(184, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "To Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(46, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "scan RFID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(184, 199);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 15);
            label4.TabIndex = 12;
            label4.Text = "BookId";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(562, 12);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 25;
            this.dgvBooks.Size = new System.Drawing.Size(877, 361);
            this.dgvBooks.TabIndex = 0;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(562, 395);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowTemplate.Height = 25;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(877, 361);
            this.dgvBorrowedBooks.TabIndex = 1;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(58, 288);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // brnReturn
            // 
            this.brnReturn.Location = new System.Drawing.Point(154, 45);
            this.brnReturn.Name = "brnReturn";
            this.brnReturn.Size = new System.Drawing.Size(75, 23);
            this.brnReturn.TabIndex = 3;
            this.brnReturn.Text = "Return";
            this.brnReturn.UseVisualStyleBackColor = true;
            this.brnReturn.Click += new System.EventHandler(this.brnReturn_Click);
            // 
            // textBoxRfidTag
            // 
            this.textBoxRfidTag.Location = new System.Drawing.Point(33, 228);
            this.textBoxRfidTag.Name = "textBoxRfidTag";
            this.textBoxRfidTag.Size = new System.Drawing.Size(100, 23);
            this.textBoxRfidTag.TabIndex = 4;
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Location = new System.Drawing.Point(168, 228);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(100, 23);
            this.textBoxBookId.TabIndex = 5;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(33, 22);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(165, 23);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // textBoxFromDate
            // 
            this.textBoxFromDate.Location = new System.Drawing.Point(33, 117);
            this.textBoxFromDate.Name = "textBoxFromDate";
            this.textBoxFromDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxFromDate.TabIndex = 7;
            // 
            // textBoxToDate
            // 
            this.textBoxToDate.Location = new System.Drawing.Point(168, 117);
            this.textBoxToDate.Name = "textBoxToDate";
            this.textBoxToDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxToDate.TabIndex = 8;
            // 
            // textBoxReturnBook
            // 
            this.textBoxReturnBook.Location = new System.Drawing.Point(28, 45);
            this.textBoxReturnBook.Name = "textBoxReturnBook";
            this.textBoxReturnBook.Size = new System.Drawing.Size(100, 23);
            this.textBoxReturnBook.TabIndex = 13;
            // 
            // btnViewBorrowedBooks
            // 
            this.btnViewBorrowedBooks.Location = new System.Drawing.Point(156, 45);
            this.btnViewBorrowedBooks.Name = "btnViewBorrowedBooks";
            this.btnViewBorrowedBooks.Size = new System.Drawing.Size(168, 23);
            this.btnViewBorrowedBooks.TabIndex = 14;
            this.btnViewBorrowedBooks.Text = "View Books Borrowed";
            this.btnViewBorrowedBooks.UseVisualStyleBackColor = true;
            this.btnViewBorrowedBooks.Click += new System.EventHandler(this.btnViewBorrowedBooks_Click);
            // 
            // textBoxViewBooksBorrowed
            // 
            this.textBoxViewBooksBorrowed.Location = new System.Drawing.Point(30, 46);
            this.textBoxViewBooksBorrowed.Name = "textBoxViewBooksBorrowed";
            this.textBoxViewBooksBorrowed.Size = new System.Drawing.Size(100, 23);
            this.textBoxViewBooksBorrowed.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxViewBooksBorrowed);
            this.groupBox1.Controls.Add(this.btnViewBorrowedBooks);
            this.groupBox1.Location = new System.Drawing.Point(28, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter RFID to view borrowwed books";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReturnBook);
            this.groupBox2.Controls.Add(this.brnReturn);
            this.groupBox2.Location = new System.Drawing.Point(30, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter BookId to return book";
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 829);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxToDate);
            this.Controls.Add(this.textBoxFromDate);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.textBoxRfidTag);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.dgvBooks);
            this.Name = "BorrowBook";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBooks;
        private DataGridView dgvBorrowedBooks;
        private Button btnBorrow;
        private Button brnReturn;
        private TextBox textBoxRfidTag;
        private TextBox textBoxBookId;
        private Button btnBackToMenu;
        private DateTimePicker dateTimePickerFromDate;
        private DateTimePicker dateTimePickerToDate;
        private TextBox textBoxFromDate;
        private TextBox textBoxToDate;
        private TextBox textBoxReturnBook;
        private Button btnViewBorrowedBooks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxViewBooksBorrowed;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}