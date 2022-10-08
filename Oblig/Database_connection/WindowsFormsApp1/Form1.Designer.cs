namespace WindowsFormsApp1
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowValues
            // 
            this.btnShowValues.Location = new System.Drawing.Point(12, 12);
            this.btnShowValues.Name = "btnShowValues";
            this.btnShowValues.Size = new System.Drawing.Size(75, 45);
            this.btnShowValues.TabIndex = 0;
            this.btnShowValues.Text = "Show Tags";
            this.btnShowValues.UseVisualStyleBackColor = true;
            this.btnShowValues.Click += new System.EventHandler(this.btnShowValues_Click);
            // 
            // dgvAllValues
            // 
            this.dgvAllValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllValues.Location = new System.Drawing.Point(270, 76);
            this.dgvAllValues.Name = "dgvAllValues";
            this.dgvAllValues.RowHeadersWidth = 51;
            this.dgvAllValues.RowTemplate.Height = 24;
            this.dgvAllValues.Size = new System.Drawing.Size(518, 284);
            this.dgvAllValues.TabIndex = 1;
            this.dgvAllValues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllValues_CellContentClick);
            // 
            // btnReadToFile
            // 
            this.btnReadToFile.Location = new System.Drawing.Point(12, 402);
            this.btnReadToFile.Name = "btnReadToFile";
            this.btnReadToFile.Size = new System.Drawing.Size(111, 36);
            this.btnReadToFile.TabIndex = 2;
            this.btnReadToFile.Text = "Read To File";
            this.btnReadToFile.UseVisualStyleBackColor = true;
            this.btnReadToFile.Click += new System.EventHandler(this.btnReadToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadToFile);
            this.Controls.Add(this.dgvAllValues);
            this.Controls.Add(this.btnShowValues);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowValues;
        private System.Windows.Forms.DataGridView dgvAllValues;
        private System.Windows.Forms.Button btnReadToFile;
    }
}

