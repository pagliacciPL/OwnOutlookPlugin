using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CredentialManagement;

namespace OwnOutlookPlugin
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_conn();
            if (Check_conn() == 0)
            {
                saveCreds();
                saveConfig();

                MessageBox.Show("Połączenie OK!", "Połączenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OwnFolder forma = new OwnFolder();
                forma.Show();

                this.Hide();

            }
        }

        private int Check_conn()
        {
            string server_prefix = server_box.Text;
            string username = user_box.Text;
            string password = password_box.Text;
            string server_suffix = "/owncloud/ocs/v1.php/apps/files_sharing/api/v1/shares";
            string server = String.Concat(server_prefix, server_suffix);


            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            WebRequest request = WebRequest.Create(server);
            request.Method = "GET";
            request.Headers.Add("Authorization", "Basic " + svcCredentials);
            WebResponse response = request.GetResponse();
            response.Close();

            try
            {


                if (((HttpWebResponse)response).StatusDescription == "OK")
                {

                    return 0;
                }

                else
                {

                    return -1;
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Wystąpił problem: " + e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            return 1;
        }

        private int saveCreds()
        {

            string PasswordName = server_box.Text;
            var cred = new Credential();
            cred.Username = user_box.Text;
            cred.Password = password_box.Text;
            cred.Target = PasswordName;
            cred.Type = CredentialType.Generic;
            cred.PersistanceType = PersistanceType.LocalComputer;
            cred.Save();

            return 0;
        }

        private int saveConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings.Remove("server_address");
            config.Save(ConfigurationSaveMode.Modified);
            app.Settings.Add("server_address", server_box.Text);
            config.Save(ConfigurationSaveMode.Modified);
            return 0;
        }

        
    }
}
