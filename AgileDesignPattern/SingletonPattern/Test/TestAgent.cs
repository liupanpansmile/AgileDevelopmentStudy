using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SingletonPattern.Src;

namespace SingletonPattern.Test
{
    [TestFixture]
    class TestAgent
    {
        [Test]
        public void TestUnique()
        {
            var agent = Agent.CreateInstance(); 
            var agent2 = Agent.CreateInstance();
            Assert.AreEqual(agent, agent2);
        }
    }
}
