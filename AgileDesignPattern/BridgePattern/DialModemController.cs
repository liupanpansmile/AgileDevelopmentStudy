namespace BridgePattern
{
    public class DialModemController : ModemCollectionController
    {
        public DialModemController(IModemImplementation modemImpl)
            : base(modemImpl)
        {
        }

        public override void Dial()
        {
            DialImpl();
        }

        public override void Hangup()
        {
            HangupImpl();
        }

        public override void Send()
        {
            SendImpl();
        }

        public override void Receive()
        {
            ReceiveImpl();
        }
    }
}