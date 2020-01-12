using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Web.Services;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Text = "";
            XmlTextReader xmlr = null;
            System.Web.Services.Description.ServiceDescription servdesc = null;
            System.Web.Services.Description.PortTypeCollection ports = null;
            System.Web.Services.Description.OperationCollection ops = null;

            try
            {
                xmlr = new XmlTextReader(urltext.Text);
                xmlr.WhitespaceHandling = WhitespaceHandling.None;
                servdesc = System.Web.Services.Description.ServiceDescription.Read(xmlr);
                ports = servdesc.PortTypes;
                Logger.Text += " *** Found " + ports.Count + " portType(s) *** \r\n";
                for (int j = 0; j < ports.Count; j++)
                {
                    ops = ports[j].Operations;
                    Logger.Text += " --- Found "+ops.Count+" operation(s) in : "+(j+1)+" ---\r\n";
                    for (int i = 0; i < ops.Count; i++)
                    {
                        Logger.Text += ops[i].Name + "->" + "\r\n";
                        System.Web.Services.Description.OperationMessageCollection iter = ops[i].Messages;
                        //Message msgiter = null;
                        for (int k = 0; k < iter.Count; k++) { Logger.Text += iter[k].Message.Name + "\r\n"; }
                    }
                }
                /*
                while (xmlr.Read())
                {
                    switch (xmlr.NodeType)
                    {
                        case XmlNodeType.Element:
                            
                            Logger.Text += xmlr.Name + "->" + xmlr.R + "\r\n";
                            break;
                        case XmlNodeType.EndElement:
                            break;
                        default:
                            break;
                    }
                }
                 */
            }
            catch (XmlException xe)
            {
                Logger.Text += xe.ToString();
            }
            finally
            {
                if (xmlr != null)
                {
                    xmlr.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}