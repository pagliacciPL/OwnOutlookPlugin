using CredentialManagement;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OwnOutlookPlugin
{
    public partial class Generator : Form
    {
        string path;
        public Generator(string value)
        {
            InitializeComponent();
            path = value;
        }


        private void usePass_CheckedChanged(object sender, EventArgs e)
        {
            if (usePass.Checked == true)
            {

                sharePass.Enabled = true;
                genPass.Enabled = true;
                sameEmail.Enabled = true;
                anotherEmail.Enabled = true;



            }

            if (usePass.Checked == false)
            {

                sharePass.Enabled = false;
                genPass.Enabled = false;
                sameEmail.Enabled = false;
                anotherEmail.Enabled = false;
            }
        }

        private void genPass_Click(object sender, EventArgs e)
        {
            string pass = (Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 15));
            sharePass.Text = pass;
        }

        private void genLink_Click(object sender, EventArgs e)
        {
            try
            {
                var cred = new Credential();
                cred.Target = ConfigurationManager.AppSettings.Get("server_address");
                if (usePass.Checked == true && string.IsNullOrWhiteSpace(sharePass.Text))
                {
                    MessageBox.Show("Proszę podać hasło!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (usePass.Checked == true && !string.IsNullOrWhiteSpace(sharePass.Text) && sameEmail.Checked == true)
                {

                    ComposeMail(CreateLink(), sharePass.Text);
                    this.Close();
                }


                if (usePass.Checked == true && !string.IsNullOrWhiteSpace(sharePass.Text) && anotherEmail.Checked == true)
                {
                    string url = CreateLink();
                    ComposeMail(url, path);
                    ComposeMailAnotherPassword(path, sharePass.Text);

                    this.Close();
                }



                if (notUsePass.Checked == true)
                {

                    ComposeMail(CreateLink(), path);

                    this.Close();

                }

            }

            catch (System.Exception m)
            {
                MessageBox.Show("Wystąpił problem: " + m.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void ComposeMail(string url, string path)
            {

                Microsoft.Office.Interop.Outlook.Application mail = new Microsoft.Office.Interop.Outlook.Application();
                MailItem mail_tresc = mail.CreateItem((OlItemType.olMailItem));
                mail_tresc.BodyFormat = OlBodyFormat.olFormatHTML;
                mail_tresc.Body = "Witam,\nzostał wygenerowany link do pliku/folderu " + path + "\n\nLink: " + url;
                mail_tresc.Display();

            }


            private void ComposeMail(string url, string path, string password)
            {

                Microsoft.Office.Interop.Outlook.Application mail = new Microsoft.Office.Interop.Outlook.Application();
                MailItem mail_tresc = mail.CreateItem((OlItemType.olMailItem));
                mail_tresc.BodyFormat = OlBodyFormat.olFormatHTML;
                mail_tresc.Body = "Witam,\nzostał wygenerowany link do pliku/folderu " + path + "\n\nLink: " + url + "\n\n Hasło: " + password;
                mail_tresc.Display();

            }


            private void ComposeMailAnotherPassword(string path, string password)
            {

                Microsoft.Office.Interop.Outlook.Application mail = new Microsoft.Office.Interop.Outlook.Application();
                MailItem mail_tresc = mail.CreateItem((OlItemType.olMailItem));
                mail_tresc.BodyFormat = OlBodyFormat.olFormatHTML;
                mail_tresc.Body = "Witam,\nw osobnym mailu zostal wysłany link do pliku/folderu " + path + "\n\n W tym mailu zostanie przekazane hasło.\n\n Hasło: " + password;
                mail_tresc.Display();

            }
            private string CreateLink()
            {
                string postData;

                try
                {
                    var cred = new Credential();
                    cred.Target = ConfigurationManager.AppSettings.Get("server_address");
                    cred.Load();

                    string username = cred.Username;
                    string password = cred.Password;


                    string server_prefix = cred.Target;
                    string server_suffix = "/owncloud/ocs/v1.php/apps/files_sharing/api/v1/shares";
                    string server = String.Concat(server_prefix, server_suffix);
                    string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
                    WebRequest request = WebRequest.Create(server);
                    request.Method = "POST";
                    request.Headers.Add("Authorization", "Basic " + svcCredentials);



                    if (usePass.Checked == true)
                    {

                        postData = "path=/" + path + "&shareType=3&permissions=1&password=" + sharePass.Text;
                    }

                    else
                    {

                        postData = "path=/" + path + "&shareType=3&permissions=1";
                    }


                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    request.ContentType = "application/x-www-form-urlencoded";

                    request.ContentLength = byteArray.Length;


                    Stream dataStream = request.GetRequestStream();

                    dataStream.Write(byteArray, 0, byteArray.Length);

                    dataStream.Close();

                    WebResponse response = request.GetResponse();


                    dataStream = response.GetResponseStream();

                    // Open the stream using a StreamReader for easy access.  
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.  
                    string responseFromServer = reader.ReadToEnd();
                    var yourXml = XElement.Parse(responseFromServer);
                    var url = yourXml.Descendants().First(node => node.Name == "url").Value;




                    // Close the response.  
                    response.Close();

                    return url;
                }
                catch (System.Exception m)
                {
                    MessageBox.Show("Wystąpił problem: " + m.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return "blad";
            }
        }
    }

