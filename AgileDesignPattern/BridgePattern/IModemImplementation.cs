namespace BridgePattern
{
    public interface IModemImplementation
    {
        void Dial();
        void Hangup();
        void Send();
        void Receive();
    }
}