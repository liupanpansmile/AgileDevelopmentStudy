namespace ObserverPattern
{
    class MockTimeSource : ITimeSource
    {
        public IClockObserver ClockObserver { get; set; }
        public void SetTime(int hours, int minutes, int seconds)
        {
            ClockObserver.Update(hours,minutes,seconds);
        }
    }
}