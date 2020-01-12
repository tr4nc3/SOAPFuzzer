using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Collections;

namespace WindowsApplication1
{
    class XmlGenerator
    {
        //Stack<string> m_stack = new Stack<string>();
        //string m_xmlstr;
        /*const int EXTENSION = 1;
        const int UNION = 2;
        const int LIST = 4;
        const int RESTRICTION = 8;
        const int ATOMIC = 16;
        
        const int MINEXCLUSIVE      = 32;
        const int MININCLUSIVE      = 64; 
        const int MAXEXCLUSIVE      = 128; 
        //const int MAXEXCLUSIVE      = 256; 
        const int EXPLICITTIMEZONE = 256;
        const int MAXINCLUSIVE      = 512;
        const int TOTALDIGITS       = 1024;
        const int FRACTIONDIGITS    = 2048; 
        const int MAXSCALE          = 4096; 
        const int MINSCALE          = 8192; 
        const int LENGTH            = 16384; 
        const int MINLENGTH         = 32768; 
        const int MAXLENGTH         = 65536;
        const int ENUMERATION       = 131072; 
        const int WHITESPACE        = 262144;
        const int PATTERN           = 524288;
        const int ASSERTION         = 1048576;*/

        //private Hashtable hashProcessedElements;

        public string GenerateXmlString(XmlSchemaObject root, XmlSchema xs)
        {
            string tags = null;
            if (root is XmlSchemaComplexType)
            {
                XmlSchemaComplexType ct = root as XmlSchemaComplexType;
                tags += GenerateXmlString(ct.Particle,xs);
            }
            else
                if (root is XmlSchemaElement)
                {
                    XmlSchemaElement elem = root as XmlSchemaElement;
                    string tagname;
                    if (elem.Name != null)
                        tagname = elem.Name;
                    else
                        tagname = elem.RefName.Name;
                    //tags += "<" + tagname + ">";
                    if (elem.SchemaType is XmlSchemaComplexType)
                    {
                        XmlSchemaComplexType ect = elem.SchemaType as XmlSchemaComplexType;
                        tags += "<" + tagname + ">";
                        tags += GenerateXmlString(ect.Particle, xs);
                        int flag = -1;
                        if (SearchNode(xs, tagname) != null)
                            flag = 1;
                        else flag = 0;
             
                        tags += "</" + tagname + ">";    
                    }
                    else
                    {
                        if (elem.Name == null)
                        {
                            //tags += "<" + elem.RefName.Name + ">";
                            //tags += GenerateXmlString(ect.Particle);
                            //tags += "<" + tagname + ">";
                            tags += GenerateXmlString(SearchNode(xs, elem.RefName.Name), xs);
                            //tags += "</" + tagname + ">";
                            //tags += "</" + elem.RefName.Name + ">";
                        }
                        else
                        {
                            System.Xml.Schema.XmlSchemaObject xso = null;
                            tags += "<" + tagname + ">";
                            //If the default namespaces are changed, the 2nd part of if becomes critical
                            //StackOverflow Otherwise
                            if ((xso = SearchNode(xs, elem.SchemaTypeName.Name)) != null && 
                                !elem.SchemaTypeName.Namespace.StartsWith("http://www.w3.org")) 
                            {
                                tags += GenerateXmlString(xso, xs);
                            }
                            tags += "</" + tagname + ">";
                            

                        }
                    }
                    //tags += "</" + tagname + ">";
                }
                else
                    if (root is XmlSchemaGroupBase)
                    {
                        XmlSchemaGroupBase baseParticle = root as XmlSchemaGroupBase;
                        foreach (XmlSchemaParticle subParticle in baseParticle.Items)
                        {
                            tags += GenerateXmlString(subParticle, xs);
                        }
                    }
            return tags;
        }
        /*public string GenerateXmlString(XmlSchemaParticle root)
        {
            string tag = null;
            if (root is XmlSchemaElement)
            {
                XmlSchemaElement elem = root as XmlSchemaElement;
                tag += '<' + elem.Name + '>';
                if (elem.RefName.IsEmpty)
                { //sequence
                    XmlSchemaType type = (XmlSchemaType)elem.ElementSchemaType;
                    //XmlSchemaComplexType complexType = type as XmlSchemaComplexType;
                    if (type is XmlSchemaComplexType)
                    {
                        XmlSchemaComplexType complexType = type as XmlSchemaComplexType;
                        if (complexType.QualifiedName.IsEmpty)
                        //if (!((elem.Parent is XmlSchemaComplexType) || (elem.Parent is XmlSchemaSimpleType)))
                        {
                            tag += '<' + elem.Name + '>';
                            tag += GenerateXmlString(complexType.ContentTypeParticle);
                            tag += "</" + elem.Name + ">";
                        }*/
                        /*else
                        {
                        }*//*
                    }
                }
                tag += "</"+elem.Name+">";
                    
                    *//*else
                    {  //is it simpletype
                        XmlSchemaSimpleType simpleType = ((XmlSchemaType)elem.ElementSchemaType) as XmlSchemaSimpleType;
                        //SimpleType element restriction, maxinclusive, mininclusive, 
                        if (simpleType != null)
                        {  //Need to take care of restriction, list or union types here
                           //simpleType.TypeCode
                            if (simpleType.Name == null)
                            { 
                            }
                            else 
                            { 
                            }    
                        }
                    }*//*

                //}

            }
            else
                if (root is XmlSchemaGroupBase)
                { //It xs:all, 
                    XmlSchemaGroupBase baseParticle = root as XmlSchemaGroupBase;
                    //tag += baseParticle.Name
                    foreach (XmlSchemaParticle subParticle in baseParticle.Items)
                    {
                        tag += GenerateXmlString(subParticle);
                    }
                }
            return tag;
        }*/
        public XmlSchemaObject SearchNode(XmlSchema xs, string name)
        {
            XmlSchemaObject returnval = null;
            foreach (object item in xs.Items)
            {
                System.Xml.Schema.XmlSchemaElement xse = item as System.Xml.Schema.XmlSchemaElement;
                System.Xml.Schema.XmlSchemaComplexType xsct = item as System.Xml.Schema.XmlSchemaComplexType;
                if (xse != null)
                {
                    if (xse.Name == name)
                        returnval = xse;
                }
                else
                {
                    if (xsct != null)
                        if (xsct.Name == name)
                            returnval = xsct;
                }

            }
            return returnval;
        }
    }
}
