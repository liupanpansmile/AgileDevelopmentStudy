namespace ObserverPattern
{
    class MockTimeSource : ITimeSource
    {
        public ClockDriver ClockDriver { get; set; }
        public void SetTime(int hours, int minutes, int seconds)
        {
            ClockDriver.Update(hours,minutes,seconds);
        }
    }
}