namespace WindowsApplication1
{
    partial class FuzzForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuzzForm));
            this.reqresptabcontrol = new System.Windows.Forms.TabControl();
            this.requestab = new System.Windows.Forms.TabPage();
            this.resptab = new System.Windows.Forms.TabPage();
            this.fuzzerformgrid = new System.Windows.Forms.DataGridView();
            this.closebutton = new System.Windows.Forms.Button();
            this.exportbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reqtextbox = new System.Windows.Forms.TextBox();
            this.resptextbox = new System.Windows.Forms.TextBox();
            this.reqresptabcontrol.SuspendLayout();
            this.requestab.SuspendLayout();
            this.resptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuzzerformgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reqresptabcontrol
            // 
            this.reqresptabcontrol.Controls.Add(this.requestab);
            this.reqresptabcontrol.Controls.Add(this.resptab);
            this.reqresptabcontrol.Location = new System.Drawing.Point(12, 186);
            this.reqresptabcontrol.Name = "reqresptabcontrol";
            this.reqresptabcontrol.SelectedIndex = 0;
            this.reqresptabcontrol.Size = new System.Drawing.Size(708, 176);
            this.reqresptabcontrol.TabIndex = 0;
            // 
            // requestab
            // 
            this.requestab.Controls.Add(this.reqtextbox);
            this.requestab.Location = new System.Drawing.Point(4, 22);
            this.requestab.Name = "requestab";
            this.requestab.Padding = new System.Windows.Forms.Padding(3);
            this.requestab.Size = new System.Drawing.Size(700, 150);
            this.requestab.TabIndex = 0;
            this.requestab.Text = "Request";
            this.requestab.UseVisualStyleBackColor = true;
            // 
            // resptab
            // 
            this.resptab.Controls.Add(this.resptextbox);
            this.resptab.Location = new System.Drawing.Point(4, 22);
            this.resptab.Name = "resptab";
            this.resptab.Padding = new System.Windows.Forms.Padding(3);
            this.resptab.Size = new System.Drawing.Size(700, 150);
            this.resptab.TabIndex = 1;
            this.resptab.Text = "Response";
            this.resptab.UseVisualStyleBackColor = true;
            // 
            // fuzzerformgrid
            // 
            this.fuzzerformgrid.AllowUserToResizeRows = false;
            this.fuzzerformgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuzzerformgrid.Location = new System.Drawing.Point(12, 29);
            this.fuzzerformgrid.MultiSelect = false;
            this.fuzzerformgrid.Name = "fuzzerformgrid";
            this.fuzzerformgrid.ReadOnly = true;
            this.fuzzerformgrid.Size = new System.Drawing.Size(704, 151);
            this.fuzzerformgrid.TabIndex = 2;
            this.fuzzerformgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fuzzerformgrid_CellContentClick);
            this.fuzzerformgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fuzzerformgrid_CellContentClick);
            this.fuzzerformgrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fuzzerformgrid_CellContentClick);
            this.fuzzerformgrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fuzzerformgrid_CellContentClick);
            this.fuzzerformgrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fuzzerformgrid_CellContentClick);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(374, 367);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportbutton
            // 
            this.exportbutton.Location = new System.Drawing.Point(275, 367);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(75, 23);
            this.exportbutton.TabIndex = 4;
            this.exportbutton.Text = "Export";
            this.exportbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fuzzing Results:";
            // 
            // reqtextbox
            // 
            this.reqtextbox.Location = new System.Drawing.Point(4, 7);
            this.reqtextbox.Multiline = true;
            this.reqtextbox.Name = "reqtextbox";
            this.reqtextbox.Size = new System.Drawing.Size(690, 140);
            this.reqtextbox.TabIndex = 0;
            // 
            // resptextbox
            // 
            this.resptextbox.Location = new System.Drawing.Point(3, 7);
            this.resptextbox.Multiline = true;
            this.resptextbox.Name = "resptextbox";
            this.resptextbox.Size = new System.Drawing.Size(691, 137);
            this.resptextbox.TabIndex = 0;
            // 
            // FuzzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.fuzzerformgrid);
            this.Controls.Add(this.reqresptabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuzzForm";
            this.Text = "Fuzzing Output & Results";
            this.reqresptabcontrol.ResumeLayout(false);
            this.requestab.ResumeLayout(false);
            this.requestab.PerformLayout();
            this.resptab.ResumeLayout(false);
            this.resptab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuzzerformgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl reqresptabcontrol;
        private System.Windows.Forms.TabPage requestab;
        private System.Windows.Forms.TabPage resptab;
        private System.Windows.Forms.DataGridView fuzzerformgrid;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reqtextbox;
        private System.Windows.Forms.TextBox resptextbox;
    }
}