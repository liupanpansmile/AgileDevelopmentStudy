namespace ObserverPattern.MessagePull
{
    public interface ITimeSource
    {
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
    }
}