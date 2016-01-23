namespace ObserverPattern
{
    interface ITimeSink
    {
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }

        void SetTime(int hours, int minutes, int seconds);
    }
}