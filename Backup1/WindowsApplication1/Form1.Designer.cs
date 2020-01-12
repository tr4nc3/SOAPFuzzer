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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urltext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Logger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.request = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targeturl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PostRadio = new System.Windows.Forms.RadioButton();
            this.GETRadio = new System.Windows.Forms.RadioButton();
            this.uname = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.OpenCert = new System.Windows.Forms.OpenFileDialog();
            this.certfname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.proxyserverurl = new System.Windows.Forms.TextBox();
            this.proxychk = new System.Windows.Forms.CheckBox();
            this.proxyAuthChk = new System.Windows.Forms.CheckBox();
            this.proxyuname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.proxypasswd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.httpheaderlist = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.portlist = new System.Windows.Forms.TreeView();
            this.responsebox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urltext
            // 
            this.urltext.Location = new System.Drawing.Point(60, 9);
            this.urltext.Name = "urltext";
            this.urltext.Size = new System.Drawing.Size(546, 20);
            this.urltext.TabIndex = 0;
            this.urltext.Text = "http://soap.amazon.com/schemas2/AmazonWebServices.wsdl";
            this.urltext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logger
            // 
            this.Logger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logger.Location = new System.Drawing.Point(15, 363);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Logger.Size = new System.Drawing.Size(427, 83);
            this.Logger.TabIndex = 5;
            this.Logger.TextChanged += new System.EventHandler(this.Logger_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debug :";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(15, 149);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(316, 186);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // request
            // 
            this.request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.request.Location = new System.Drawing.Point(458, 149);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.request.Size = new System.Drawing.Size(461, 154);
            this.request.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Request:";
            // 
            // targeturl
            // 
            this.targeturl.Location = new System.Drawing.Point(72, 37);
            this.targeturl.Name = "targeturl";
            this.targeturl.Size = new System.Drawing.Size(335, 20);
            this.targeturl.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target URL :";
            // 
            // PostRadio
            // 
            this.PostRadio.AutoSize = true;
            this.PostRadio.Checked = true;
            this.PostRadio.Location = new System.Drawing.Point(423, 37);
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
            this.GETRadio.Location = new System.Drawing.Point(480, 37);
            this.GETRadio.Name = "GETRadio";
            this.GETRadio.Size = new System.Drawing.Size(47, 17);
            this.GETRadio.TabIndex = 13;
            this.GETRadio.Text = "GET";
            this.GETRadio.UseVisualStyleBackColor = true;
            // 
            // uname
            // 
            this.uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uname.Location = new System.Drawing.Point(743, 7);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(100, 20);
            this.uname.TabIndex = 14;
            // 
            // passwd
            // 
            this.passwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwd.Location = new System.Drawing.Point(742, 34);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(100, 20);
            this.passwd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(853, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Basic Auth";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(853, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 17);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "NTLM Auth";
            this.radioButton4.UseVisualStyleBackColor = true;
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
            this.certfname.Location = new System.Drawing.Point(529, 63);
            this.certfname.Name = "certfname";
            this.certfname.Size = new System.Drawing.Size(325, 20);
            this.certfname.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(860, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Certificate:";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "HTTP Headers:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(529, 34);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(77, 23);
            this.TestButton.TabIndex = 21;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Fuzz!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Proxy : ";
            // 
            // proxyserverurl
            // 
            this.proxyserverurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyserverurl.Location = new System.Drawing.Point(431, 91);
            this.proxyserverurl.Name = "proxyserverurl";
            this.proxyserverurl.Size = new System.Drawing.Size(204, 20);
            this.proxyserverurl.TabIndex = 23;
            // 
            // proxychk
            // 
            this.proxychk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxychk.AutoSize = true;
            this.proxychk.Location = new System.Drawing.Point(834, 86);
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
            this.proxyAuthChk.Location = new System.Drawing.Point(834, 108);
            this.proxyAuthChk.Name = "proxyAuthChk";
            this.proxyAuthChk.Size = new System.Drawing.Size(99, 17);
            this.proxyAuthChk.TabIndex = 24;
            this.proxyAuthChk.Text = "Use Proxy Auth";
            this.proxyAuthChk.UseVisualStyleBackColor = true;
            this.proxyAuthChk.CheckedChanged += new System.EventHandler(this.proxyAuthChk_CheckedChanged);
            // 
            // proxyuname
            // 
            this.proxyuname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyuname.Location = new System.Drawing.Point(705, 86);
            this.proxyuname.Name = "proxyuname";
            this.proxyuname.Size = new System.Drawing.Size(123, 20);
            this.proxyuname.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Proxy User:";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // proxypasswd
            // 
            this.proxypasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxypasswd.Location = new System.Drawing.Point(705, 111);
            this.proxypasswd.Name = "proxypasswd";
            this.proxypasswd.Size = new System.Drawing.Size(123, 20);
            this.proxypasswd.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(614, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Proxy Password:";
            this.label13.Click += new System.EventHandler(this.label6_Click);
            // 
            // httpheaderlist
            // 
            this.httpheaderlist.FormattingEnabled = true;
            this.httpheaderlist.HorizontalScrollbar = true;
            this.httpheaderlist.Location = new System.Drawing.Point(91, 66);
            this.httpheaderlist.Name = "httpheaderlist";
            this.httpheaderlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.httpheaderlist.Size = new System.Drawing.Size(316, 56);
            this.httpheaderlist.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "WSDL Ports:";
            // 
            // portlist
            // 
            this.portlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.portlist.HideSelection = false;
            this.portlist.Location = new System.Drawing.Point(337, 150);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(105, 185);
            this.portlist.TabIndex = 28;
            this.portlist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.portlist_AfterSelect);
            // 
            // responsebox
            // 
            this.responsebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.responsebox.Location = new System.Drawing.Point(458, 322);
            this.responsebox.Multiline = true;
            this.responsebox.Name = "responsebox";
            this.responsebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responsebox.Size = new System.Drawing.Size(461, 124);
            this.responsebox.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(455, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 456);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.responsebox);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.httpheaderlist);
            this.Controls.Add(this.proxyAuthChk);
            this.Controls.Add(this.proxychk);
            this.Controls.Add(this.proxyserverurl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.certfname);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urltext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SOAPFuzzer";
            this.Load += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Logger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targeturl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton PostRadio;
        private System.Windows.Forms.RadioButton GETRadio;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.OpenFileDialog OpenCert;
        private System.Windows.Forms.TextBox certfname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox proxyserverurl;
        private System.Windows.Forms.CheckBox proxychk;
        private System.Windows.Forms.CheckBox proxyAuthChk;
        private System.Windows.Forms.TextBox proxyuname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox proxypasswd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox httpheaderlist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TreeView portlist;
        private System.Windows.Forms.TextBox responsebox;
        private System.Windows.Forms.Label label14;
    }
}

