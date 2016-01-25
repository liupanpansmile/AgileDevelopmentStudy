using System;

namespace BridgePattern
{
    public class HuaweiModem : IModemImplementation
    {
        public void Dial()
        {
            Console.WriteLine("HayesModem Dial");
        }

        public void Hangup()
        {
            Console.WriteLine("HayesModem Hangup");
        }

        public void Send()
        {
            Console.WriteLine("HayesModem Send");
        }

        public void Receive()
        {
            Console.WriteLine("HayesModem Receive");
        }
    }
}