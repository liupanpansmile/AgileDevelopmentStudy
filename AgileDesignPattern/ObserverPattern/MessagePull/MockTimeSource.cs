namespace ObserverPattern.MessagePull
{
    public class MockTimeSource :Subject, ITimeSource
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public void SetTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Notify();
        }
    }
}