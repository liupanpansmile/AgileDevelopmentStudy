using NUnit.Framework;

namespace ObserverPattern.MessagePull
{
    [TestFixture]
    class ObserverPullTest
    {
        private MockTimeSink _timeSink;
        private MockTimeSource _timeSource;

        [SetUp]
        public void SetUp()
        {
            _timeSource = new MockTimeSource();
            _timeSink = new MockTimeSink(_timeSource);
        }

        private void AsserrEquals(MockTimeSink sink, int hours, int minutes, int seconds)
        {
            Assert.AreEqual(hours, sink.Hours);
            Assert.AreEqual(minutes, sink.Minutes);
            Assert.AreEqual(seconds, sink.Seconds);
        }

        [Test]
        public void TestTimeChange()
        {
            _timeSource.RegisterObserver(_timeSink);

            int hours = 1;
            int minutes = 2;
            int seconds = 3;
            _timeSource.SetTime(hours,minutes,seconds);
            AsserrEquals(_timeSink, hours, minutes, seconds);

            hours = 4;
            minutes = 5;
            seconds = 6;
            _timeSource.SetTime(hours, minutes, seconds);
            AsserrEquals(_timeSink, hours, minutes, seconds);
        }

        [Test]
        public void TestMultipleTimeSink()
        {
            var sink2 = new MockTimeSink(_timeSource);
            _timeSource.RegisterObserver(_timeSink);
            _timeSource.RegisterObserver(sink2);

            int hours = 1;
            int minutes = 2;
            int seconds = 3;
            _timeSource.SetTime(hours, minutes, seconds);
            AsserrEquals(_timeSink, hours, minutes, seconds);
            AsserrEquals(sink2, hours, minutes, seconds);

            hours = 4;
            minutes = 5;
            seconds = 6;
            _timeSource.SetTime(hours, minutes, seconds);
            AsserrEquals(_timeSink, hours, minutes, seconds);
            AsserrEquals(sink2, hours, minutes, seconds);
        }
    }
}