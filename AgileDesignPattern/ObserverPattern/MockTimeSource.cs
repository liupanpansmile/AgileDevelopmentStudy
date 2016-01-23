using System.Collections.Generic;

namespace ObserverPattern
{
    /*
     * 这个设计很丑陋，但是如果C#不能多继承，如果城建ObservableClock，他就可以继承Clock
     * MockTimeSource依赖TimeSourceImpl,
     */
    class MockTimeSource : ITimeSource
    {
        private readonly TimeSourceImpl _timeSourceImpl = new TimeSourceImpl();
        
        public void RegisterObserver(IClockObserver observer)
        {
            _timeSourceImpl.RegisterObserver(observer);
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
           _timeSourceImpl.Notify(hours,minutes,seconds);
        }
    }
}