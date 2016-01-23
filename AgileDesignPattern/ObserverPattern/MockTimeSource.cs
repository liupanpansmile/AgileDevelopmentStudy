using System.Collections.Generic;

namespace ObserverPattern
{
    class MockTimeSource : ITimeSource
    {
        private List<IClockObserver> _observerList;

        public MockTimeSource()
        {
            _observerList = new List<IClockObserver>();
        }
        public void RegisterObserver(IClockObserver observer)
        {
            _observerList.Add(observer);
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            foreach (var o in _observerList)
            {
                o.Update(hours, minutes, seconds);
            }
        }
    }
}