using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class FuzzForm : Form
    {
        //private List<KeyValuePair<int, List<string>>> fuzzdata = new List<KeyValuePair<int, List<string>>>();
        private List<KeyValuePair<int, List<string>>> fuzzdata = new List<KeyValuePair<int, List<string>>>();
        //private static DictionaryBindingList<int, List<string>> fuzzdatadbl = new DictionaryBindingList<int,List<string>>(fuzzdata);
        
        private BindingSource bs = null; 
        public FuzzForm()
        {
            InitializeComponent();
            
            bs = new System.Windows.Forms.BindingSource(fuzzdata,null);
            //bs = new System.Windows.Forms.BindingSource(fuzzdatadbl.ToBindingList(), null);
            //bs.DataSourceChanged += (s, ev) => System.Diagnostics.Debug.WriteLine("DataSourceChanged");
            this.fuzzerformgrid.DataSource = bs; 
            DataGridViewTextBoxColumn dgc1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgc2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgc3 = new DataGridViewTextBoxColumn();

            dgc1.Name = "Payload";
            dgc1.Width = 30; 
            dgc2.Name = "Request";
            dgc2.Width = 80;
            dgc3.Name = "Response";
            dgc3.Width = 80;

            this.fuzzerformgrid.Columns.Add(dgc1);
            this.fuzzerformgrid.Columns.Add(dgc2);
            this.fuzzerformgrid.Columns.Add(dgc3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        public void AddFuzzData(int key, System.Collections.Generic.List<string> strreqresp)
        {
            //fuzzdata[key] = strreqresp;
            //fuzzdatadbl[key] = new Pair<int,List<string>>(key,strreqresp);
            //fuzzdata.AddRange(new KeyValuePair<int,string>(key, strreqresp[0]);
            fuzzdata.Add(new KeyValuePair<int, List<string>>(key, strreqresp));

            //bs.Add(new KeyValuePair<int, List<string>>(key, strreqresp));
            bs.ResetBindings(true);
            //DataGridViewRow row = (DataGridViewRow)fuzzerformgrid.Rows[0].Clone();
            //row.Cells[1].Value = strreqresp[0];
            //row.Cells[2].Value = strreqresp[1];
            //row.Cells[3].Value = strreqresp[2];
            //this.fuzzerformgrid.Rows.Add(row);
        }
        public System.Collections.Generic.KeyValuePair<int, List<string>> GetFuzzData(int key)
        {
            return fuzzdata[key];
        }
        public void RefreshForm()
        {
            //this.fuzzerformgrid.DataSource = new System.Windows.Forms.BindingSource(fuzzdata.ToList(), null);
            this.fuzzerformgrid.Update();
            this.fuzzerformgrid.Refresh();
        }

        private void fuzzerformgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;
            try
            {
                reqtextbox.Text = fuzzdata[rownum].Value[1];
                reqtextbox.Visible = true;
                resptextbox.Text = fuzzdata[rownum].Value[2];
                resptextbox.Visible = true;
            }
            catch (System.ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("Error" + aore.Message);
                return;
            }
        }

        private void fuzzerformgrid_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //fuzzerformgrid_CellContentClick(sender, e);
        }
    }
}
