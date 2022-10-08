namespace DataLoggin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLogIn = new System.Windows.Forms.TextBox();
            this.LogInLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLogIn
            // 
            this.txtLogIn.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLogIn.Location = new System.Drawing.Point(38, 75);
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.Size = new System.Drawing.Size(446, 27);
            this.txtLogIn.TabIndex = 0;
            // 
            // LogInLable
            // 
            this.LogInLable.AutoSize = true;
            this.LogInLable.Location = new System.Drawing.Point(41, 38);
            this.LogInLable.Name = "LogInLable";
            this.LogInLable.Size = new System.Drawing.Size(53, 20);
            this.LogInLable.TabIndex = 1;
            this.LogInLable.Text = "Log in:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(38, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 27);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogInLable);
            this.Controls.Add(this.txtLogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLogIn;
        private Label LogInLable;
        private TextBox textBox1;
    }
}