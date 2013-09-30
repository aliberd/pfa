namespace Securitool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxExpertMode = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeViewResultsSQLi = new System.Windows.Forms.TreeView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBoxUrlTargetSQLi = new System.Windows.Forms.RichTextBox();
            this.buttonAbortScanSQLi = new System.Windows.Forms.Button();
            this.buttonPauseScanSQLi = new System.Windows.Forms.Button();
            this.buttonStartScanSQLi = new System.Windows.Forms.Button();
            this.comboBoxTypeInjection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTypeRequestSQLi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxTypeRequestXSS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxUrlTargetXSS = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBoxSettingsCSRF = new System.Windows.Forms.GroupBox();
            this.groupBoxSettingsRFLI = new System.Windows.Forms.GroupBox();
            this.groupBoxSettingsXSS = new System.Windows.Forms.GroupBox();
            this.groupBoxSettingsSQLi = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDefaultSettingsSQLi = new System.Windows.Forms.Button();
            this.buttonApplySettingsSQLi = new System.Windows.Forms.Button();
            this.richTextBoxUserAgentValue = new System.Windows.Forms.RichTextBox();
            this.comboBoxUserAgentName = new System.Windows.Forms.ComboBox();
            this.comboBoxSpaceSQLi = new System.Windows.Forms.ComboBox();
            this.comboBoxFollowRedirectSQLi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEndRequestSQLi = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBoxSettingsSQLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxExpertMode
            // 
            this.checkBoxExpertMode.AutoSize = true;
            this.checkBoxExpertMode.Location = new System.Drawing.Point(7, 7);
            this.checkBoxExpertMode.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExpertMode.Name = "checkBoxExpertMode";
            this.checkBoxExpertMode.Size = new System.Drawing.Size(190, 21);
            this.checkBoxExpertMode.TabIndex = 0;
            this.checkBoxExpertMode.Text = "Activate the 3xp3r7 m0d3";
            this.checkBoxExpertMode.UseVisualStyleBackColor = true;
            this.checkBoxExpertMode.Click += new System.EventHandler(this.checkBoxExpertMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 854);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(5, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 869);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeViewResultsSQLi);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.richTextBoxUrlTargetSQLi);
            this.tabPage1.Controls.Add(this.buttonAbortScanSQLi);
            this.tabPage1.Controls.Add(this.buttonPauseScanSQLi);
            this.tabPage1.Controls.Add(this.buttonStartScanSQLi);
            this.tabPage1.Controls.Add(this.comboBoxTypeInjection);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBoxTypeRequestSQLi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBoxDatabase);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(975, 840);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQLi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeViewResultsSQLi
            // 
            this.treeViewResultsSQLi.Location = new System.Drawing.Point(36, 274);
            this.treeViewResultsSQLi.Name = "treeViewResultsSQLi";
            this.treeViewResultsSQLi.Size = new System.Drawing.Size(896, 484);
            this.treeViewResultsSQLi.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(36, 764);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(896, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // richTextBoxUrlTargetSQLi
            // 
            this.richTextBoxUrlTargetSQLi.Location = new System.Drawing.Point(198, 10);
            this.richTextBoxUrlTargetSQLi.Name = "richTextBoxUrlTargetSQLi";
            this.richTextBoxUrlTargetSQLi.Size = new System.Drawing.Size(734, 142);
            this.richTextBoxUrlTargetSQLi.TabIndex = 12;
            this.richTextBoxUrlTargetSQLi.Text = "";
            // 
            // buttonAbortScanSQLi
            // 
            this.buttonAbortScanSQLi.Enabled = false;
            this.buttonAbortScanSQLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbortScanSQLi.Location = new System.Drawing.Point(626, 794);
            this.buttonAbortScanSQLi.Name = "buttonAbortScanSQLi";
            this.buttonAbortScanSQLi.Size = new System.Drawing.Size(162, 39);
            this.buttonAbortScanSQLi.TabIndex = 11;
            this.buttonAbortScanSQLi.Text = "ABORT THIS SCAN";
            this.buttonAbortScanSQLi.UseVisualStyleBackColor = true;
            this.buttonAbortScanSQLi.Click += new System.EventHandler(this.buttonAbortScanSQLi_Click);
            // 
            // buttonPauseScanSQLi
            // 
            this.buttonPauseScanSQLi.Enabled = false;
            this.buttonPauseScanSQLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPauseScanSQLi.Location = new System.Drawing.Point(360, 793);
            this.buttonPauseScanSQLi.Name = "buttonPauseScanSQLi";
            this.buttonPauseScanSQLi.Size = new System.Drawing.Size(210, 39);
            this.buttonPauseScanSQLi.TabIndex = 10;
            this.buttonPauseScanSQLi.Text = "PAUSE THIS SCAN";
            this.buttonPauseScanSQLi.UseVisualStyleBackColor = true;
            this.buttonPauseScanSQLi.Click += new System.EventHandler(this.buttonPauseScanSQLi_Click);
            // 
            // buttonStartScanSQLi
            // 
            this.buttonStartScanSQLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartScanSQLi.Location = new System.Drawing.Point(188, 793);
            this.buttonStartScanSQLi.Name = "buttonStartScanSQLi";
            this.buttonStartScanSQLi.Size = new System.Drawing.Size(121, 40);
            this.buttonStartScanSQLi.TabIndex = 9;
            this.buttonStartScanSQLi.Text = "START SCAN";
            this.buttonStartScanSQLi.UseVisualStyleBackColor = true;
            this.buttonStartScanSQLi.Click += new System.EventHandler(this.buttonStartScanSQLi_Click);
            // 
            // comboBoxTypeInjection
            // 
            this.comboBoxTypeInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeInjection.FormattingEnabled = true;
            this.comboBoxTypeInjection.Items.AddRange(new object[] {
            "Simple quote (\')",
            "Double quotes (\")",
            "Integer"});
            this.comboBoxTypeInjection.Location = new System.Drawing.Point(198, 238);
            this.comboBoxTypeInjection.Name = "comboBoxTypeInjection";
            this.comboBoxTypeInjection.Size = new System.Drawing.Size(734, 24);
            this.comboBoxTypeInjection.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type of injection          :";
            // 
            // comboBoxTypeRequestSQLi
            // 
            this.comboBoxTypeRequestSQLi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeRequestSQLi.FormattingEnabled = true;
            this.comboBoxTypeRequestSQLi.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comboBoxTypeRequestSQLi.Location = new System.Drawing.Point(198, 199);
            this.comboBoxTypeRequestSQLi.Name = "comboBoxTypeRequestSQLi";
            this.comboBoxTypeRequestSQLi.Size = new System.Drawing.Size(734, 24);
            this.comboBoxTypeRequestSQLi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Type of request           :";
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Items.AddRange(new object[] {
            "MySQL (Normal - Error based)",
            "MySQL (Normal - No error)",
            "MySQL (Blind - Error based)",
            "MySQL (Blind - No error)"});
            this.comboBoxDatabase.Location = new System.Drawing.Point(198, 159);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(734, 24);
            this.comboBoxDatabase.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data base                    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "URL(s) of the target(s) :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBoxTypeRequestXSS);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.richTextBoxUrlTargetXSS);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(975, 840);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XSS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(33, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Infos of the POST variable(s):";
            // 
            // comboBoxTypeRequestXSS
            // 
            this.comboBoxTypeRequestXSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeRequestXSS.FormattingEnabled = true;
            this.comboBoxTypeRequestXSS.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comboBoxTypeRequestXSS.Location = new System.Drawing.Point(234, 159);
            this.comboBoxTypeRequestXSS.Name = "comboBoxTypeRequestXSS";
            this.comboBoxTypeRequestXSS.Size = new System.Drawing.Size(698, 24);
            this.comboBoxTypeRequestXSS.TabIndex = 3;
            this.comboBoxTypeRequestXSS.SelectedValueChanged += new System.EventHandler(this.comboBoxTypeRequestXSS_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Type of request                     :";
            // 
            // richTextBoxUrlTargetXSS
            // 
            this.richTextBoxUrlTargetXSS.Location = new System.Drawing.Point(234, 10);
            this.richTextBoxUrlTargetXSS.Name = "richTextBoxUrlTargetXSS";
            this.richTextBoxUrlTargetXSS.Size = new System.Drawing.Size(698, 142);
            this.richTextBoxUrlTargetXSS.TabIndex = 1;
            this.richTextBoxUrlTargetXSS.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "URL(s) of the target(s)           :";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(975, 840);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "R/LFI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(975, 840);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CSRF";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBoxSettingsCSRF);
            this.tabPage5.Controls.Add(this.checkBoxExpertMode);
            this.tabPage5.Controls.Add(this.groupBoxSettingsRFLI);
            this.tabPage5.Controls.Add(this.groupBoxSettingsXSS);
            this.tabPage5.Controls.Add(this.groupBoxSettingsSQLi);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(975, 840);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Setttings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettingsCSRF
            // 
            this.groupBoxSettingsCSRF.Enabled = false;
            this.groupBoxSettingsCSRF.Location = new System.Drawing.Point(7, 544);
            this.groupBoxSettingsCSRF.Name = "groupBoxSettingsCSRF";
            this.groupBoxSettingsCSRF.Size = new System.Drawing.Size(957, 100);
            this.groupBoxSettingsCSRF.TabIndex = 5;
            this.groupBoxSettingsCSRF.TabStop = false;
            this.groupBoxSettingsCSRF.Text = "CSRF settings";
            // 
            // groupBoxSettingsRFLI
            // 
            this.groupBoxSettingsRFLI.Enabled = false;
            this.groupBoxSettingsRFLI.Location = new System.Drawing.Point(7, 429);
            this.groupBoxSettingsRFLI.Name = "groupBoxSettingsRFLI";
            this.groupBoxSettingsRFLI.Size = new System.Drawing.Size(957, 100);
            this.groupBoxSettingsRFLI.TabIndex = 4;
            this.groupBoxSettingsRFLI.TabStop = false;
            this.groupBoxSettingsRFLI.Text = "R/LFI settings";
            // 
            // groupBoxSettingsXSS
            // 
            this.groupBoxSettingsXSS.Enabled = false;
            this.groupBoxSettingsXSS.Location = new System.Drawing.Point(7, 321);
            this.groupBoxSettingsXSS.Name = "groupBoxSettingsXSS";
            this.groupBoxSettingsXSS.Size = new System.Drawing.Size(957, 92);
            this.groupBoxSettingsXSS.TabIndex = 2;
            this.groupBoxSettingsXSS.TabStop = false;
            this.groupBoxSettingsXSS.Text = "XSS settings";
            // 
            // groupBoxSettingsSQLi
            // 
            this.groupBoxSettingsSQLi.Controls.Add(this.label9);
            this.groupBoxSettingsSQLi.Controls.Add(this.buttonDefaultSettingsSQLi);
            this.groupBoxSettingsSQLi.Controls.Add(this.buttonApplySettingsSQLi);
            this.groupBoxSettingsSQLi.Controls.Add(this.richTextBoxUserAgentValue);
            this.groupBoxSettingsSQLi.Controls.Add(this.comboBoxUserAgentName);
            this.groupBoxSettingsSQLi.Controls.Add(this.comboBoxSpaceSQLi);
            this.groupBoxSettingsSQLi.Controls.Add(this.comboBoxFollowRedirectSQLi);
            this.groupBoxSettingsSQLi.Controls.Add(this.label4);
            this.groupBoxSettingsSQLi.Controls.Add(this.label3);
            this.groupBoxSettingsSQLi.Controls.Add(this.label2);
            this.groupBoxSettingsSQLi.Controls.Add(this.label1);
            this.groupBoxSettingsSQLi.Controls.Add(this.comboBoxEndRequestSQLi);
            this.groupBoxSettingsSQLi.Enabled = false;
            this.groupBoxSettingsSQLi.Location = new System.Drawing.Point(4, 45);
            this.groupBoxSettingsSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSettingsSQLi.Name = "groupBoxSettingsSQLi";
            this.groupBoxSettingsSQLi.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSettingsSQLi.Size = new System.Drawing.Size(960, 269);
            this.groupBoxSettingsSQLi.TabIndex = 1;
            this.groupBoxSettingsSQLi.TabStop = false;
            this.groupBoxSettingsSQLi.Text = "SQLi settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "User-Agent Value    :";
            // 
            // buttonDefaultSettingsSQLi
            // 
            this.buttonDefaultSettingsSQLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefaultSettingsSQLi.Location = new System.Drawing.Point(361, 222);
            this.buttonDefaultSettingsSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDefaultSettingsSQLi.Name = "buttonDefaultSettingsSQLi";
            this.buttonDefaultSettingsSQLi.Size = new System.Drawing.Size(168, 39);
            this.buttonDefaultSettingsSQLi.TabIndex = 10;
            this.buttonDefaultSettingsSQLi.Text = "DEFAULT SETTINGS";
            this.buttonDefaultSettingsSQLi.UseVisualStyleBackColor = true;
            // 
            // buttonApplySettingsSQLi
            // 
            this.buttonApplySettingsSQLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplySettingsSQLi.Image = ((System.Drawing.Image)(resources.GetObject("buttonApplySettingsSQLi.Image")));
            this.buttonApplySettingsSQLi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonApplySettingsSQLi.Location = new System.Drawing.Point(164, 222);
            this.buttonApplySettingsSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApplySettingsSQLi.Name = "buttonApplySettingsSQLi";
            this.buttonApplySettingsSQLi.Size = new System.Drawing.Size(189, 39);
            this.buttonApplySettingsSQLi.TabIndex = 9;
            this.buttonApplySettingsSQLi.Text = "   Apply these settings";
            this.buttonApplySettingsSQLi.UseVisualStyleBackColor = true;
            // 
            // richTextBoxUserAgentValue
            // 
            this.richTextBoxUserAgentValue.Location = new System.Drawing.Point(164, 156);
            this.richTextBoxUserAgentValue.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxUserAgentValue.Name = "richTextBoxUserAgentValue";
            this.richTextBoxUserAgentValue.Size = new System.Drawing.Size(787, 56);
            this.richTextBoxUserAgentValue.TabIndex = 8;
            this.richTextBoxUserAgentValue.Text = "Mozilla/5.0 (Windows; U; Windows NT 5.1; enUS; rv:1.7.8) Gecko/20050511 Firefox/1" +
                ".0.4";
            // 
            // comboBoxUserAgentName
            // 
            this.comboBoxUserAgentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserAgentName.FormattingEnabled = true;
            this.comboBoxUserAgentName.Items.AddRange(new object[] {
            "Crawler for Ask Jeeves/Teoma",
            "ELinks 0.4pre5 on Linux",
            "Googlebot",
            "Internet Explorer 5.2 on Mac OS X",
            "Internet Explorer 6.0 on Windows XP",
            "Internet Explorer 7.0 beta running on Windows Longhorn",
            "Konqueror 3.1 (French)",
            "Konqueror 3.1 (English)",
            "Links 0.99pre14 under Cygwin on Windows 2000",
            "Links 2.1pre17 under Gentoo Linux",
            "Lynx 2.8.4rel.1 on Linux",
            "firefox",
            "Mozilla 1.7.8 on Linux",
            "Mozilla Firefox 1.0.4 on FreeBSD 5.4 on i386",
            "Mozilla Firefox 1.0.4 on Ubuntu Linux, on AMD64",
            "Mozilla Firefox 1.0.4 on Windows XP",
            "Netscape 4.8 on Windows 2000",
            "Netscape 7 on Sun Solaris 8",
            "Netscape 8.0.1 on Windows XP using Gecko",
            "Netscape 8.0.1 on Windows XP using MSHTML (with .NET installed)",
            "Off By One 3.5a on Windows XP",
            "Opera 6.03 on Windows 2000, cloaked as MSIE",
            "Opera 7.23 on Windows 98",
            "Opera 8.00 on Gentoo Linux",
            "Opera 8.00 on Windows XP ",
            "Safari v125 on Mac OS X ",
            "Safari v125 on Mac OS X, cloaked as MSIE",
            "w3m on FreeBSD"});
            this.comboBoxUserAgentName.Location = new System.Drawing.Point(164, 123);
            this.comboBoxUserAgentName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUserAgentName.Name = "comboBoxUserAgentName";
            this.comboBoxUserAgentName.Size = new System.Drawing.Size(787, 24);
            this.comboBoxUserAgentName.TabIndex = 7;
            this.comboBoxUserAgentName.SelectedValueChanged += new System.EventHandler(this.comboBoxUserAgentName_SelectedValueChanged);
            // 
            // comboBoxSpaceSQLi
            // 
            this.comboBoxSpaceSQLi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpaceSQLi.FormattingEnabled = true;
            this.comboBoxSpaceSQLi.Items.AddRange(new object[] {
            "%20",
            "/**/",
            "+"});
            this.comboBoxSpaceSQLi.Location = new System.Drawing.Point(164, 90);
            this.comboBoxSpaceSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpaceSQLi.Name = "comboBoxSpaceSQLi";
            this.comboBoxSpaceSQLi.Size = new System.Drawing.Size(787, 24);
            this.comboBoxSpaceSQLi.TabIndex = 6;
            // 
            // comboBoxFollowRedirectSQLi
            // 
            this.comboBoxFollowRedirectSQLi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFollowRedirectSQLi.FormattingEnabled = true;
            this.comboBoxFollowRedirectSQLi.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxFollowRedirectSQLi.Location = new System.Drawing.Point(164, 57);
            this.comboBoxFollowRedirectSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFollowRedirectSQLi.Name = "comboBoxFollowRedirectSQLi";
            this.comboBoxFollowRedirectSQLi.Size = new System.Drawing.Size(787, 24);
            this.comboBoxFollowRedirectSQLi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "User-Agent Name    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Replace space with  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Follow redirect          :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "End of request          :";
            // 
            // comboBoxEndRequestSQLi
            // 
            this.comboBoxEndRequestSQLi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndRequestSQLi.FormattingEnabled = true;
            this.comboBoxEndRequestSQLi.Items.AddRange(new object[] {
            "/*",
            "%",
            "#",
            "--"});
            this.comboBoxEndRequestSQLi.Location = new System.Drawing.Point(164, 23);
            this.comboBoxEndRequestSQLi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEndRequestSQLi.Name = "comboBoxEndRequestSQLi";
            this.comboBoxEndRequestSQLi.Size = new System.Drawing.Size(787, 24);
            this.comboBoxEndRequestSQLi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 886);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1006, 931);
            this.MinimumSize = new System.Drawing.Size(1006, 931);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Securitool @ EPITECH [ESL] by tapzorus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBoxSettingsSQLi.ResumeLayout(false);
            this.groupBoxSettingsSQLi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxExpertMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonAbortScanSQLi;
        private System.Windows.Forms.Button buttonPauseScanSQLi;
        private System.Windows.Forms.Button buttonStartScanSQLi;
        private System.Windows.Forms.ComboBox comboBoxTypeInjection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTypeRequestSQLi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBoxSettingsRFLI;
        private System.Windows.Forms.GroupBox groupBoxSettingsXSS;
        private System.Windows.Forms.GroupBox groupBoxSettingsSQLi;
        private System.Windows.Forms.Button buttonDefaultSettingsSQLi;
        private System.Windows.Forms.Button buttonApplySettingsSQLi;
        private System.Windows.Forms.RichTextBox richTextBoxUserAgentValue;
        private System.Windows.Forms.ComboBox comboBoxUserAgentName;
        private System.Windows.Forms.ComboBox comboBoxSpaceSQLi;
        private System.Windows.Forms.ComboBox comboBoxFollowRedirectSQLi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEndRequestSQLi;
        private System.Windows.Forms.GroupBox groupBoxSettingsCSRF;
        private System.Windows.Forms.RichTextBox richTextBoxUrlTargetSQLi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxUrlTargetXSS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTypeRequestXSS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TreeView treeViewResultsSQLi;
        private System.Windows.Forms.Timer timer1;



    }
}

