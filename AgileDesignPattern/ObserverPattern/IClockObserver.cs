namespace ObserverPattern
{
    interface IClockObserver
    {
        void Update(int hours, int minutes, int seconds);
    }
}
