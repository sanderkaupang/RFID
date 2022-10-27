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
            this.dgvBookToBorrow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookToBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookToBorrow
            // 
            this.dgvBookToBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookToBorrow.Location = new System.Drawing.Point(562, 12);
            this.dgvBookToBorrow.Name = "dgvBookToBorrow";
            this.dgvBookToBorrow.RowTemplate.Height = 25;
            this.dgvBookToBorrow.Size = new System.Drawing.Size(911, 375);
            this.dgvBookToBorrow.TabIndex = 0;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 829);
            this.Controls.Add(this.dgvBookToBorrow);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookToBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvBookToBorrow;
    }
}