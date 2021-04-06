namespace OwnOutlookPlugin
{
    partial class Generator
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
            this.genLink = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sameEmail = new System.Windows.Forms.RadioButton();
            this.anotherEmail = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notUsePass = new System.Windows.Forms.RadioButton();
            this.usePass = new System.Windows.Forms.RadioButton();
            this.sharePass = new System.Windows.Forms.TextBox();
            this.genPass = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genLink
            // 
            this.genLink.Location = new System.Drawing.Point(304, 347);
            this.genLink.Name = "genLink";
            this.genLink.Size = new System.Drawing.Size(75, 23);
            this.genLink.TabIndex = 15;
            this.genLink.Text = "Generuj link";
            this.genLink.UseVisualStyleBackColor = true;
            this.genLink.Click += new System.EventHandler(this.genLink_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sameEmail);
            this.panel2.Controls.Add(this.anotherEmail);
            this.panel2.Location = new System.Drawing.Point(30, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 68);
            this.panel2.TabIndex = 14;
            // 
            // sameEmail
            // 
            this.sameEmail.AutoSize = true;
            this.sameEmail.Enabled = false;
            this.sameEmail.Location = new System.Drawing.Point(3, 38);
            this.sameEmail.Name = "sameEmail";
            this.sameEmail.Size = new System.Drawing.Size(144, 17);
            this.sameEmail.TabIndex = 3;
            this.sameEmail.Text = "Wyślij w tym samym meilu";
            this.sameEmail.UseVisualStyleBackColor = true;
            // 
            // anotherEmail
            // 
            this.anotherEmail.AutoSize = true;
            this.anotherEmail.Checked = true;
            this.anotherEmail.Enabled = false;
            this.anotherEmail.Location = new System.Drawing.Point(3, 3);
            this.anotherEmail.Name = "anotherEmail";
            this.anotherEmail.Size = new System.Drawing.Size(135, 17);
            this.anotherEmail.TabIndex = 4;
            this.anotherEmail.TabStop = true;
            this.anotherEmail.Text = "Wyślij w osobnym meilu";
            this.anotherEmail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.notUsePass);
            this.panel1.Controls.Add(this.usePass);
            this.panel1.Controls.Add(this.sharePass);
            this.panel1.Controls.Add(this.genPass);
            this.panel1.Location = new System.Drawing.Point(27, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 124);
            this.panel1.TabIndex = 13;
            // 
            // notUsePass
            // 
            this.notUsePass.AutoSize = true;
            this.notUsePass.Checked = true;
            this.notUsePass.Location = new System.Drawing.Point(3, 3);
            this.notUsePass.Name = "notUsePass";
            this.notUsePass.Size = new System.Drawing.Size(172, 17);
            this.notUsePass.TabIndex = 8;
            this.notUsePass.TabStop = true;
            this.notUsePass.Text = "Nie używaj hasła (niezalecane)";
            this.notUsePass.UseVisualStyleBackColor = true;
            // 
            // usePass
            // 
            this.usePass.AutoSize = true;
            this.usePass.Location = new System.Drawing.Point(3, 47);
            this.usePass.Name = "usePass";
            this.usePass.Size = new System.Drawing.Size(75, 17);
            this.usePass.TabIndex = 0;
            this.usePass.Text = "Użyj hasła";
            this.usePass.UseVisualStyleBackColor = true;
            this.usePass.CheckedChanged += new System.EventHandler(this.usePass_CheckedChanged);
            // 
            // sharePass
            // 
            this.sharePass.Enabled = false;
            this.sharePass.Location = new System.Drawing.Point(3, 93);
            this.sharePass.Name = "sharePass";
            this.sharePass.Size = new System.Drawing.Size(135, 20);
            this.sharePass.TabIndex = 1;
            // 
            // genPass
            // 
            this.genPass.Enabled = false;
            this.genPass.Location = new System.Drawing.Point(201, 91);
            this.genPass.Name = "genPass";
            this.genPass.Size = new System.Drawing.Size(122, 23);
            this.genPass.TabIndex = 2;
            this.genPass.Text = "Generuj hasło";
            this.genPass.UseVisualStyleBackColor = true;
            this.genPass.Click += new System.EventHandler(this.genPass_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.genLink);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Generator";
            this.ShowIcon = false;
            this.Text = "Generator";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton sameEmail;
        private System.Windows.Forms.RadioButton anotherEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton notUsePass;
        private System.Windows.Forms.RadioButton usePass;
        private System.Windows.Forms.TextBox sharePass;
        private System.Windows.Forms.Button genPass;
    }
}