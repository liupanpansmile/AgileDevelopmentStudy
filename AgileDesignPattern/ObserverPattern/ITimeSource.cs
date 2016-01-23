namespace ObserverPattern
{
    interface ITimeSource
    {
        void RegisterObserver(IClockObserver observer);
        void SetTime(int hours, int minutes, int seconds);
    }
}