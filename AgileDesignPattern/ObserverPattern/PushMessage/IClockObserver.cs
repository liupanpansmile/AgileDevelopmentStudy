namespace ObserverPattern.PushMessage
{
    interface IClockObserver
    {
        void Update(int hours, int minutes, int seconds);
    }
}
