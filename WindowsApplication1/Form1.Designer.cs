namespace WindowsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.request = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.basicauthbutton = new System.Windows.Forms.RadioButton();
            this.ntlmauthbutton = new System.Windows.Forms.RadioButton();
            this.OpenCert = new System.Windows.Forms.OpenFileDialog();
            this.certfname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.proxyserverurl = new System.Windows.Forms.TextBox();
            this.proxychk = new System.Windows.Forms.CheckBox();
            this.proxyAuthChk = new System.Windows.Forms.CheckBox();
            this.proxypasswd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.responsebox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.addheaders = new System.Windows.Forms.TextBox();
            this.httpheaderlist = new System.Windows.Forms.ListBox();
            this.targeturl = new System.Windows.Forms.TextBox();
            this.urltext = new System.Windows.Forms.TextBox();
            this.PostRadio = new System.Windows.Forms.RadioButton();
            this.GETRadio = new System.Windows.Forms.RadioButton();
            this.TestButton = new System.Windows.Forms.Button();
            this.fuzz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.proxyuname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portlist = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.Logger = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuzzSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSOAPFuzzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label10 = new System.Windows.Forms.Label();
            this.addmarkerbutton = new System.Windows.Forms.Button();
            this.delmarkerbutton = new System.Windows.Forms.Button();
            this.resetmarkerbutton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.autoselectmarkerbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debug :";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(15, 203);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(257, 219);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // request
            // 
            this.request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.request.Location = new System.Drawing.Point(431, 245);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.request.Size = new System.Drawing.Size(488, 104);
            this.request.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target URL :";
            // 
            // uname
            // 
            this.uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uname.Location = new System.Drawing.Point(743, 32);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(93, 20);
            this.uname.TabIndex = 14;
            // 
            // passwd
            // 
            this.passwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwd.Location = new System.Drawing.Point(742, 59);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(94, 20);
            this.passwd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
            // 
            // basicauthbutton
            // 
            this.basicauthbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.basicauthbutton.AutoSize = true;
            this.basicauthbutton.Location = new System.Drawing.Point(846, 35);
            this.basicauthbutton.Name = "basicauthbutton";
            this.basicauthbutton.Size = new System.Drawing.Size(76, 17);
            this.basicauthbutton.TabIndex = 16;
            this.basicauthbutton.TabStop = true;
            this.basicauthbutton.Text = "Basic Auth";
            this.basicauthbutton.UseVisualStyleBackColor = true;
            this.basicauthbutton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ntlmauthbutton
            // 
            this.ntlmauthbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ntlmauthbutton.AutoSize = true;
            this.ntlmauthbutton.Location = new System.Drawing.Point(846, 58);
            this.ntlmauthbutton.Name = "ntlmauthbutton";
            this.ntlmauthbutton.Size = new System.Drawing.Size(80, 17);
            this.ntlmauthbutton.TabIndex = 16;
            this.ntlmauthbutton.TabStop = true;
            this.ntlmauthbutton.Text = "NTLM Auth";
            this.ntlmauthbutton.UseVisualStyleBackColor = true;
            // 
            // OpenCert
            // 
            this.OpenCert.Filter = "Certificates (*.cer)|*.cer| X.509 Certificate|*.pem|Microsoft Certificate Store|*" +
    ".pfx|All Files (*.*)|*.*";
            this.OpenCert.InitialDirectory = ".";
            this.OpenCert.Title = "Open client certificate...";
            this.OpenCert.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // certfname
            // 
            this.certfname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.certfname.Location = new System.Drawing.Point(491, 91);
            this.certfname.Name = "certfname";
            this.certfname.Size = new System.Drawing.Size(345, 20);
            this.certfname.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(842, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Certificate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "HTTP Headers:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // proxyserverurl
            // 
            this.proxyserverurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyserverurl.Location = new System.Drawing.Point(491, 128);
            this.proxyserverurl.Name = "proxyserverurl";
            this.proxyserverurl.Size = new System.Drawing.Size(345, 20);
            this.proxyserverurl.TabIndex = 23;
            // 
            // proxychk
            // 
            this.proxychk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxychk.AutoSize = true;
            this.proxychk.Location = new System.Drawing.Point(842, 132);
            this.proxychk.Name = "proxychk";
            this.proxychk.Size = new System.Drawing.Size(74, 17);
            this.proxychk.TabIndex = 24;
            this.proxychk.Text = "Use Proxy";
            this.proxychk.UseVisualStyleBackColor = true;
            // 
            // proxyAuthChk
            // 
            this.proxyAuthChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyAuthChk.AutoSize = true;
            this.proxyAuthChk.Location = new System.Drawing.Point(842, 157);
            this.proxyAuthChk.Name = "proxyAuthChk";
            this.proxyAuthChk.Size = new System.Drawing.Size(99, 17);
            this.proxyAuthChk.TabIndex = 24;
            this.proxyAuthChk.Text = "Use Proxy Auth";
            this.proxyAuthChk.UseVisualStyleBackColor = true;
            this.proxyAuthChk.CheckedChanged += new System.EventHandler(this.proxyAuthChk_CheckedChanged);
            // 
            // proxypasswd
            // 
            this.proxypasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxypasswd.Location = new System.Drawing.Point(729, 155);
            this.proxypasswd.Name = "proxypasswd";
            this.proxypasswd.Size = new System.Drawing.Size(97, 20);
            this.proxypasswd.TabIndex = 14;
            this.proxypasswd.TextChanged += new System.EventHandler(this.proxypasswd_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(638, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Proxy Password:";
            // 
            // responsebox
            // 
            this.responsebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responsebox.Location = new System.Drawing.Point(431, 368);
            this.responsebox.Multiline = true;
            this.responsebox.Name = "responsebox";
            this.responsebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responsebox.Size = new System.Drawing.Size(488, 123);
            this.responsebox.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(428, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Response:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Additional Headers:";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(61, 4);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "URL : ";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(428, 132);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Proxy : ";
            // 
            // addheaders
            // 
            this.addheaders.AcceptsReturn = true;
            this.addheaders.Location = new System.Drawing.Point(107, 133);
            this.addheaders.Multiline = true;
            this.addheaders.Name = "addheaders";
            this.addheaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addheaders.Size = new System.Drawing.Size(300, 50);
            this.addheaders.TabIndex = 32;
            this.addheaders.WordWrap = false;
            // 
            // httpheaderlist
            // 
            this.httpheaderlist.FormattingEnabled = true;
            this.httpheaderlist.HorizontalScrollbar = true;
            this.httpheaderlist.Location = new System.Drawing.Point(107, 91);
            this.httpheaderlist.Name = "httpheaderlist";
            this.httpheaderlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.httpheaderlist.Size = new System.Drawing.Size(300, 30);
            this.httpheaderlist.TabIndex = 25;
            // 
            // targeturl
            // 
            this.targeturl.Location = new System.Drawing.Point(107, 62);
            this.targeturl.Name = "targeturl";
            this.targeturl.Size = new System.Drawing.Size(300, 20);
            this.targeturl.TabIndex = 10;
            // 
            // urltext
            // 
            this.urltext.Location = new System.Drawing.Point(107, 34);
            this.urltext.Name = "urltext";
            this.urltext.Size = new System.Drawing.Size(495, 20);
            this.urltext.TabIndex = 0;
            this.urltext.Text = "http://www.usairways.com/Shared/Services/CommonWebService.asmx?wsdl";
            this.urltext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PostRadio
            // 
            this.PostRadio.AutoSize = true;
            this.PostRadio.Checked = true;
            this.PostRadio.Location = new System.Drawing.Point(423, 62);
            this.PostRadio.Name = "PostRadio";
            this.PostRadio.Size = new System.Drawing.Size(54, 17);
            this.PostRadio.TabIndex = 12;
            this.PostRadio.TabStop = true;
            this.PostRadio.Text = "POST";
            this.PostRadio.UseVisualStyleBackColor = true;
            // 
            // GETRadio
            // 
            this.GETRadio.AutoSize = true;
            this.GETRadio.Location = new System.Drawing.Point(480, 62);
            this.GETRadio.Name = "GETRadio";
            this.GETRadio.Size = new System.Drawing.Size(47, 17);
            this.GETRadio.TabIndex = 13;
            this.GETRadio.Text = "GET";
            this.GETRadio.UseVisualStyleBackColor = true;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(529, 59);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(77, 23);
            this.TestButton.TabIndex = 21;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // fuzz
            // 
            this.fuzz.Location = new System.Drawing.Point(608, 59);
            this.fuzz.Name = "fuzz";
            this.fuzz.Size = new System.Drawing.Size(77, 23);
            this.fuzz.TabIndex = 21;
            this.fuzz.Text = "Fuzz!";
            this.fuzz.UseVisualStyleBackColor = true;
            this.fuzz.Click += new System.EventHandler(this.fuzz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proxyuname
            // 
            this.proxyuname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyuname.Location = new System.Drawing.Point(521, 154);
            this.proxyuname.Name = "proxyuname";
            this.proxyuname.Size = new System.Drawing.Size(111, 20);
            this.proxyuname.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Proxy Username:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Request:";
            // 
            // portlist
            // 
            this.portlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.portlist.HideSelection = false;
            this.portlist.Location = new System.Drawing.Point(287, 203);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(120, 219);
            this.portlist.TabIndex = 28;
            this.portlist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.portlist_AfterSelect);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "WSDL Ports:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Logger
            // 
            this.Logger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logger.Location = new System.Drawing.Point(15, 441);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Logger.Size = new System.Drawing.Size(392, 50);
            this.Logger.TabIndex = 5;
            this.Logger.TextChanged += new System.EventHandler(this.Logger_TextChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuzzSettingsToolStripMenuItem,
            this.networkSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // fuzzSettingsToolStripMenuItem
            // 
            this.fuzzSettingsToolStripMenuItem.Name = "fuzzSettingsToolStripMenuItem";
            this.fuzzSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fuzzSettingsToolStripMenuItem.Text = "Fuz&z Settings";
            this.fuzzSettingsToolStripMenuItem.Click += new System.EventHandler(this.fuzzSettingsToolStripMenuItem_Click);
            // 
            // networkSettingsToolStripMenuItem
            // 
            this.networkSettingsToolStripMenuItem.Name = "networkSettingsToolStripMenuItem";
            this.networkSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.networkSettingsToolStripMenuItem.Text = "&Network Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSOAPFuzzerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutSOAPFuzzerToolStripMenuItem
            // 
            this.aboutSOAPFuzzerToolStripMenuItem.Name = "aboutSOAPFuzzerToolStripMenuItem";
            this.aboutSOAPFuzzerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutSOAPFuzzerToolStripMenuItem.Text = "About SOAPFuzzer";
            this.aboutSOAPFuzzerToolStripMenuItem.Click += new System.EventHandler(this.aboutSOAPFuzzerToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(435, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 2);
            this.label10.TabIndex = 35;
            // 
            // addmarkerbutton
            // 
            this.addmarkerbutton.Location = new System.Drawing.Point(431, 203);
            this.addmarkerbutton.Name = "addmarkerbutton";
            this.addmarkerbutton.Size = new System.Drawing.Size(75, 23);
            this.addmarkerbutton.TabIndex = 36;
            this.addmarkerbutton.Text = "Add Marker";
            this.addmarkerbutton.UseVisualStyleBackColor = true;
            this.addmarkerbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // delmarkerbutton
            // 
            this.delmarkerbutton.Location = new System.Drawing.Point(516, 203);
            this.delmarkerbutton.Name = "delmarkerbutton";
            this.delmarkerbutton.Size = new System.Drawing.Size(86, 23);
            this.delmarkerbutton.TabIndex = 37;
            this.delmarkerbutton.Text = "Del Marker";
            this.delmarkerbutton.UseVisualStyleBackColor = true;
            // 
            // resetmarkerbutton
            // 
            this.resetmarkerbutton.Location = new System.Drawing.Point(608, 203);
            this.resetmarkerbutton.Name = "resetmarkerbutton";
            this.resetmarkerbutton.Size = new System.Drawing.Size(92, 23);
            this.resetmarkerbutton.TabIndex = 38;
            this.resetmarkerbutton.Text = "Reset Markers";
            this.resetmarkerbutton.UseVisualStyleBackColor = true;
            this.resetmarkerbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(432, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(484, 2);
            this.label17.TabIndex = 39;
            // 
            // autoselectmarkerbutton
            // 
            this.autoselectmarkerbutton.Location = new System.Drawing.Point(707, 202);
            this.autoselectmarkerbutton.Name = "autoselectmarkerbutton";
            this.autoselectmarkerbutton.Size = new System.Drawing.Size(119, 23);
            this.autoselectmarkerbutton.TabIndex = 40;
            this.autoselectmarkerbutton.Text = "Auto-Select Marker";
            this.autoselectmarkerbutton.UseVisualStyleBackColor = true;
            this.autoselectmarkerbutton.Click += new System.EventHandler(this.autoselectmarkerbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(941, 503);
            this.Controls.Add(this.autoselectmarkerbutton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.resetmarkerbutton);
            this.Controls.Add(this.delmarkerbutton);
            this.Controls.Add(this.addmarkerbutton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addheaders);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.responsebox);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.httpheaderlist);
            this.Controls.Add(this.proxyAuthChk);
            this.Controls.Add(this.proxychk);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.proxyserverurl);
            this.Controls.Add(this.fuzz);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.certfname);
            this.Controls.Add(this.ntlmauthbutton);
            this.Controls.Add(this.basicauthbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.proxypasswd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.proxyuname);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.GETRadio);
            this.Controls.Add(this.PostRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targeturl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.request);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urltext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SOAPFuzzer";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton basicauthbutton;
        private System.Windows.Forms.RadioButton ntlmauthbutton;
        private System.Windows.Forms.OpenFileDialog OpenCert;
        private System.Windows.Forms.TextBox certfname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox proxyserverurl;
        private System.Windows.Forms.CheckBox proxychk;
        private System.Windows.Forms.CheckBox proxyAuthChk;
        private System.Windows.Forms.TextBox proxypasswd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox responsebox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip File;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox addheaders;
        private System.Windows.Forms.ListBox httpheaderlist;
        private System.Windows.Forms.TextBox targeturl;
        private System.Windows.Forms.TextBox urltext;
        private System.Windows.Forms.RadioButton PostRadio;
        private System.Windows.Forms.RadioButton GETRadio;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button fuzz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox proxyuname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView portlist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Logger;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuzzSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSOAPFuzzerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addmarkerbutton;
        private System.Windows.Forms.Button delmarkerbutton;
        private System.Windows.Forms.Button resetmarkerbutton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button autoselectmarkerbutton;
    }
}

