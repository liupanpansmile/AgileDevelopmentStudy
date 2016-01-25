namespace BridgePattern
{
    public class DedModemController : ModemCollectionController
    {
        public DedModemController(IModemImplementation modemImpl) : base(modemImpl)
        {
        }

        public override void Dial()
        {
        }

        public override void Hangup()
        {
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