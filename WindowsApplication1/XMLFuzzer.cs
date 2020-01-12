using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WindowsApplication1
{
    class XMLFuzzer
    {
        private XmlReader m_xmlr;

        public XMLFuzzer(String xmlstr)
        {
            if (xmlstr.Length > 0)
                m_xmlr = System.Xml.XmlReader.Create(new System.IO.StringReader(xmlstr));
            else
                m_xmlr = null;
        }

        public String[] TagsAndAttributes()
        {
            String[] strtags = null;
            int i = 0; 

            if (m_xmlr != null)
                while (m_xmlr.Read())
                {
                    if (m_xmlr.NodeType == XmlNodeType.Element)
                        strtags[i++] = new String(m_xmlr.Name.ToCharArray());
                    else if (m_xmlr.NodeType == XmlNodeType.Attribute)
                        strtags[i++] = new String(m_xmlr.Name.ToCharArray());
                    Console.WriteLine(m_xmlr.Name.ToString());
                }
            
            return strtags;
        }
        ~XMLFuzzer()
        {

        }
    }
}
