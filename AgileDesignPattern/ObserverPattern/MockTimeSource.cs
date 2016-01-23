using System.Collections.Generic;

namespace ObserverPattern
{
    /*
     * �����ƺܳ�ª���������C#���ܶ�̳У�����ǽ�ObservableClock�����Ϳ��Լ̳�Clock
     * MockTimeSource����TimeSourceImpl,
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