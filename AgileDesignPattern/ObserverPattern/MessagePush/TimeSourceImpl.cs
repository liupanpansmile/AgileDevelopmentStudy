using System.Collections.Generic;

namespace ObserverPattern.MessagePush
{
    class TimeSourceImpl
    {
        private List<IClockObserver> _observerList;

        public TimeSourceImpl()
        {
            _observerList = new List<IClockObserver>();
        }
        public void RegisterObserver(IClockObserver observer)
        {
           _observerList.Add(observer);
        }

        public void Notify(int hours,int minites,int seconds)
        {
            foreach (var o in _observerList)
            {
                o.Update(hours,minites,seconds);
            }
        }
    }
}