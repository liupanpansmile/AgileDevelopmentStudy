using NUnit.Framework;

namespace ObserverPattern.Test
{
    [TestFixture]
    class ClockDriverTest
    {
        private void AsserrEquals(MockTimeSink sink, int hours, int minutes, int seconds)
        {
            Assert.AreEqual(hours, sink.Hours);
            Assert.AreEqual(minutes, sink.Minutes);
            Assert.AreEqual(seconds, sink.Seconds);
        }

        [Test]
        public void TestTimeChanged()
        {
            var source = new MockTimeSource() ;
            var sink = new MockTimeSink();
            source.RegisterObserver(sink);

            int hours = 1;
            int minutes = 2;
            int seconds = 3;
            source.SetTime(hours,minutes,seconds);
            AsserrEquals(sink, hours, minutes, seconds);
            
            hours = 4;
            minutes = 5;
            seconds = 6;
            source.SetTime(hours, minutes, seconds);
            AsserrEquals(sink, hours, minutes, seconds);
        }

        [Test]
        public void TestMultipleSinks()
        {
            var source = new MockTimeSource();
            var sink = new MockTimeSink();
            var sink2 = new MockTimeSink();

            source.RegisterObserver(sink);
            source.RegisterObserver(sink2);

            int hours = 1;
            int minutes = 2;
            int seconds = 3;
            source.SetTime(hours, minutes, seconds);
            AsserrEquals(sink, hours, minutes, seconds);
            AsserrEquals(sink2, hours, minutes, seconds);

            hours = 4;
            minutes = 5;
            seconds = 6;
            source.SetTime(hours, minutes, seconds);
            AsserrEquals(sink, hours, minutes, seconds);
            AsserrEquals(sink2, hours, minutes, seconds);
        }
    }
}
