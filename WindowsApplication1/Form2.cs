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
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            // TODO: Complete member initialization
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void InjectStrings_Click(object sender, EventArgs e)
        {

        }

        private void injstrlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addselected_Click(object sender, EventArgs e)
        {
           foreach (ListViewItem str in this.disabledstr.SelectedItems) 
           {
               this.disabledstr.Items.Remove(str);
               this.injstrlist.Items.Add(str);   
           }
        }

        private void removeselected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem str in this.injstrlist.SelectedItems)
            {
                this.injstrlist.Items.Remove(str);
                this.disabledstr.Items.Add(str);
            }
        }


        private void disabledstr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem str in this.disabledstr.SelectedItems)
            {
                this.disabledstr.Items.Remove(str);
                this.injstrlist.Items.Add(str);
            }
        }

        private void injstrlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem str in this.injstrlist.SelectedItems)
            {
                this.injstrlist.Items.Remove(str);
                this.disabledstr.Items.Add(str);
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void add1strbutton1_Click_1(object sender, EventArgs e)
        {
            if (inputonestr.Text.Length > 0)
            {
                this.injstrlist.Items.Add(new ListViewItem(inputonestr.Text));
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {

        }

        private void deleteallbutton_Click(object sender, EventArgs e)
        {

        }

        private void disabledstr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<string> GetEnabledInjectionStrings()
        {
            List<string> list = injstrlist.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
            return list;
        }

    }
}
