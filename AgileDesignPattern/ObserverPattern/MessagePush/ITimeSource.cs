namespace ObserverPattern.MessagePush
{
    interface ITimeSource
    {
        void RegisterObserver(IClockObserver observer);
    }
}