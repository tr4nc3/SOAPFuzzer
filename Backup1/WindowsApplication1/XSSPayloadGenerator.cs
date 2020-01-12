using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsApplication1
{
    class XSSPayloadGenerator:PayloadGenerator
    {
        string m_strConnStr;
        System.Data.SQLite.SQLiteConnection m_sqlConn;
        System.Data.SQLite.SQLiteCommand m_sqlCmd;
        
        
        public XSSPayloadGenerator()
        {
            m_strConnStr = "Data Source=payloads.s3db;Version=3;";
            m_sqlConn = new System.Data.SQLite.SQLiteConnection(m_strConnStr);
            m_sqlConn.Open();
            m_sqlCmd = m_sqlConn.CreateCommand();
            m_sqlCmd.CommandText = "select teststring from payloads where category=\'XSS\'";

        }
        public ~XSSPayloadGenerator()
        {
            m_sqlConn.Close();
        }
        public void Initialize()
        {

        }
        public string StrNextPayload()
        {
            return null;
        }
        public string[] StrExpectedOutput()
        {
            return null;
        }
    }
}
