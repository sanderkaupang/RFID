namespace RFID
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
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.txtBoxPin = new System.Windows.Forms.TextBox();
            this.txtBoxTag = new System.Windows.Forms.TextBox();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.groupBoxRegistrate = new System.Windows.Forms.GroupBox();
            this.groupBoxLogIn.SuspendLayout();
            this.groupBoxRegistrate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.Controls.Add(this.btnLogIn);
            this.groupBoxLogIn.Controls.Add(this.labelPin);
            this.groupBoxLogIn.Controls.Add(this.labelTag);
            this.groupBoxLogIn.Controls.Add(this.txtBoxPin);
            this.groupBoxLogIn.Controls.Add(this.txtBoxTag);
            this.groupBoxLogIn.Location = new System.Drawing.Point(28, 29);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(344, 358);
            this.groupBoxLogIn.TabIndex = 0;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "Log in";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(213, 128);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(94, 151);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.Location = new System.Drawing.Point(14, 217);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(29, 20);
            this.labelPin.TabIndex = 3;
            this.labelPin.Text = "Pin";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(14, 94);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(32, 20);
            this.labelTag.TabIndex = 2;
            this.labelTag.Text = "Tag";
            // 
            // txtBoxPin
            // 
            this.txtBoxPin.Location = new System.Drawing.Point(14, 252);
            this.txtBoxPin.Name = "txtBoxPin";
            this.txtBoxPin.PasswordChar = '*';
            this.txtBoxPin.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPin.TabIndex = 1;
            // 
            // txtBoxTag
            // 
            this.txtBoxTag.Location = new System.Drawing.Point(14, 128);
            this.txtBoxTag.Name = "txtBoxTag";
            this.txtBoxTag.Size = new System.Drawing.Size(125, 27);
            this.txtBoxTag.TabIndex = 0;
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Location = new System.Drawing.Point(76, 131);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(94, 145);
            this.btnRegistrate.TabIndex = 1;
            this.btnRegistrate.Text = "Registrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // groupBoxRegistrate
            // 
            this.groupBoxRegistrate.Controls.Add(this.btnRegistrate);
            this.groupBoxRegistrate.Location = new System.Drawing.Point(390, 29);
            this.groupBoxRegistrate.Name = "groupBoxRegistrate";
            this.groupBoxRegistrate.Size = new System.Drawing.Size(255, 358);
            this.groupBoxRegistrate.TabIndex = 2;
            this.groupBoxRegistrate.TabStop = false;
            this.groupBoxRegistrate.Text = "Registrate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRegistrate);
            this.Controls.Add(this.groupBoxLogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.groupBoxRegistrate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxLogIn;
        private Button btnLogIn;
        private Label labelPin;
        private Label labelTag;
        private TextBox txtBoxPin;
        private TextBox txtBoxTag;
        private Button btnRegistrate;
        private GroupBox groupBoxRegistrate;
    }
}