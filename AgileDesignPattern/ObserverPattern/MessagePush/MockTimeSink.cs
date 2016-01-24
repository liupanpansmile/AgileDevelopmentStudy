namespace ObserverPattern.MessagePush
{
    class MockTimeSink : IClockObserver
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
      
        public void Update(int hours, int minutes, int seconds)
        {
            SetTime(hours, minutes, seconds);
        }
        private void SetTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}