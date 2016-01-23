namespace ObserverPattern
{
    interface ITimeSource
    {
        ClockDriver ClockDriver { get; set; }
        void SetTime(int hours, int minutes, int seconds);
    }
}