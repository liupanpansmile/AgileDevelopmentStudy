namespace ObserverPattern.MessagePush
{
    interface IClockObserver
    {
        void Update(int hours, int minutes, int seconds);
    }
}
