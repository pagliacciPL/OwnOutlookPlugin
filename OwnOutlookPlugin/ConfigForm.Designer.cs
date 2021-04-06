namespace OwnOutlookPlugin
{
    partial class ConfigForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.server_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Test połączenia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasło :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Użytkownik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adres serwera :";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(110, 135);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(190, 20);
            this.password_box.TabIndex = 9;
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(110, 86);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(190, 20);
            this.user_box.TabIndex = 8;
            // 
            // server_box
            // 
            this.server_box.Location = new System.Drawing.Point(110, 27);
            this.server_box.Name = "server_box";
            this.server_box.Size = new System.Drawing.Size(190, 20);
            this.server_box.TabIndex = 7;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.server_box);
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.Text = "Konfiguracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox server_box;
    }
}