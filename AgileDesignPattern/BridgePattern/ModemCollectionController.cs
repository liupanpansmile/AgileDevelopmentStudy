namespace BridgePattern
{
    public abstract class ModemCollectionController:IModem,IDedicatedModem
    {
        private IModemImplementation _modemImplementation;
        public bool Connected { get; protected set; }

        protected ModemCollectionController(IModemImplementation modemImpl)
        {
            _modemImplementation = modemImpl;
        }

        protected void DialImpl()
        {
            _modemImplementation.Dial();
            Connected = true;

        }

        protected void HangupImpl()
        {
            _modemImplementation.Hangup();
            Connected = false;
        }

        protected void SendImpl()
        {
            _modemImplementation.Send();
        }

        protected void ReceiveImpl()
        {
            _modemImplementation.Receive(); 
        }
        
        public abstract void Dial();
        public abstract void Hangup();

        public abstract void Send();

        public abstract void Receive();

    }
}