using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnOutlookPlugin
{
    public partial class OwnFolder : Form
    {
        public OwnFolder()
        {
            InitializeComponent();
        }

        private void wskazFolderbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = false;
            System.Windows.Forms.DialogResult dlgResult = folderBrowserDialog1.ShowDialog();



            if ((dlgResult == System.Windows.Forms.DialogResult.OK))
            {
                //Show selected folder path in textbox1.

                ownFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void zapiszFolder_Click(object sender, EventArgs e)
        {
            if (saveConfigFolder() == 0)
            {

                MessageBox.Show("Zapisano folder!", "Folder zapisany", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
            }
        }

        private int saveConfigFolder()
        {
            if (string.IsNullOrWhiteSpace(ownFolder.Text))
            {
                MessageBox.Show("Proszę wskazać folder!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection app = config.AppSettings;
                app.Settings.Remove("own_folder");
                config.Save(ConfigurationSaveMode.Modified);
                app.Settings.Add("own_folder", ownFolder.Text);
                config.Save(ConfigurationSaveMode.Modified);
                return 0;
            }

            return -1;

        }
    
    }
}
