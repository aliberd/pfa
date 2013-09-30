using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Securitool
{
    public partial class Form1 : Form
    {
        string[] user_agents_value = new string[28] {"Mozilla/2.0 (compatible; Ask Jeeves/Teoma)",
                                                     "ELinks (0.4pre5; Linux 2.4.27 i686; 80x25)",
                                                     "Googlebot/2.1 (+http://www.google.com/bot.html)",
                                                     "Mozilla/4.0 (compatible; MSIE 5.23; Mac_PowerPC)",
                                                     "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)",
                                                     "Mozilla/4.0 (compatible; MSIE 7.0b; Windows NT 6.0)",
                                                     "Mozilla/5.0 (compatible; Konqueror/3.1; Linux 2.4.2210mdk; X11; i686; fr, fr_FR)",
                                                     "Mozilla/5.0 (compatible; Konqueror/3.1; Linux 2.4.2210mdk; X11; i686; en, en_EN)",
                                                     "Links (0.99pre14; CYGWIN_NT5.0 1.5.16(0.128/4/2) i686; 80x25)",
                                                     "Links (2.1pre17; Linux 2.6.11gentoor8 i686; 80x24)",
                                                     "Lynx/2.8.4rel.1 libwwwFM/2.14",
                                                     "Firefox/3.5.11",
                                                     "Mozilla/5.0 (X11; U; Linux i686; enUS; rv:1.7.8) Gecko/20050511",
                                                     "Mozilla/5.0 (X11; U; FreeBSD i386; enUS; rv:1.7.8) Gecko/20050609 Firefox/1.0.4",
                                                     "Mozilla/5.0 (X11; U; Linux x86_64; enUS; rv:1.7.6) Gecko/20050512 Firefox",
                                                     "Mozilla/5.0 (Windows; U; Windows NT 5.1; enUS; rv:1.7.8) Gecko/20050511 Firefox/1.0.4",
                                                     "Mozilla/4.8 [en] (Windows NT 5.0; U)",
                                                     "Mozilla/5.0 (X11; U; SunOS sun4u; enUS; rv:1.0.1) Gecko/20020920 Netscape/7.0",
                                                     "Mozilla/5.0 (Windows; U; Windows NT 5.1; enUS; rv:1.7.5) Gecko/20050519",
                                                     "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1",
                                                     "Mozilla/4.7 (compatible; OffByOne; Windows 2000)",
                                                     "Mozilla/4.0 (compatible; MSIE 5.0; Windows 2000) Opera 6.03 [en]",
                                                     "Opera/7.23 (Windows 98; U) [en]",
                                                     "Opera/8.0 (X11; Linux i686; U; cs)",
                                                     "Opera/8.00 (Windows NT 5.1; U; en)",
                                                     "Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/124 (KHTML, like Gecko) Safari/125",
                                                     "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2)",
                                                     "w3m on FreeBSD | w3m/0.5.1"};

        public Form1()
        {
            InitializeComponent();
        }

        // At the loading of the window :
        private void Form1_Load(object sender, EventArgs e)
        {
            // Show the disclaimer :
            /*
            if (MessageBox.Show("Securitool is a public web vulnerabilities scanner, for educative usage only.\nYou are the only one responsable in case of troubles.", "DISCLAIMER", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
            */

            // Sets the default text to all the ComboBox widgets :
            // Settings SQLi :
            comboBoxEndRequestSQLi.SelectedIndex        = 0;
            comboBoxFollowRedirectSQLi.SelectedIndex    = 0;
            comboBoxSpaceSQLi.SelectedIndex             = 0;
            comboBoxUserAgentName.SelectedIndex         = 15;
            // SQLi :
            comboBoxDatabase.SelectedIndex              = 0;
            comboBoxTypeRequestSQLi.SelectedIndex       = 0;
            comboBoxTypeInjection.SelectedIndex         = 0;
            // XSS :
            comboBoxTypeRequestXSS.SelectedIndex        = 0;
        }

        // "Activate the 3xp3r7 m0d3" Checkbox Click event :
        private void checkBoxExpertMode_Click(object sender, EventArgs e)
        {
            if (checkBoxExpertMode.Checked == true)
            {
                if (MessageBox.Show("Active the expert mode ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    groupBoxSettingsSQLi.Enabled    = true;
                    groupBoxSettingsXSS.Enabled     = true;
                    groupBoxSettingsRFLI.Enabled    = true;
                    groupBoxSettingsCSRF.Enabled    = true;
                }
                else
                {
                    checkBoxExpertMode.Checked      = false;
                }
            }
            else
            {
                groupBoxSettingsSQLi.Enabled        = false;
                groupBoxSettingsXSS.Enabled         = false;
                groupBoxSettingsRFLI.Enabled        = false;
                groupBoxSettingsCSRF.Enabled        = false;
            }
        }
         
        // "START SCAN" button click event from the SQLi scanner :
        private void buttonStartScanSQLi_Click(object sender, EventArgs e)
        {
            treeViewResultsSQLi.Nodes.Add(richTextBoxUrlTargetSQLi.Text.ToString());
            progressBar1.Enabled        = true;
            buttonStartScanSQLi.Enabled = false;
            buttonPauseScanSQLi.Enabled = true;
            buttonAbortScanSQLi.Enabled = true;

            int i = 0;

            // Parcours toutes les lignes du richeText "targets"
            while (i <= (richTextBoxUrlTargetSQLi.Lines.Count() - 1))
            {
                // Instance de la requete HTTP :
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(richTextBoxUrlTargetSQLi.Lines[i]);
                // Recuperation du type de methode (GET/POST) depuis le comboBox :
                myRequest.Method = comboBoxTypeRequestSQLi.Text;
                // Instance de la reponse a la requete :
                WebResponse myResponse = myRequest.GetResponse();
                // Instance du stream en UTF-8 (Code source de la page) :
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                // Recuperation du stream dans une string :
                string result = sr.ReadToEnd();
                // Ajout de l'URL target dans le treeView :
                treeViewResultsSQLi.Nodes.Add(richTextBoxUrlTargetSQLi.Lines[i]);
                // Ajout du stream dans le treeView :
                treeViewResultsSQLi.Nodes.Add(result.ToString());
                // On close le stream :
                sr.Close();
                // On close la "reponse" :
                myResponse.Close();
                // On passe a la ligne (target) suivante ...
                ++i;
            }
        }

        private void buttonPauseScanSQLi_Click(object sender, EventArgs e)
        {
            if (buttonPauseScanSQLi.Text.ToString() == "PAUSE THIS SCAN")
            {
                buttonPauseScanSQLi.Text = "RESUME THIS SCAN";
            }
            else if (buttonPauseScanSQLi.Text.ToString() == "RESUME THIS SCAN")
            {
                buttonPauseScanSQLi.Text = "PAUSE THIS SCAN";
            }
        }

        private void buttonAbortScanSQLi_Click(object sender, EventArgs e)
        {
            buttonStartScanSQLi.Enabled = true;
            buttonPauseScanSQLi.Enabled = false;
            buttonPauseScanSQLi.Text    = "PAUSE THIS SCAN";
            buttonAbortScanSQLi.Enabled = false;
        }

        private void comboBoxUserAgentName_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBoxUserAgentValue.Text = user_agents_value[Convert.ToInt32(comboBoxUserAgentName.SelectedIndex)];
        }

        private void comboBoxTypeRequestXSS_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBoxTypeRequestXSS.SelectedValue) == "POST")
            {
                label12.Enabled = true;
            }
            else if (Convert.ToString(comboBoxTypeRequestXSS.SelectedValue) == "GET")
            {
                label12.Enabled = false;
            }
        }
    }
}
