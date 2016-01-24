namespace ObserverPattern.MessagePull
{
    public class MockTimeSink:ITimeObserver
    {
        private readonly ITimeSource _timeSource;
        public MockTimeSink(ITimeSource timeSource)
        {
            _timeSource = timeSource;
        }
        public void Update()
        {
            Hours = _timeSource.Hours;
            Minutes = _timeSource.Minutes;
            Seconds = _timeSource.Seconds;
        }

        public int Hours { get; protected set; }
        public int Minutes { get; protected set; }
        public int Seconds { get; protected set; }
    }
}