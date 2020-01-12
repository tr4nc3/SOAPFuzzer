using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Web.Services;
using System.Net;
using System.IO;
//using Microsoft.Web.Services2;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        /*public String[] enabledInjectionStrings;
        public String[] disabledInjectionStrings;*/

        static bool MyCertHandler(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            // Ignore errors
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //treeView1.Size = new System.Drawing.Size((int)(this.Size.Width * 0.48),this.Size.Height);
            //Logger.Size = new System.Drawing.Size((int)(this.Size.Width * 0.48),this.Size.Height);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlr = null;
            System.Web.Services.Description.ServiceDescription servdesc = null;
            System.Web.Services.Description.PortTypeCollection ports = null;
            System.Web.Services.Description.OperationCollection ops = null;
            System.Xml.Serialization.XmlSchemas schemas = null;

            Logger.Clear();
            
            /* Error handling */
            if (!urltext.Text.StartsWith("http"))
            {
                MessageBox.Show("Please enter a URL starting with http");
                return;
            }

            if (urltext.Text.IndexOf("://") == -1)
            {
                MessageBox.Show("Did you forget the protocol like http:// or https:// ?" +
                                "\r\n E.g., http://soap.amazon.com/schemas2/AmazonWebServices.wsdl");
                return;
            }
            /* End of Error Handling */

            /* Code to ignore certificates and protocols */
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            //ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback((s, ce, ch, ssl) => true);

            ServicePointManager.ServerCertificateValidationCallback = MyCertHandler;
            // Create a resolver with the necessary credentials.
            XmlUrlResolver resolver = new XmlUrlResolver();
            Logger.AppendText("Fetching the WSDL from " + urltext.Text+".\r\n");
            Uri wsdlurl = new Uri(urltext.Text); // There has got to be a URL
            NetworkCredential nc = null; // Use authentication if those options are present
            
            for (int i = 0; i < httpheaderlist.Items.Count; i++)
            {
                httpheaderlist.Items.RemoveAt(i);
            }
            
            try
            {
                if (uname.Text != "" && passwd.Text != "")
                {
                    if (uname.Text.IndexOf('\\') != -1)  //Domain creds provided
                    {
                        String[] creds = uname.Text.Split('\\');
                        nc = new NetworkCredential(creds[0], passwd.Text, creds[1]);
                        resolver.Credentials = nc;
                        // Get a Stream object containing the XML file.
                        
                        
                    }
                    else 
                    {
                        if (basicauthbutton.Checked) {
                            nc  = new NetworkCredential(uname.Text,passwd.Text);
                            CredentialCache credcache = new CredentialCache();
                            credcache.Add(new Uri(wsdlurl.Host), "Basic", nc);
                        }
                        else
                            if (ntlmauthbutton.Checked)
                            {
                                nc = new NetworkCredential(uname.Text, passwd.Text);
                                CredentialCache credcache = new CredentialCache();
                                credcache.Add(new Uri(wsdlurl.Host), "NTLM", nc);
                            }
                    }
                }
                else
                {
                    if (uname.Text == null && passwd.Text != "")
                    { 
                        Logger.AppendText("***ERROR*** Please enter a password ");
                        return;
                    }
                }

                if (xmlr == null)
                {
                    //Stream s = (Stream)resolver.GetEntity(wsdlurl, null, typeof(Stream));
                    // Construct a reader using the Stream object.
                    //xmlr = new XmlTextReader(s);
                    xmlr = new XmlTextReader(urltext.Text);
                
                    //Logger.AppendText(xmlr.);
                    xmlr.WhitespaceHandling = WhitespaceHandling.None;
                    servdesc = System.Web.Services.Description.ServiceDescription.Read(xmlr);
                    schemas = servdesc.Types.Schemas;
                    Logger.Text += "=== Found " + schemas.Count + " schema(s)===\r\n";
                }
                for (int k = 0; k < schemas.Count; k++)
                {
                    XmlSchemaObjectCollection xmlelem = schemas[k].Items;
                    XmlSchemaObjectEnumerator enumerator = xmlelem.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        if (enumerator.Current is XmlSchemaElement)
                        {
                            XmlSchemaElement xse = (XmlSchemaElement)enumerator.Current;
                            Logger.Text += xse.Name + '=' + xse.SchemaType + ", ";
                            TraverseParticle(xse);
                        }
                        else
                        {
                            if (enumerator.Current is XmlSchemaComplexType)
                            {
                                XmlSchemaComplexType xsct = (XmlSchemaComplexType)enumerator.Current;
                                Logger.Text += '\'' + xsct.Name + ": ";
                                TraverseParticle(xsct.Particle);
                                if (xsct.ContentModel is XmlSchemaSimpleContent)
                                {
                                    Logger.Text += "Simple; ";
                                }
                                else
                                {
                                    //XmlSchemaComplexContent complexContent = (XmlSchemaComplexContent)xsct.ContentModel;
                                    if (xsct.ContentModel is XmlSchemaComplexContent)
                                    {
                                        Logger.Text += "Complex; ";
                                    }
                                }
                                Logger.Text += "\',";
                            }
                        }
                    }
                    Logger.Text += "\r\n";
                }

                ports = servdesc.PortTypes;
                Logger.Text += " *** Found " + ports.Count + " portType(s) *** \r\n";
                TreeNode tn = null;
                TreeNode msgNode = null;
                TreeNode root = new TreeNode(urltext.Text);
                treeView1.Nodes.Add(root);
                for (int j = 0; j < ports.Count; j++)
                {
                    ops = ports[j].Operations;
                    Logger.Text += " --- Found " + ops.Count + " operation(s) in : " + (j + 1) + " ---\r\n";
                    for (int i = 0; i < ops.Count; i++)
                    {
                        Logger.Text += ops[i].Name + "->" + "\r\n";
                        tn = new TreeNode(ops[i].Name);
                        root.Nodes.Add(tn);
                        System.Web.Services.Description.OperationMessageCollection iter = ops[i].Messages;
                        //Message msgiter = null;
                        for (int k = 0; k < iter.Count; k++)
                        {
                            Logger.Text += iter[k].Message.Name + "\r\n";
                            msgNode = new TreeNode(iter[k].Message.Name);
                            tn.Nodes.Add(msgNode);
                        }
                    }
                }
                GenerateSOAP();
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
                Logger.AppendText(xe.StackTrace);
            }
            catch (InvalidOperationException ioe)
            {
                Logger.AppendText(ioe.StackTrace);
            }
            catch (Exception ex)
            {
                Logger.Text += ex.StackTrace;
            }
            finally
            {
                if (xmlr != null)
                {
                    xmlr.Close();
                }
            }
        }
        private void TraverseParticle(object particle)
        {
            if (particle is XmlSchemaElement)
            {
                XmlSchemaElement elem = particle as XmlSchemaElement;
                //Logger.Text += elem.Name + '=' + elem.SchemaTypeName + ' ';
                Logger.Text += elem.Name + '=' + elem.SchemaTypeName.Name+ ' ';
                
                if (elem.RefName.IsEmpty)
                {
                    XmlSchemaType type = (XmlSchemaType)elem.ElementSchemaType;
                    XmlSchemaComplexType complexType = type as XmlSchemaComplexType;
                    if (complexType != null && complexType.Name == null)
                    {
                        TraverseParticle(complexType.ContentTypeParticle);
                    }
                }
            }
            else if (particle is XmlSchemaGroupBase)
            {   //xs:all, xs:choice, xs:sequence
                XmlSchemaGroupBase baseParticle = particle as XmlSchemaGroupBase;
                foreach (XmlSchemaParticle subParticle in baseParticle.Items)
                    TraverseParticle(subParticle);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Logger_TextChanged(object sender, EventArgs e)
        {
            Logger.SelectionStart = Logger.Text.Length;
            Logger.ScrollToCaret();
            Logger.Refresh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Text.StartsWith("http"))
            TreeNode trav = null;
            trav = e.Node;
            while (!trav.Text.StartsWith("http"))
                trav = trav.Parent;
            //portlist.Nodes.Clear();
            httpheaderlist.Items.Clear();
            responsebox.Text = "";
            request.Text = GenerateSOAP(e.Node.Text,trav.Text);
        }

        private void populateTree()
        {

        }
        private string GenerateSOAP()
        {
            XmlTextReader xmlr = null;
            try
            {
                xmlr = new XmlTextReader(urltext.Text);
            }
            catch (XmlException xe)
            {
                Logger.Text += xe.ToString();
            }
            System.Web.Services.Description.ServiceDescription servdesc = null;
            servdesc = System.Web.Services.Description.ServiceDescription.Read(xmlr);
            System.Web.Services.Description.ServiceCollection serviceColl = servdesc.Services;
            string returnurl = null;
            Logger.Text += "\r\n **** Service(s) Found : " + serviceColl.Count +" ****\r\n";
            //string returnurl = null;
            //How to select from more than one WSDL Ports???
            TreeNode root = null;
            TreeNode porttn = null;
            for (int i = 0; i < serviceColl.Count; i++)
            {
                //Logger.Text += "For service : " + serviceColl[i].Name + " " + serviceColl[i].Ports.Count + " port(s) discovered: --> ";
                root = new TreeNode(serviceColl[i].Name);
                portlist.Nodes.Add(root);
                for (int j = 0; j < serviceColl[i].Ports.Count; j++)
                {
                    //Logger.Text += serviceColl[i].Ports[j].Name + ", ";
                    //if (serviceColl[i].Ports[j].Name == stringNodeName)
                    //{
                    //int j = 0; // temp
                    //serviceno = i;
                    //portno = j;
                    //}
                    porttn = new TreeNode(serviceColl[i].Ports[j].Name);
                    root.Nodes.Add(porttn);
                }
            }
            portlist.SelectedNode = portlist.Nodes[0];

            for (int i = 0; i < serviceColl.Count; i++)
            {
                Logger.Text += "For service : " + serviceColl[i].Name + " "+ serviceColl[i].Ports.Count +" port(s) discovered: --> ";
                for (int j = 0; j < serviceColl[i].Ports.Count; j++)
                {
                    Logger.Text += serviceColl[i].Ports[j].Name + ", ";
                    for (int k = 0; k < serviceColl[i].Ports[j].Extensions.Count; k++)
                    {
                        System.Web.Services.Description.Binding basebinding = serviceColl[i].Ports[j].Extensions[k] as System.Web.Services.Description.Binding;
                        System.Web.Services.Description.SoapAddressBinding sab = serviceColl[i].Ports[j].Extensions[k] as System.Web.Services.Description.SoapAddressBinding;
                        System.Web.Services.Description.Soap12AddressBinding s12ab = serviceColl[i].Ports[j].Extensions[k] as System.Web.Services.Description.Soap12AddressBinding;
                        System.Web.Services.Description.HttpAddressBinding hab = serviceColl[i].Ports[j].Extensions[k] as System.Web.Services.Description.HttpAddressBinding;
                        if (sab != null)
                        {
                            returnurl = sab.Location;
                            Logger.Text += returnurl;
                            targeturl.Text = returnurl;
                        }
                        else if (s12ab != null)
                        {
                            returnurl = s12ab.Location;
                            Logger.Text += returnurl;
                            targeturl.Text = returnurl;
                        }
                        else
                        {
                            returnurl = hab.Location;
                            Logger.Text += returnurl;
                            targeturl.Text = returnurl;
                        }
                    }
                }
                Logger.Text += "\r\n";
            }
            return returnurl;
        }
        private string Encapsulate(string preamble,string header, string xmldata)
        {
            string enveloped = 
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>"+
            "<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" "+
            "xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" "+
            "xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" "+preamble+" >"+
            "<soap:Header>"+header+"</soap:Header><soap:Body>";
            enveloped += xmldata;
            enveloped += "</soap:Body></soap:Envelope>";
            return enveloped;
        }
        private string SchemaSearching(XmlSchema xmlSchema, string inputParamType)
        {
            string returnval = null;
            XmlGenerator xmlGen = new XmlGenerator();
            foreach (object item in xmlSchema.Items)
            {
                System.Xml.Schema.XmlSchemaElement schemaElement = item as System.Xml.Schema.XmlSchemaElement;
                if (schemaElement != null)
                {
                    if (schemaElement.Name == inputParamType)
                    {
                        returnval = xmlGen.GenerateXmlString(schemaElement, xmlSchema);
                        break;//The parameter was found no need to go through rest of elements
                    }
                }
                else
                { //This is a complex Type
                    System.Xml.Schema.XmlSchemaComplexType complexType = item as System.Xml.Schema.XmlSchemaComplexType;
                    if (complexType != null)
                    {
                        if (complexType.Name == inputParamType)
                        {
                            Logger.Text += "Complex Type Name : " + complexType.Name + "\r\n";
                            System.Xml.Schema.XmlSchemaParticle particle = complexType.Particle;
                            System.Xml.Schema.XmlSchemaSequence sequence = particle as System.Xml.Schema.XmlSchemaSequence;
                            System.Xml.Schema.XmlSchemaAll schemaall = particle as System.Xml.Schema.XmlSchemaAll;
                            if (sequence != null)
                            {
                                foreach (System.Xml.Schema.XmlSchemaElement childElement in sequence.Items)
                                {
                                    string parameterName = childElement.Name;
                                    string parameterType = childElement.SchemaTypeName.Name;
                                    returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(childElement, xmlSchema) + "</" + complexType.Name + '>';
                                }
                            }
                            else
                            {
                                if (schemaall != null)
                                {
                                    returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(schemaall, xmlSchema) + "</" + complexType.Name + '>';
                                }
                                else
                                {
                                    System.Xml.Schema.XmlSchemaComplexContent cmplxContent = null;
                                    if (cmplxContent != null)
                                    {
                                        returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(cmplxContent, xmlSchema) + "</" + complexType.Name + '>'; ;
                                    }
                                }
                            }
                            break;  //The parameter was found no need to go through rest of elements
                        }
                    }
                    else
                    {   //Nothing to do?
                        //System.Xml.Schema.XmlSchemaSimpleType simpleType = item as System.Xml.Schema.XmlSchemaSimpleType;
                    }
                }
            }
            return returnval;
        }
        private string GenerateSOAP(string stringNodeName,string url)
        {
            XmlTextReader xmlr = null;
            string returnval = null;
            string headerval = null;
            int indexOfOp = -1;
            int indexOfPort = -1;
            System.Web.Services.Description.ServiceDescription servdesc = null;
            System.Xml.Serialization.XmlSchemas schemas = null;
            XmlGenerator xmlGen = new XmlGenerator();
            try
            {
                //xmlr = new XmlTextReader(urltext.Text);
                xmlr = new XmlTextReader(url);
                xmlr.WhitespaceHandling = WhitespaceHandling.None;
                servdesc = System.Web.Services.Description.ServiceDescription.Read(xmlr);
                schemas = servdesc.Types.Schemas;
                //Find operation matching the selected row
                for (int i = 0; i < servdesc.PortTypes.Count && indexOfPort== -1 && indexOfOp == -1 ; i++)
                {
                    for (int j = 0; j < servdesc.PortTypes[i].Operations.Count && indexOfPort == -1 && indexOfOp == -1; j++)
                    {
                        if (servdesc.PortTypes[i].Operations[j].Name == stringNodeName)
                        {
                            indexOfOp = j;
                            indexOfPort = i;
                        }
                    }
                }
                System.Web.Services.Description.Operation SelectedOp = null;
                
                if (indexOfPort != -1 && indexOfOp != -1)
                {
                    SelectedOp = servdesc.PortTypes[indexOfPort].Operations[indexOfOp];
                }
                else
                {
                    Logger.Text += " Element not found in selected Operations \r\n";
                    return ""; 
                }
                //Get the URL for the particular method
                int serviceno = -1;
                int portno = -1;
                //int extno = -1;
                string urltosend = null;
                System.Web.Services.Description.Port SelectedPort = null;
                System.Web.Services.Description.ServiceCollection serviceColl = servdesc.Services;
                Logger.Text += "\r\nSelected port index: "+ portlist.SelectedNode.Index + "\r\n";
                bool found = false; 
                for (int i = 0; i < serviceColl.Count && !found; i++)
                {
                    for (int j = 0; j < serviceColl[i].Ports.Count && !found; j++)
                    {
                        if (serviceColl[i].Ports[j].Name == portlist.SelectedNode.Text)
                        {
                            found = true;
                            serviceno = i;
                            portno = j;
                        }
                    }
                }
                if (serviceno != -1 && portno != -1)
                {
                    SelectedPort = serviceColl[serviceno].Ports[portno];

                    for (int k = 0; k < SelectedPort.Extensions.Count; k++)
                    {
                        System.Web.Services.Description.Binding basebinding = SelectedPort.Extensions[k] as System.Web.Services.Description.Binding;
                        System.Web.Services.Description.SoapAddressBinding sab = SelectedPort.Extensions[k] as System.Web.Services.Description.SoapAddressBinding;
                        System.Web.Services.Description.Soap12AddressBinding s12ab = SelectedPort.Extensions[k] as System.Web.Services.Description.Soap12AddressBinding;
                        System.Web.Services.Description.HttpAddressBinding hab = SelectedPort.Extensions[k] as System.Web.Services.Description.HttpAddressBinding;
                        if (sab != null)
                        {
                            urltosend = sab.Location;
                            //Logger.Text += urltosend;
                        }
                        else if (s12ab != null)
                        {
                            urltosend = s12ab.Location;
                            //Logger.Text += urltosend;
                        }
                        else
                        {
                            urltosend = hab.Location;
                            //Logger.Text += urltosend;
                        }
                    }
                    int bindingno = -1;
                    int opno = -1;
                    found = false;
                    for (int i = 0; i < servdesc.Bindings.Count && !found; i++)
                    {
                        for (int j = 0; j < servdesc.Bindings[i].Operations.Count && !found ; j++)
                        {
                            if (servdesc.Bindings[i].Operations[j].Name == stringNodeName)
                            {
                                bindingno = i;
                                opno = j;
                                found=true;
                            }
                        }
                    }
                    
                    if (bindingno != -1 && opno != -1)
                    {
                        for (int k = 0; k < servdesc.Bindings[bindingno].Operations[opno].Extensions.Count; k++)
                        {
                            System.Web.Services.Description.Binding basebinding = servdesc.Bindings[bindingno].Operations[opno].Extensions[k] as System.Web.Services.Description.Binding;
                            System.Web.Services.Description.SoapOperationBinding sob = servdesc.Bindings[bindingno].Operations[opno].Extensions[k] as System.Web.Services.Description.SoapOperationBinding;
                            System.Web.Services.Description.Soap12OperationBinding s12ob = servdesc.Bindings[bindingno].Operations[opno].Extensions[k] as System.Web.Services.Description.Soap12OperationBinding;
                            System.Web.Services.Description.HttpOperationBinding hob = servdesc.Bindings[bindingno].Operations[opno].Extensions[k] as System.Web.Services.Description.HttpOperationBinding;
                            if (sob != null)
                            {
                                //urltosend += sob.SoapAction;
                                ListViewItem item = new ListViewItem();
                                item.Text = "SoapAction: \"" + sob.SoapAction+"\"";
                                httpheaderlist.Items.Add(item);
                                for (int index = 0; index < servdesc.Bindings[bindingno].Operations[opno].Input.Extensions.Count; index++)
                                {
                                    System.Web.Services.Description.SoapHeaderBinding shb = servdesc.Bindings[bindingno].Operations[opno].Input.Extensions[index] as System.Web.Services.Description.SoapHeaderBinding;
                                    if (shb != null)
                                    { //SoapHeader is defined
                                                //returnval += SchemaSearching(servdesc.Types.Schemas[0], shb.Message.Name);
                                        Logger.Text += "Name of header " + shb.Message.Name + "\r\n";
                                        string headerType;
                                        //returnval += SchemaSearching(servdesc.Types.Schemas[0], servdesc.Messages[shb.Message.Name].Parts[0].Element.Name);
                                        if (servdesc.Messages[shb.Message.Name].Parts[0].Type.IsEmpty)
                                        {
                                            headerType = servdesc.Messages[shb.Message.Name].Parts[0].Element.Name;
                                            headerval += SchemaSearching(servdesc.Types.Schemas[0], headerType);
                                        }
                                        else
                                        {   //Currently takes care of only one part in each message
                                            if (shb.Message.Name != null)
                                            {
                                                headerval += '<' + shb.Message.Name + '>';
                                                for (int i = 0; i < servdesc.Messages[shb.Message.Name].Parts.Count; i++)
                                                {
                                                    headerType = servdesc.Messages[shb.Message.Name].Parts[i].Type.Name;
                                                    headerval += '<' + servdesc.Messages[shb.Message.Name].Parts[i].Name + '>';
                                                    headerval += SchemaSearching(servdesc.Types.Schemas[0], headerType);
                                                    headerval += "</" + servdesc.Messages[shb.Message.Name].Parts[i].Name + ">";
                                                }
                                                headerval += "</" + shb.Message.Name + '>';
                                            }
                                        }
                                    }
                                }
                                break;
                                //Logger.Text += urltosend;
                            }
                            else if (s12ob != null)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = "SoapAction: \"" + sob.SoapAction+"\"";
                                httpheaderlist.Items.Add(item);
                                for (int index = 0; index < servdesc.Bindings[bindingno].Operations[opno].Input.Extensions.Count; index++)
                                {
                                    System.Web.Services.Description.Soap12HeaderBinding s12hb = servdesc.Bindings[bindingno].Operations[opno].Input.Extensions[index] as System.Web.Services.Description.Soap12HeaderBinding;
                                    if (s12hb != null)
                                    { //SoapHeader is defined
                                        //returnval += SchemaSearching(servdesc.Types.Schemas[0], shb.Message.Name);
                                        Logger.Text += "Name of header " + s12hb.Message.Name + "\r\n";
                                        string headerType;
                                        //returnval += SchemaSearching(servdesc.Types.Schemas[0], servdesc.Messages[shb.Message.Name].Parts[0].Element.Name);
                                        if (servdesc.Messages[s12hb.Message.Name].Parts[0].Type.IsEmpty)
                                        {
                                            headerType = servdesc.Messages[s12hb.Message.Name].Parts[0].Element.Name;
                                            headerval += SchemaSearching(servdesc.Types.Schemas[0], headerType);
                                        }
                                        else
                                        {   //Currently takes care of only one part in each message
                                            if (s12hb.Message.Name != null)
                                            {
                                                headerval += '<' + s12hb.Message.Name + '>';
                                                for (int i = 0; i < servdesc.Messages[s12hb.Message.Name].Parts.Count; i++)
                                                {
                                                    headerType = servdesc.Messages[s12hb.Message.Name].Parts[i].Type.Name;
                                                    headerval += '<' + servdesc.Messages[s12hb.Message.Name].Parts[i].Name + '>';
                                                    headerval += SchemaSearching(servdesc.Types.Schemas[0], headerType);
                                                    headerval += "</" + servdesc.Messages[s12hb.Message.Name].Parts[i].Name + ">";
                                                }
                                                headerval += "</" + s12hb.Message.Name + '>';
                                            }
                                        }
                                    }
                                }
                                urltosend += s12ob.SoapAction;
                                break;
                                //Logger.Text += urltosend;
                            }
                            else if (hob != null)
                            {
                                urltosend += hob.Location;
                                break;
                                //Logger.Text += urltosend;
                            }
                        }
                    }
                    //Find the right binding
                    Logger.Text += urltosend;
                    Logger.Text += "\r\n";
                    targeturl.Text = urltosend;
                }
                //Path to XML schema definition from Operation Name
                //portType -> Operation:Name -> input:message
                // input:message == Message:Name
                //Message:Name -> Part:element
                //Types -> Schema -> Element:Name
                //Part:Element == Element:Name
                Logger.Text += " searching for " + stringNodeName + "\r\n";
                //Logger.Text += " ****** " + SelectedOp.Messages.Count + " ****** ";
                
                /*for (int i = 0; i < SelectedOp.PortType.Operations.Count; i++)
                {
                    for (int j = 0; j < SelectedOp.PortType.Operations[i].Messages.Count; j++)//  +", ";
                    {
                        Logger.Text += SelectedOp.PortType.Operations[i].Messages[j].GetType() + " == ";
                        Logger.Text += SelectedOp.PortType.Operations[i].Messages[j].Name + "\r\n";
                    }
                }*/
                string inputParameterType = null;
                string inputMessageType = SelectedOp.Messages.Input.Message.Name;
                // TODO: What if there are more than one service descriptions?
                System.Xml.Schema.XmlSchema xmlSchema = servdesc.Types.Schemas[0];
                //What if there are more than one Parts
                if (servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[0].Type.IsEmpty)
                {
                    inputParameterType = servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[0].Element.Name;
                    returnval += SchemaSearching(xmlSchema, inputParameterType);
                }
                else
                {   //Currently takes care of only one part in each message
                    if (SelectedOp.Messages.Input.Message.Name != null)
                    {
                        returnval += '<' + SelectedOp.Messages.Input.Message.Name + '>';
                        for (int i = 0; i < servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts.Count; i++)
                        {
                            inputParameterType = servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[i].Type.Name;
                            returnval += '<' + servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[i].Name + '>';
                            returnval += SchemaSearching(xmlSchema, inputParameterType);
                            returnval += "</" + servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[i].Name + ">";
                        }
                        returnval += "</" + SelectedOp.Messages.Input.Message.Name + '>';
                    }
                }
                Logger.Text += "Selected the method : " + inputMessageType + " that needs " + inputParameterType + " as the param\r\n";
                //Logger.Text += servdesc.Messages[SelectedOp.Messages.Input.Message.Name].Parts[0].Type.Name + " as the param\r\n" ;
                //Logger.Text += "\r\n";
                /*
                System.Xml.Schema.XmlSchema xmlSchema = servdesc.Types.Schemas[0];
                
                foreach (object item in xmlSchema.Items)
                {
                    
                    System.Xml.Schema.XmlSchemaElement schemaElement = item as System.Xml.Schema.XmlSchemaElement;
                    //Logger.Text += "Ref name = " + schemaElement.RefName + "\r\n";
                    //Logger.Text += " -------- " + item.GetType() + "\r\n";
                    if (schemaElement != null)
                    {
                        //Logger.Text += "Ref name = " + schemaElement.RefName + "\r\n";
                        if (schemaElement.Name == inputParameterType)
                        {
                            Logger.Text += "\r\n1. ******************\r\n";
                            returnval = xmlGen.GenerateXmlString(schemaElement, xmlSchema);
                            Logger.Text += returnval+"\r\n";
                            Logger.Text += "\r\n******************\r\n";*/
                            /*Logger.Text += "Schema Element Name : " + schemaElement.Name + "\r\n" ;
                            System.Xml.Schema.XmlSchemaType schemaType = schemaElement.SchemaType;
                            Logger.Text += "Type of " + schemaElement.Name + " is " + schemaElement.SchemaTypeName + "\r\n";
                            System.Xml.Schema.XmlSchemaComplexType complexType = schemaType as System.Xml.Schema.XmlSchemaComplexType;
                            if (complexType != null)
                            {
                                System.Xml.Schema.XmlSchemaParticle particle = complexType.Particle;
                                Logger.Text += "Annot  : " + particle.Annotation + "\r\n" ;
                                if (particle != null)
                                {    //TraverseParticle(complexType.Particle);
                                    Logger.Text += '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(complexType.Particle) + "</" + complexType.Name + '>'; 
                                }
                            }
                            else
                            {
                                //If it's not a Complex Type element
                                System.Xml.Schema.XmlSchemaSimpleType simpleType = schemaType as System.Xml.Schema.XmlSchemaSimpleType;
                                //simpleType.
                            }*//*
                        }
                    }
                    else
                    { //This is a complex Type
                        System.Xml.Schema.XmlSchemaComplexType complexType = item as System.Xml.Schema.XmlSchemaComplexType;
                        if (complexType != null)
                        {
                            //Logger.Text += "Name : " + complexType.Name + "\r\n" ;
                            if (complexType.Name == inputParameterType)
                            {
                                Logger.Text += "Complex Type Name : " + complexType.Name + "\r\n";
                                System.Xml.Schema.XmlSchemaParticle particle = complexType.Particle;
                                System.Xml.Schema.XmlSchemaSequence sequence = particle as System.Xml.Schema.XmlSchemaSequence;
                                System.Xml.Schema.XmlSchemaAll schemaall = particle as System.Xml.Schema.XmlSchemaAll;
                                if (sequence != null)
                                {
                                    foreach (System.Xml.Schema.XmlSchemaElement childElement in sequence.Items)
                                    {
                                        string parameterName = childElement.Name;
                                        string parameterType = childElement.SchemaTypeName.Name;
                                        Logger.Text += parameterName + " is a " + parameterType;
                                        Logger.Text += "\r\n2. ************************************\r\n";
                                        returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(childElement, xmlSchema) + "</" + complexType.Name + '>';
                                        Logger.Text += returnval;
                                        Logger.Text += "\r\n************************************\r\n";
                                    }
                                }
                                else
                                {
                                    if (schemaall != null)
                                    {
                                        Logger.Text += "\r\n3. ************************************\r\n";
                                        returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(schemaall, xmlSchema) + "</" + complexType.Name + '>';
                                        Logger.Text += returnval;
                                        Logger.Text += "\r\n************************************\r\n";
                                        //TraverseParticle(schemaall);
                                    }
                                    else
                                    {
                                        System.Xml.Schema.XmlSchemaComplexContent cmplxContent = null;

                                        if (cmplxContent != null)
                                        {
                                            Logger.Text += cmplxContent.GetType();
                                            Logger.Text += "\r\n4. ************************************\r\n";
                                            returnval = '<' + complexType.Name + '>' + xmlGen.GenerateXmlString(cmplxContent, xmlSchema) + "</" + complexType.Name + '>'; ;
                                            Logger.Text += returnval;
                                            Logger.Text += "\r\n************************************\r\n";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        { 
                            System.Xml.Schema.XmlSchemaSimpleType simpleType = item as System.Xml.Schema.XmlSchemaSimpleType;

                        }
                    }
                }*/
                returnval = Encapsulate("xmlns=\""+servdesc.TargetNamespace+"\"",headerval,returnval);
                return returnval;
                /*
                for (int k = 0; k < schemas.Count; k++)
                {
                    XmlSchemaObjectCollection xmlelem = schemas[k].Items;
                    XmlSchemaObjectEnumerator enumerator = xmlelem.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        Logger.Text += " Type of " +enumerator.Current.GetType() + "\r\n" ;
                        
                        if (enumerator.Current is XmlSchemaElement)
                        {
                            XmlSchemaElement xse = (XmlSchemaElement)enumerator.Current;
                            Logger.Text += xse.Name + '=' + xse.SchemaType + ", ";
                            //if 
                            TraverseParticle(xse);
                        }
                        else
                        {
                            if (enumerator.Current is XmlSchemaComplexType)
                            {
                                XmlSchemaComplexType xsct = (XmlSchemaComplexType)enumerator.Current;
                                Logger.Text += '\'' + xsct.Name + ": ";
                                TraverseParticle(xsct.Particle);
                                if (xsct.ContentModel is XmlSchemaSimpleContent)
                                {
                                    Logger.Text += "Simple; ";
                                }
                                else
                                {
                                    //XmlSchemaComplexContent complexContent = (XmlSchemaComplexContent)xsct.ContentModel;
                                    if (xsct.ContentModel is XmlSchemaComplexContent)
                                    {
                                        Logger.Text += "Complex; ";
                                    }
                                }
                                Logger.Text += "\',";
                            }
                        }
                    }
                    Logger.Text += "\r\n";
                }*/
                //Path to URL from Operation Name
                // Operation ^ Binding:Name
                //Service -> Port:Binding
                // Binding:Name == Port:Binding
                // Port:Name -> (Soapaddressbinding/HttpAddressBinding/Soap12AddressBinding).Location
                
            }
            catch (XmlException xe)
            {
                Logger.Text += xe.ToString();
            }
            returnval = Encapsulate("xmlns=\"" + servdesc.TargetNamespace + "\"", headerval, returnval);
            return returnval;
        }




        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            certfname.Text = OpenCert.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCert.ShowDialog();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            WebProxy myProxy = null; 

            byte[] data = encoding.GetBytes(request.Text.ToCharArray());
            //System.Net.ServicePointManager.Expect100Continue = false;
            // Prepare web request...
            HttpWebRequest myRequest =
              (HttpWebRequest)HttpWebRequest.Create(targeturl.Text);
            myRequest.ServicePoint.Expect100Continue = false;
            string[] headers = null; 
            if ( (headers = addheaders.Lines ) != null)
            {
                for (int i = 0; i < headers.Length; i++)
                {
                    //myRequest.Headers.Add(headers[i]);
                    //char[] delims = { ':' };
                    string[] headersplit = System.Text.RegularExpressions.Regex.Split(headers[i], ":");
                    string headercat = "";
                    for (int j = 1; j < headersplit.Length; j++)
                    {
                        headercat += headersplit[j];
                        if (j < headersplit.Length - 1)
                            headercat += ":";
                    }
                    myRequest.Headers[headersplit[0]] = headercat;
                    //myRequest.Headers[headers[i].Split(delims, StringSplitOptions.RemoveEmptyEntries)[0]] = 
                    //    headers[i].Split(delims, StringSplitOptions.RemoveEmptyEntries)[1];
                }
            }
            if (myRequest.Proxy != null) 
                Logger.Text += "Proxy being used is: " + myRequest.Proxy.ToString()+"\n";
            /*
            IWebProxy proxy = myRequest.Proxy; //Get default proxy
            //Auto populate the fields
            if (proxy != null)
            {
                proxychk.Checked = true;

            }
            */
            if (proxychk.Checked == true)
            {   //Add code to process proxy
                myProxy = new WebProxy(proxyserverurl.Text, false);
                if (proxyAuthChk.Checked)
                {  //Add code to include proxy creds
                    myProxy.Credentials = new NetworkCredential(proxyuname.Text, proxypasswd.Text);
                }
                /*if (proxyserverurl.Text != null)
                {
                    myProxy.Address = new Uri(proxyserverurl.Text);
                }
                else
                {
                    MessageBox.Show("Enter a proxy URL or uncheck Proxy checkbox");
                }*/
                myRequest.Proxy = myProxy;
            }
            
            if (PostRadio.Checked)
            {
                myRequest.Method = "POST";
            }
            else
            {
                myRequest.Method = "GET";
            }
            
            foreach (ListViewItem i in httpheaderlist.Items)
            {
                myRequest.Headers.Add(i.Text);
            }
            myRequest.ContentType = "text/xml";// charset=\"utf-8\"";
            //myRequest.ContentLength = request.Text.Length;
            myRequest.ContentLength = data.Length;
            System.IO.Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            
            Logger.Text += "\r\n**** Request *****\r\n";
            Logger.Text += myRequest.Headers.ToString();
            Logger.Text += request.Text;
            HttpWebResponse loWebResponse = null;
            StreamReader loResponseStream = null;
            string lcHtml = null;
            try 
            {
                newStream.Write(data, 0, data.Length);
                loWebResponse = (HttpWebResponse)myRequest.GetResponse();
                loResponseStream = new System.IO.StreamReader(loWebResponse.GetResponseStream(), Encoding.UTF8);
                /*Stream streamResponse = loWebResponse.GetResponseStream();
                StreamReader streamRead = new StreamReader(streamResponse);
                Char[] readBuff = new Char[256];
                int count = streamRead.Read(readBuff, 0, 256);
                Console.WriteLine("\nThe contents of Html Page are :  \n");
                while (count > 0)
                {
                    String outputData = new String(readBuff, 0, count);
                    Logger.Text += outputData;
                    responsebox.Text 
                    count = streamRead.Read(readBuff, 0, 256);
                }
                // Close the Stream object.
                streamResponse.Close();
                streamRead.Close();*/
                // Release the HttpWebResponse Resource.

                lcHtml = loResponseStream.ReadToEnd();
                responsebox.Text = lcHtml;
                Logger.Text += "\r\nHeaders: \r\n" + loWebResponse.Headers;
                loWebResponse.Close();
                loResponseStream.Close();
            }
            catch (System.Net.WebException we)
            {
                Logger.Text += "\r\n**** Exception occurred: System.Net.WebException ****\r\n";  
                Logger.Text += "HTTP Status Code: " + we.Message + " : " + we.Response;   
            }
            newStream.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void proxyAuthChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void portlist_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void fuzz_Click(object sender, EventArgs e)
        {
            FuzzForm fuzzform = new FuzzForm();
            fuzzform.Owner = this;
            fuzzform.Show();
            
            UTF8Encoding encoding = new UTF8Encoding();
            WebProxy myProxy = null;
            System.IO.Stream newStream = null; 

            //byte[] data = encoding.GetBytes(request.Text.ToCharArray());
            //System.Net.ServicePointManager.Expect100Continue = false;
            // Prepare web request...
            
            // Send the data.
            HttpWebResponse loWebResponse = null;
            StreamReader loResponseStream = null;
            //StreamReader loReqStream = null;

            string lcHtml = null;

            
            string[] listofsplits = request.Text.Split((char)632);
            int countfuzzpoints = listofsplits.Length - 1;
            int requestcounter = 1;
            List<string> fuzzstrs = Form2.listofinjections;
            for (int i = 0 ; i < countfuzzpoints ; i++) 
            {
                foreach (var fuzzy in fuzzstrs) 
                { 
                    try
                    {
                        HttpWebRequest myRequest =
                            (HttpWebRequest)HttpWebRequest.Create(targeturl.Text);
                        myRequest.ServicePoint.Expect100Continue = false;
                        string[] headers = null;
                        if ((headers = addheaders.Lines) != null)
                        {
                            for (int k = 0; k < headers.Length; k++)
                            {
                                //myRequest.Headers.Add(headers[i]);
                                //char[] delims = { ':' };
                                string[] headersplit = System.Text.RegularExpressions.Regex.Split(headers[k], ":");
                                string headercat = "";
                                for (int l = 1; l < headersplit.Length; l++)
                                {
                                    headercat += headersplit[l];
                                    if (l < headersplit.Length - 1)
                                        headercat += ":";
                                }
                                myRequest.Headers[headersplit[0]] = headercat;
                            }
                        }
                        if (myRequest.Proxy != null)
                            Logger.Text += "Proxy being used is: " + myRequest.Proxy.ToString() + "\n";
                        if (proxychk.Checked == true)
                        {   //Add code to process proxy
                            myProxy = new WebProxy(proxyserverurl.Text, false);
                            if (proxyAuthChk.Checked)
                            {  //Add code to include proxy creds
                                myProxy.Credentials = new NetworkCredential(proxyuname.Text, proxypasswd.Text);
                            }
                            myRequest.Proxy = myProxy;
                        }

                        if (PostRadio.Checked)
                            myRequest.Method = "POST";
                        else
                            myRequest.Method = "GET";
                        foreach (ListViewItem vi in httpheaderlist.Items)
                        {
                            myRequest.Headers.Add(vi.Text);
                        }
                        myRequest.ContentType = "text/xml";// charset=\"utf-8\"";    
                        string prefix = ""; 
                        for (int j = 0; j <= i; j++)
                            prefix += listofsplits[j];
                        prefix += fuzzy;
                        for (int j = i + 1; j <= countfuzzpoints; j++)
                            prefix += listofsplits[j];
                        byte[] data = encoding.GetBytes(prefix.ToCharArray());
                        myRequest.ContentLength = prefix.Length;
                        newStream = myRequest.GetRequestStream();
                        newStream.Write(data, 0, data.Length);
                        Logger.AppendText("\r\n New Request: " + prefix + "\r\n");
                        string fullreq = "";
                        fullreq += myRequest.Method + " " + myRequest.RequestUri.ToString()+" "+ "HTTP/1.1\r\n";
                        fullreq += myRequest.Headers;
                        //foreach (string header in myRequest.Headers) 
                        //    fullreq += header +"\r\n";
                        fullreq += "\r\n";
                        fullreq += prefix;
                        loWebResponse = (HttpWebResponse)myRequest.GetResponse();
                        //string reqdata = loReqStream.ReadToEnd();
                        //Logger.AppendText(reqdata);
                        lcHtml = loWebResponse.Headers.ToString();
                        loResponseStream = new System.IO.StreamReader(loWebResponse.GetResponseStream(), Encoding.UTF8);
                        // Release the HttpWebResponse Resource.
                        lcHtml += loResponseStream.ReadToEnd();
                        //responsebox.Text = lcHtml;
                        Logger.AppendText("\r\nHeaders: \r\n" + loWebResponse.Headers);
                        loWebResponse.Close();
                        loResponseStream.Close();
                        //loReqStream.Close();
                        newStream.Close();
                        List<string> test =  new List<string>();
                        test.Add(fuzzy);
                        test.Add(fullreq);
                        test.Add(lcHtml);
                        fuzzform.AddFuzzData(requestcounter,test);
                        requestcounter++;
                        fuzzform.RefreshForm();
                    }
                    catch (System.Net.WebException we)
                    {
                        Logger.Text += "\r\n**** Exception occurred: System.Net.WebException ****\r\n";
                        Logger.Text += "HTTP Status Code: " + we.Message + " : " + we.Response;
                    }
                }
            }
            //newStream.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fuzzSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fuzzsettingdialog = new Form2(this);
            //fuzzsettingdialog.Parent = this;
            fuzzsettingdialog.Show();
            /*if (enabledInjectionStrings.Length == 0
                && disabledInjectionStrings.Length == 0) 
            {
                //Means that we don't have a saved state

            }*/
        }

        private void aboutSOAPFuzzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void proxypasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode trav = null;
            TreeNode t = treeView1.SelectedNode;
            trav = t;
            while (!trav.Text.StartsWith("http"))
                trav = trav.Parent;
            request.Text = GenerateSOAP(treeView1.SelectedNode.Text, trav.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            request.Text = request.Text.Insert(request.SelectionStart, Char.ToString((char)632) );
            return;
        }

        private void autoselectmarkerbutton_Click(object sender, EventArgs e)
        {
            request.Text = request.Text.Replace("><", ">" + Char.ToString((char)632) + "<");
            return;
        }
    }
}