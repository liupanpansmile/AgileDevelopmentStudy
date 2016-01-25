using System;

namespace BridgePattern
{
    public class ZhongxingModem : IModemImplementation
    {
        public void Dial()
        {
            Console.WriteLine("Zhongxing Dial");
        }

        public void Hangup()
        {
            Console.WriteLine("Zhongxing Hangup");
        }

        public void Send()
        {
            Console.WriteLine("Zhongxing Send");
        }

        public void Receive()
        {
            Console.WriteLine("Zhongxing Receive");
        }
    }
}