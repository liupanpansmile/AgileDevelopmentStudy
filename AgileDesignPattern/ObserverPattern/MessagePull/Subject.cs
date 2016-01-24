using System.Collections.Generic;

namespace ObserverPattern.MessagePull
{
    public class Subject
    {
        private List<ITimeObserver> _observers;

        public  Subject()
        {
            _observers = new List<ITimeObserver>();
        }

        public void RegisterObserver(ITimeObserver timeObserver)
        {
            _observers.Add(timeObserver);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }
    }
}