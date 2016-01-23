using NUnit.Framework;

namespace ObserverPattern.Test
{
    [TestFixture]
    class ClockDriverTest
    {
        [Test]
        public void TestTimeChange()
        {
            var source = new MockTimeSource() ;
            var sink = new MockTimeSink();
            var clockDriver = new ClockDriver(source, sink);

            int hours = 1;
            int minutes = 2;
            int seconds = 3;
            source.SetTime(hours,minutes,seconds);
            Assert.AreEqual(hours,sink.Hours);
            Assert.AreEqual(minutes, sink.Minutes);
            Assert.AreEqual(seconds, sink.Seconds);

            hours = 4;
            minutes = 5;
            seconds = 6;
            source.SetTime(hours, minutes, seconds);
            Assert.AreEqual(hours, sink.Hours);
            Assert.AreEqual(minutes, sink.Minutes);
            Assert.AreEqual(seconds, sink.Seconds);




        }
    }
}
