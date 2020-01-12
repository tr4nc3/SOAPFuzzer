namespace WindowsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        public static System.Collections.Generic.List<string> listofinjections = new System.Collections.Generic.List<string>() 
                            { "&gt;&quot;&gt;&lt;script&gt;alert(&quot;XSS&quot;)&lt;/script&gt;",
                            "&quot;&gt;&lt;STYLE&gt;@import&quot;javascript:alert(\'XSS\')&quot;;&lt;/STYLE&gt;",
                            "&gt;&quot;\'&gt;&lt;img%20src%3D%26%23x6a;%26%23x61;%26%23x76;%26%23x61;%26%23x73;%26%23x63;%26%23x72;%26%23x69;%26%23x70;%26%23x74;%26%23x3a;",
                            "alert(%26quot;%26%23x20;XSS%26%23x20;Test%26%23x20;Successful%26quot;)&gt;",
                            "&gt;%22%27&gt;&lt;img%20src%3d%22javascript:alert(%27%20XSS%27)%22&gt;",
                            "\'%uff1cscript%uff1ealert(\'XSS\')%uff1c/script%uff1e\'",
                            "&quot;&gt;",
                            "&gt;&quot;",
                            "\'\';!--&quot;&lt;XSS&gt;=&amp;{()}",
                            "&lt;IMG SRC=&quot;javascript:alert(\'XSS\');&quot;&gt;",
                            "&lt;IMG SRC=javascript:alert(\'XSS\')&gt;",
                            "&lt;IMG SRC=JaVaScRiPt:alert(\'XSS\')&gt; ",
                            "&lt;IMG SRC=JaVaScRiPt:alert(&quot;XSS&lt;WBR&gt;&quot;)&gt;",
                            "&lt;IMGSRC=&#106;&#97;&#118;&#97;&amp;&lt;WBR&gt;#115;&#99;&#114;&#105;&#112;&&lt;WBR&gt;#116;&#58;&#97;",
                            "&#108;&#101;&&lt;WBR&gt;#114;&#116;&#40;&#39;&#88;&#83&lt;WBR&gt;;&#83;&#39;&#41&gt;",
                            "&lt;IMGSRC=&#0000106;&#0000097;&lt;WBR&gt;&#0000118;&#0000097;&#0000115&lt;WBR&gt;&#0000099;&#0000114;&#0000105&&lt;WBR&gt;&#0000112&#0000116;&#0000058",
                            "&&lt;WBR&gt;#0000097;&#0000108;&#0000101;&amp;&lt;WBR&gt;&#0000114;&#0000116;&#0000040;&amp;&lt;WBR&gt;&#0000039;&#0000088;&#0000083;&amp;&lt;WBR&gt;&#0000083;&#0000039;&#0000041;&gt;",
                            "&lt;IMGSRC=&#x6A;&#x61;&#x76;&#x61;&#x73;&amp;&lt;WBR&gt;&#x63;&#x72;&#x69;&#x70;",
                            "&#x74;&#x3A;&amp;&lt;WBR&gt;&#x61;&#x6C;&#x65;&#x72;&#x74;&#x28;",
                            "&amp;&lt;WBR&gt;#x27;&#x58;&#x53;&#x53;&#x27;&#x29;&gt;",
                            "&lt;IMG SRC=&quot;jav&#x09;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;",
                            "&lt;IMG SRC=&quot;jav&#x0A;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;",
                            "&lt;IMG SRC=&quot;jav&#x0D;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;",
                            "ajajajaa\';alert(1);//",
                            "&lt;img src=blah onerror=&quot;alert(1232)&quot;/&gt;",
                            "&lt;script&gt;alert(\'xss\')&lt;/script&gt;",
                            "1 OR 1=1",
                            "1' OR '1'='1",
                            "Z'Z",      
                            "1 EXEC SP_ ",
                            "1 AND 1=1",
                            "1 AND USER_NAME() = 'dbo'",
                            "\'; DESC users; --",
                            "1\'1",
                            "1 UNI/**/ON SELECT ALL FROM WHERE",
                            "';waitfor delay '0:0:5'",
                            ";waitfor delay '0:0:5'--",
                            "'%20or%201=1--",
                            "' having 1=1--",
                            ";exec whateva",
                            "1 + 1 > 2",
                            "2+2"
                            };
        
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
            /*
            listofinjections.Add("&gt;&quot;&gt;&lt;script&gt;alert(&quot;XSS&quot;)&lt;/script&gt;&");
            listofinjections.Add("&quot;&gt;&lt;STYLE&gt;@import&quot;javascript:alert(\'XSS\')&quot;;&lt;/STYLE&gt;");
            listofinjections.Add("&gt;&quot;\'&gt;&lt;img%20src%3D%26%23x6a;%26%23x61;%26%23x76;%26%23x61;%26%23x73;%26%23x63;%26%23x72;%26%23x69;%26%23x70;%26%23x74;%26%23x3a;");
            listofinjections.Add("alert(%26quot;%26%23x20;XSS%26%23x20;Test%26%23x20;Successful%26quot;)&gt;");
            listofinjections.Add("&gt;%22%27&gt;&lt;img%20src%3d%22javascript:alert(%27%20XSS%27)%22&gt;");
            listofinjections.Add("\'%uff1cscript%uff1ealert(\'XSS\')%uff1c/script%uff1e\'");
            listofinjections.Add("&quot;&gt;");
            listofinjections.Add("&gt;&quot;");
            listofinjections.Add("\'\';!--&quot;&lt;XSS&gt;=&amp;{()}");
            listofinjections.Add("&lt;IMG SRC=&quot;javascript:alert(\'XSS\');&quot;&gt;");
            listofinjections.Add("&lt;IMG SRC=javascript:alert(\'XSS\')&gt;");
            listofinjections.Add("&lt;IMG SRC=JaVaScRiPt:alert(\'XSS\')&gt; ");
            listofinjections.Add("&lt;IMG SRC=JaVaScRiPt:alert(&quot;XSS&lt;WBR&gt;&quot;)&gt;");
            listofinjections.Add("&lt;IMGSRC=&#106;&#97;&#118;&#97;&amp;&lt;WBR&gt;#115;&#99;&#114;&#105;&#112;&&lt;WBR&gt;#116;&#58;&#97;");
            listofinjections.Add("&#108;&#101;&&lt;WBR&gt;#114;&#116;&#40;&#39;&#88;&#83&lt;WBR&gt;;&#83;&#39;&#41&gt;");
            listofinjections.Add("&lt;IMGSRC=&#0000106&#0000097&&lt;WBR&gt;#0000118&#0000097&#0000115&&lt;WBR&gt;#0000099&#0000114&#0000105&&lt;WBR&gt;#0000112&#0000116&#0000058");
            listofinjections.Add("&&lt;WBR&gt;#0000097;&#0000108;&#0000101;&amp;&lt;WBR&gt;&#0000114;&#0000116;&#0000040;&amp;&lt;WBR&gt;&#0000039;&#0000088;&#0000083;&amp;&lt;WBR&gt;&#0000083;&#0000039;&#0000041;&gt;");
            listofinjections.Add("&lt;IMGSRC=&#x6A;&#x61;&#x76;&#x61;&#x73;&amp;&lt;WBR&gt;&#x63;&#x72;&#x69;&#x70;" +
                                   "&#x74;&#x3A;&amp;&lt;WBR&gt;&#x61;&#x6C;&#x65;&#x72;&#x74;&#x28;");
            listofinjections.Add("&amp;&lt;WBR&gt;#x27;&#x58;&#x53;&#x53;&#x27;&#x29;&gt;");
            listofinjections.Add("&lt;IMG SRC=&quot;jav&#x09;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
            listofinjections.Add("&lt;IMG SRC=&quot;jav&#x0A;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
            listofinjections.Add("&lt;IMG SRC=&quot;jav&#x0D;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
            listofinjections.Add("ajajajaa\';alert(1);//");
            listofinjections.Add("&lt;img src=blah onerror=&quot;alert(1232)&quot;/&gt;");
            listofinjections.Add("&lt;script&gt;alert(\'xss\')&lt;/script&gt;");
            */
            
        //    System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("&gt;&quot;&gt;&lt;script&gt;alert(&quot;XSS&quot;)&lt;/script&gt;&");
        //    System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("&quot;&gt;&lt;STYLE&gt;@import&quot;javascript:alert(\'XSS\')&quot;;&lt;/STYLE&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("&gt;&quot;\'&gt;&lt;img%20src%3D%26%23x6a;%26%23x61;%26%23x76;%26%23x61;%26%23x73;" +
        //"%26%23x63;%26%23x72;%26%23x69;%26%23x70;%26%23x74;%26%23x3a;");
        //    System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(" alert(%26quot;%26%23x20;XSS%26%23x20;Test%26%23x20;Successful%26quot;)&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("&gt;%22%27&gt;&lt;img%20src%3d%22javascript:alert(%27%20XSS%27)%22&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("\'%uff1cscript%uff1ealert(\'XSS\')%uff1c/script%uff1e\'");
        //    System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("&quot;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("&gt;&quot;");
        //    System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("\'\';!--&quot;&lt;XSS&gt;=&amp;{()}");
        //    System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=&quot;javascript:alert(\'XSS\');&quot;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=javascript:alert(\'XSS\')&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=JaVaScRiPt:alert(\'XSS\')&gt; ");
        //    System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=JaVaScRiPt:alert(&quot;XSS&lt;WBR&gt;&quot;)&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("&lt;IMGSRC=&#106;&#97;&#118;&#97;&amp;&lt;WBR&gt;#115;&#99;&#114;&#105;&#112;&&lt" +
        //";WBR&gt;#116;&#58;&#97;");
        //    System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(" &#108;&#101;&&lt;WBR&gt;#114;&#116;&#40;&#39;&#88;&#83&lt;WBR&gt;;&#83;&#39;&#41" +
        //"&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("&lt;IMGSRC=&#0000106&#0000097&&lt;WBR&gt;#0000118&#0000097&#0000115&&lt;WBR&gt;#0" +
        //"000099&#0000114&#0000105&&lt;WBR&gt;#0000112&#0000116&#0000058");
        //    System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(" &&lt;WBR&gt;#0000097;&#0000108;&#0000101;&amp;&lt;WBR&gt;&#0000114;&#0000116;&#0" +
        //"000040;&amp;&lt;WBR&gt;&#0000039;&#0000088;&#0000083;&amp;&lt;WBR&gt;&#0000083;&" +
        //"#0000039;&#0000041;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("&lt;IMGSRC=&#x6A;&#x61;&#x76;&#x61;&#x73;&amp;&lt;WBR&gt;&#x63;&#x72;&#x69;&#x70;" +
        //"&#x74;&#x3A;&amp;&lt;WBR&gt;&#x61;&#x6C;&#x65;&#x72;&#x74;&#x28;");
        //    System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(" &amp;&lt;WBR&gt;#x27;&#x58;&#x53;&#x53;&#x27;&#x29;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=&quot;jav&#x09;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=&quot;jav&#x0A;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("&lt;IMG SRC=&quot;jav&#x0D;ascript:alert(&lt;WBR&gt;\'XSS\');&quot;&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("ajajajaa\';alert(1);//");
        //    System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("&lt;img src=blah onerror=&quot;alert(1232)&quot;/&gt;");
        //    System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("&lt;script&gt;alert(\'xss\')&lt;/script&gt;");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InjectStrings = new System.Windows.Forms.TabPage();
            this.inputonestr = new System.Windows.Forms.TextBox();
            this.add1strbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.addselected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.disabledstr = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeselected = new System.Windows.Forms.Button();
            this.importfile = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.deleteallbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.injstrlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parameters = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagcheckbox = new System.Windows.Forms.CheckBox();
            this.attributecheckbox = new System.Windows.Forms.CheckBox();
            this.xmlschemacheckBox = new System.Windows.Forms.CheckBox();
            this.tagvaluecheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlicheckBox = new System.Windows.Forms.CheckBox();
            this.xpathcheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.InjectStrings.SuspendLayout();
            this.Parameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InjectStrings);
            this.tabControl1.Controls.Add(this.Parameters);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 421);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // InjectStrings
            // 
            this.InjectStrings.Controls.Add(this.inputonestr);
            this.InjectStrings.Controls.Add(this.add1strbutton);
            this.InjectStrings.Controls.Add(this.savebutton);
            this.InjectStrings.Controls.Add(this.addselected);
            this.InjectStrings.Controls.Add(this.label2);
            this.InjectStrings.Controls.Add(this.disabledstr);
            this.InjectStrings.Controls.Add(this.removeselected);
            this.InjectStrings.Controls.Add(this.importfile);
            this.InjectStrings.Controls.Add(this.resetbutton);
            this.InjectStrings.Controls.Add(this.deleteallbutton);
            this.InjectStrings.Controls.Add(this.deletebutton);
            this.InjectStrings.Controls.Add(this.label1);
            this.InjectStrings.Controls.Add(this.injstrlist);
            this.InjectStrings.Location = new System.Drawing.Point(4, 22);
            this.InjectStrings.Name = "InjectStrings";
            this.InjectStrings.Padding = new System.Windows.Forms.Padding(3);
            this.InjectStrings.Size = new System.Drawing.Size(676, 395);
            this.InjectStrings.TabIndex = 0;
            this.InjectStrings.Text = "Injection Strings";
            this.InjectStrings.UseVisualStyleBackColor = true;
            this.InjectStrings.Click += new System.EventHandler(this.InjectStrings_Click);
            // 
            // inputonestr
            // 
            this.inputonestr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputonestr.Location = new System.Drawing.Point(91, 331);
            this.inputonestr.Name = "inputonestr";
            this.inputonestr.Size = new System.Drawing.Size(181, 20);
            this.inputonestr.TabIndex = 12;
            // 
            // add1strbutton
            // 
            this.add1strbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add1strbutton.Location = new System.Drawing.Point(7, 331);
            this.add1strbutton.Name = "add1strbutton";
            this.add1strbutton.Size = new System.Drawing.Size(75, 23);
            this.add1strbutton.TabIndex = 11;
            this.add1strbutton.Text = "Add";
            this.add1strbutton.UseVisualStyleBackColor = true;
            this.add1strbutton.Click += new System.EventHandler(this.add1strbutton1_Click_1);
            // 
            // savebutton
            // 
            this.savebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savebutton.Location = new System.Drawing.Point(283, 231);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 10;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // addselected
            // 
            this.addselected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addselected.Location = new System.Drawing.Point(283, 173);
            this.addselected.Name = "addselected";
            this.addselected.Size = new System.Drawing.Size(75, 23);
            this.addselected.TabIndex = 9;
            this.addselected.Text = "<<";
            this.addselected.UseVisualStyleBackColor = true;
            this.addselected.Click += new System.EventHandler(this.addselected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Disabled:";
            // 
            // disabledstr
            // 
            this.disabledstr.AllowDrop = true;
            this.disabledstr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disabledstr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.disabledstr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            foreach( var str in listofinjections ) {
                this.disabledstr.Items.Add(new System.Windows.Forms.ListViewItem(str));
            }
            //this.disabledstr.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            //listViewItem1,
            //listViewItem2,
            //listViewItem3,
            //listViewItem4,
            //listViewItem5,
            //listViewItem6,
            //listViewItem7,
            //listViewItem8,
            //listViewItem9,
            //listViewItem10,
            //listViewItem11,
            //listViewItem12,
            //listViewItem13,
            //listViewItem14,
            //listViewItem15,
            //listViewItem16,
            //listViewItem17,
            //listViewItem18,
            //listViewItem19,
            //listViewItem20,
            //listViewItem21,
            //listViewItem22,
            //listViewItem23});
            this.disabledstr.Location = new System.Drawing.Point(364, 24);
            this.disabledstr.Name = "disabledstr";
            this.disabledstr.Size = new System.Drawing.Size(292, 290);
            this.disabledstr.TabIndex = 7;
            this.disabledstr.UseCompatibleStateImageBehavior = false;
            this.disabledstr.View = System.Windows.Forms.View.Details;
            this.disabledstr.SelectedIndexChanged += new System.EventHandler(this.disabledstr_SelectedIndexChanged);
            this.disabledstr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.disabledstr_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 117;
            this.columnHeader2.Width = this.disabledstr.ClientSize.Width;

            /* TODO: this.columnHeader2.Width = this.disabledstr.ClientSize.Width; */
            // 
            // removeselected
            // 
            this.removeselected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeselected.Location = new System.Drawing.Point(283, 144);
            this.removeselected.Name = "removeselected";
            this.removeselected.Size = new System.Drawing.Size(75, 23);
            this.removeselected.TabIndex = 6;
            this.removeselected.Text = ">>";
            this.removeselected.UseVisualStyleBackColor = true;
            this.removeselected.Click += new System.EventHandler(this.removeselected_Click);
            // 
            // importfile
            // 
            this.importfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importfile.Location = new System.Drawing.Point(283, 114);
            this.importfile.Name = "importfile";
            this.importfile.Size = new System.Drawing.Size(75, 23);
            this.importfile.TabIndex = 5;
            this.importfile.Text = "Import";
            this.importfile.UseVisualStyleBackColor = true;
            // 
            // resetbutton
            // 
            this.resetbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetbutton.Location = new System.Drawing.Point(283, 84);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 4;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // deleteallbutton
            // 
            this.deleteallbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteallbutton.Location = new System.Drawing.Point(283, 54);
            this.deleteallbutton.Name = "deleteallbutton";
            this.deleteallbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteallbutton.TabIndex = 3;
            this.deleteallbutton.Text = "Delete All";
            this.deleteallbutton.UseVisualStyleBackColor = true;
            this.deleteallbutton.Click += new System.EventHandler(this.deleteallbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deletebutton.Location = new System.Drawing.Point(283, 24);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enabled:";
            // 
            // injstrlist
            // 
            this.injstrlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.injstrlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.injstrlist.Items.Add(listofinjections[listofinjections.Count-1],
                                        listofinjections[listofinjections.Count-2]);
            this.injstrlist.Location = new System.Drawing.Point(7, 24);
            this.injstrlist.MaximumSize = new System.Drawing.Size(300, 360);
            this.injstrlist.MinimumSize = new System.Drawing.Size(265, 290);
            this.injstrlist.Name = "injstrlist";
            this.injstrlist.Size = new System.Drawing.Size(265, 290);
            this.injstrlist.TabIndex = 0;
            this.injstrlist.UseCompatibleStateImageBehavior = false;
            this.injstrlist.View = System.Windows.Forms.View.Details;
            this.injstrlist.SelectedIndexChanged += new System.EventHandler(this.injstrlist_SelectedIndexChanged);
            this.injstrlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.injstrlist_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = this.injstrlist.ClientSize.Width;

            /* TODO: this.columnHeader1.Width = this.injstrlist.ClientSize.Width; */
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.groupBox2);
            this.Parameters.Controls.Add(this.groupBox1);
            this.Parameters.Location = new System.Drawing.Point(4, 22);
            this.Parameters.Name = "Parameters";
            this.Parameters.Padding = new System.Windows.Forms.Padding(3);
            this.Parameters.Size = new System.Drawing.Size(676, 395);
            this.Parameters.TabIndex = 1;
            this.Parameters.Text = "Settings";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tagvaluecheckBox1);
            this.groupBox1.Controls.Add(this.xmlschemacheckBox);
            this.groupBox1.Controls.Add(this.attributecheckbox);
            this.groupBox1.Controls.Add(this.tagcheckbox);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters for Fuzzing";
            // 
            // tagcheckbox
            // 
            this.tagcheckbox.AutoSize = true;
            this.tagcheckbox.Checked = true;
            this.tagcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tagcheckbox.Location = new System.Drawing.Point(7, 20);
            this.tagcheckbox.Name = "tagcheckbox";
            this.tagcheckbox.Size = new System.Drawing.Size(95, 17);
            this.tagcheckbox.TabIndex = 0;
            this.tagcheckbox.Text = "All Tag Names";
            this.tagcheckbox.UseVisualStyleBackColor = true;
            // 
            // attributecheckbox
            // 
            this.attributecheckbox.AutoSize = true;
            this.attributecheckbox.Checked = true;
            this.attributecheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.attributecheckbox.Location = new System.Drawing.Point(7, 44);
            this.attributecheckbox.Name = "attributecheckbox";
            this.attributecheckbox.Size = new System.Drawing.Size(84, 17);
            this.attributecheckbox.TabIndex = 1;
            this.attributecheckbox.Text = "All Attributes";
            this.attributecheckbox.UseVisualStyleBackColor = true;
            // 
            // xmlschemacheckBox
            // 
            this.xmlschemacheckBox.AutoSize = true;
            this.xmlschemacheckBox.Checked = true;
            this.xmlschemacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xmlschemacheckBox.Location = new System.Drawing.Point(7, 68);
            this.xmlschemacheckBox.Name = "xmlschemacheckBox";
            this.xmlschemacheckBox.Size = new System.Drawing.Size(90, 17);
            this.xmlschemacheckBox.TabIndex = 2;
            this.xmlschemacheckBox.Text = "XML Schema";
            this.xmlschemacheckBox.UseVisualStyleBackColor = true;
            // 
            // tagvaluecheckBox1
            // 
            this.tagvaluecheckBox1.AutoSize = true;
            this.tagvaluecheckBox1.Checked = true;
            this.tagvaluecheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tagvaluecheckBox1.Location = new System.Drawing.Point(7, 92);
            this.tagvaluecheckBox1.Name = "tagvaluecheckBox1";
            this.tagvaluecheckBox1.Size = new System.Drawing.Size(80, 17);
            this.tagvaluecheckBox1.TabIndex = 3;
            this.tagvaluecheckBox1.Text = "Tag Values";
            this.tagvaluecheckBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.xpathcheckbox);
            this.groupBox2.Controls.Add(this.sqlicheckBox);
            this.groupBox2.Location = new System.Drawing.Point(223, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class of Tests";
            // 
            // sqlicheckBox
            // 
            this.sqlicheckBox.AutoSize = true;
            this.sqlicheckBox.Checked = true;
            this.sqlicheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sqlicheckBox.Location = new System.Drawing.Point(7, 20);
            this.sqlicheckBox.Name = "sqlicheckBox";
            this.sqlicheckBox.Size = new System.Drawing.Size(90, 17);
            this.sqlicheckBox.TabIndex = 0;
            this.sqlicheckBox.Text = "SQL Injection";
            this.sqlicheckBox.UseVisualStyleBackColor = true;
            // 
            // xpathcheckbox
            // 
            this.xpathcheckbox.AutoSize = true;
            this.xpathcheckbox.Checked = true;
            this.xpathcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xpathcheckbox.Location = new System.Drawing.Point(7, 44);
            this.xpathcheckbox.Name = "xpathcheckbox";
            this.xpathcheckbox.Size = new System.Drawing.Size(98, 17);
            this.xpathcheckbox.TabIndex = 1;
            this.xpathcheckbox.Text = "XPath Injection";
            this.xpathcheckbox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "XSS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(7, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "XML Injection";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(770, 529);
            this.MinimumSize = new System.Drawing.Size(700, 459);
            this.Name = "Form2";
            this.Text = "Fuzzing Preferences";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.InjectStrings.ResumeLayout(false);
            this.InjectStrings.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InjectStrings;
        private System.Windows.Forms.TabPage Parameters;
        private System.Windows.Forms.Button addselected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView disabledstr;
        private System.Windows.Forms.Button removeselected;
        private System.Windows.Forms.Button importfile;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button deleteallbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.ListView injstrlist;
        private System.Windows.Forms.TextBox inputonestr;
        private System.Windows.Forms.Button add1strbutton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox xpathcheckbox;
        private System.Windows.Forms.CheckBox sqlicheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tagvaluecheckBox1;
        private System.Windows.Forms.CheckBox xmlschemacheckBox;
        private System.Windows.Forms.CheckBox attributecheckbox;
        private System.Windows.Forms.CheckBox tagcheckbox;

    }
}