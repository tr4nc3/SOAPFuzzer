using System;


namespace WindowsApplication1
{
    abstract class PayloadGenerator
    {
        public abstract string StrNextPayload()
        {
        }
        public abstract string[] StrExpectedOutput(int payloadid)
        {
        }
    }
}
