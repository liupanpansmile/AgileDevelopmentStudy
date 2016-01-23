namespace ObserverPattern
{
    interface ITimeSource
    {
        void RegisterObserver(IClockObserver observer);
    }
}