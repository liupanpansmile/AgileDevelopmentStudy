namespace ObserverPattern
{
    interface ITimeSource
    {
        IClockObserver ClockObserver { get; set; }
        void SetTime(int hours, int minutes, int seconds);
    }
}