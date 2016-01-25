using NUnit.Framework;

namespace BridgePattern
{
    [TestFixture]
    class ModemTest
    {
        [Test]
        public void TestDedModem()
        {
            var dialModem = new DialModemController(new ZhongxingModem());
            Assert.IsFalse(dialModem.Connected);

            dialModem.Dial();
            Assert.IsTrue(dialModem.Connected);

            dialModem.Hangup();
            Assert.IsFalse(dialModem.Connected);
        }

        [Test]
        public void TestDialModem()
        {
            var dialModem = new DedModemController(new ZhongxingModem());
            Assert.IsFalse(dialModem.Connected);

            dialModem.Dial();
            Assert.IsFalse(dialModem.Connected);

            dialModem.Hangup();
            Assert.IsFalse(dialModem.Connected);
        }
    }
}
