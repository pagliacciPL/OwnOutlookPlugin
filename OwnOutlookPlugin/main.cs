using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace OwnOutlookPlugin
{
    public partial class main
    {
        private void main_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void config_Click(object sender, RibbonControlEventArgs e)
        {
            ConfigForm forma = new ConfigForm();
            forma.Show();
        }

        private void dziel_plik_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            string path;
            try
            {
                path = ConfigurationManager.AppSettings.Get("own_folder");


                ofd.InitialDirectory = path;

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (ofd.FileName.Contains(path))
                    {


                        path = path + "\\";

                        Generator forma = new Generator(ofd.FileName.Replace(path, ""));
                        forma.Show();


                    }

                    else
                    {
                        MessageBox.Show("Proszę wskazać plik/folder z lokalizacji ownClouda! (" + path + ")", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }

            catch (Exception m)
            {
                MessageBox.Show("Wystąpił problem: " + m.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dziel_folder_Click(object sender, RibbonControlEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();


            string path;

            try
            {
                path = ConfigurationManager.AppSettings.Get("own_folder");
                folderBrowserDialog1.ShowNewFolderButton = false;
                folderBrowserDialog1.SelectedPath = path;


                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (folderBrowserDialog1.SelectedPath.Contains(path))
                    {

                        Generator forma = new Generator(folderBrowserDialog1.SelectedPath.Replace(path, ""));
                        forma.Show();

                    }
                    else
                    {
                        MessageBox.Show("Proszę wskazać plik/folder z lokalizacji ownClouda! (" + path + ")", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }



            }
            catch (Exception m)
            {
                MessageBox.Show("Wystąpił problem: " + m.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void about_Click(object sender, RibbonControlEventArgs e)
        {
            about forma = new about();
            forma.Show();
        }
    }
}
