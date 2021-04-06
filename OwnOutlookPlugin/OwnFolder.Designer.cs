namespace OwnOutlookPlugin
{
    partial class OwnFolder
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
            this.zapiszFolder = new System.Windows.Forms.Button();
            this.wskazFolderbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ownFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zapiszFolder
            // 
            this.zapiszFolder.Location = new System.Drawing.Point(410, 324);
            this.zapiszFolder.Name = "zapiszFolder";
            this.zapiszFolder.Size = new System.Drawing.Size(75, 23);
            this.zapiszFolder.TabIndex = 7;
            this.zapiszFolder.Text = "Zapisz";
            this.zapiszFolder.UseVisualStyleBackColor = true;
            this.zapiszFolder.Click += new System.EventHandler(this.zapiszFolder_Click);
            // 
            // wskazFolderbtn
            // 
            this.wskazFolderbtn.Location = new System.Drawing.Point(410, 104);
            this.wskazFolderbtn.Name = "wskazFolderbtn";
            this.wskazFolderbtn.Size = new System.Drawing.Size(75, 23);
            this.wskazFolderbtn.TabIndex = 6;
            this.wskazFolderbtn.Text = "Folder";
            this.wskazFolderbtn.UseVisualStyleBackColor = true;
            this.wskazFolderbtn.Click += new System.EventHandler(this.wskazFolderbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder ownCloud";
            // 
            // ownFolder
            // 
            this.ownFolder.Enabled = false;
            this.ownFolder.Location = new System.Drawing.Point(171, 104);
            this.ownFolder.Name = "ownFolder";
            this.ownFolder.Size = new System.Drawing.Size(215, 20);
            this.ownFolder.TabIndex = 4;
            // 
            // WskazFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.zapiszFolder);
            this.Controls.Add(this.wskazFolderbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownFolder);
            this.Name = "WskazFolder";
            this.ShowIcon = false;
            this.Text = "Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zapiszFolder;
        private System.Windows.Forms.Button wskazFolderbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ownFolder;
    }
}