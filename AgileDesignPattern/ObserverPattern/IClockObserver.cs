namespace ObserverPattern
{
    interface IClockObserver
    {
        void Update(int hours, int minutes, int seconds);
    }

    class ClockDriver :IClockObserver
    {
        public ITimeSource TimeSource { get; set; }
        public ITimeSink TimeSink { get; set; }

        public ClockDriver(ITimeSource source, ITimeSink sink)
        {
            TimeSource = source;
            TimeSource.ClockObserver = this;
            TimeSink = sink;
        }
        public void Update(int hours, int minutes, int seconds)
        {
            TimeSink.SetTime(hours, minutes, seconds);
        }
    }
    
}
