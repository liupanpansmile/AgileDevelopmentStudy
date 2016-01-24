namespace ObserverPattern.PushMessage
{
    interface ITimeSource
    {
        void RegisterObserver(IClockObserver observer);
    }
}