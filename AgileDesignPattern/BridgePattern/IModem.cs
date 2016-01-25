namespace BridgePattern
{
    public interface IModem
    {
        void Dial();
        void Hangup();
        void Send();
        void Receive();
    }
}