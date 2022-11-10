namespace WindowsFormsApp1
{
    partial class LoggingApp
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
            this.btnShowValues = new System.Windows.Forms.Button();
            this.dgvAllValues = new System.Windows.Forms.DataGridView();
            this.btnReadToFile = new System.Windows.Forms.Button();
            this.btnViewTags = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowValues
            // 
            this.btnShowValues.Location = new System.Drawing.Point(47, 102);
            this.btnShowValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowValues.Name = "btnShowValues";
            this.btnShowValues.Size = new System.Drawing.Size(175, 46);
            this.btnShowValues.TabIndex = 0;
            this.btnShowValues.Text = "Show  Persons Registrated";
            this.btnShowValues.UseVisualStyleBackColor = true;
            this.btnShowValues.Click += new System.EventHandler(this.btnShowValues_Click);
            // 
            // dgvAllValues
            // 
            this.dgvAllValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllValues.Location = new System.Drawing.Point(269, 76);
            this.dgvAllValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllValues.Name = "dgvAllValues";
            this.dgvAllValues.RowHeadersWidth = 51;
            this.dgvAllValues.RowTemplate.Height = 24;
            this.dgvAllValues.Size = new System.Drawing.Size(1231, 487);
            this.dgvAllValues.TabIndex = 1;
            this.dgvAllValues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllValues_CellContentClick);
            // 
            // btnReadToFile
            // 
            this.btnReadToFile.Location = new System.Drawing.Point(1363, 614);
            this.btnReadToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadToFile.Name = "btnReadToFile";
            this.btnReadToFile.Size = new System.Drawing.Size(111, 36);
            this.btnReadToFile.TabIndex = 2;
            this.btnReadToFile.Text = "Read To File";
            this.btnReadToFile.UseVisualStyleBackColor = true;
            this.btnReadToFile.Click += new System.EventHandler(this.btnReadToFile_Click);
            // 
            // btnViewTags
            // 
            this.btnViewTags.Location = new System.Drawing.Point(47, 183);
            this.btnViewTags.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewTags.Name = "btnViewTags";
            this.btnViewTags.Size = new System.Drawing.Size(175, 42);
            this.btnViewTags.TabIndex = 3;
            this.btnViewTags.Text = "Show All Tags";
            this.btnViewTags.UseVisualStyleBackColor = true;
            this.btnViewTags.Click += new System.EventHandler(this.btnViewTags_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(47, 257);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(175, 44);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "Show All Boks";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // LoggingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 848);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnViewTags);
            this.Controls.Add(this.btnReadToFile);
            this.Controls.Add(this.dgvAllValues);
            this.Controls.Add(this.btnShowValues);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoggingApp";
            this.Text = "LoggingApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowValues;
        private System.Windows.Forms.DataGridView dgvAllValues;
        private System.Windows.Forms.Button btnReadToFile;
        private System.Windows.Forms.Button btnViewTags;
        private System.Windows.Forms.Button btnBooks;
    }
}

