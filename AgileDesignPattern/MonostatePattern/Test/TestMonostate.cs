using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonostatePattern.Source;
using NUnit.Framework;

namespace MonostatePattern.Test
{
    [TestFixture]
    class TestMonostate
    {
        [Test]
        public void TestMonostateUnique()
        {
            Monostate obj1 = new Monostate();
            Monostate obj2 = new Monostate();

            Assert.AreEqual(obj1.ItsX, obj2.ItsX);
        }

        [Test]
        public void TestMonostateUnique2()
        {
            Monostate obj1 = new Monostate();
            Monostate obj2 = new Monostate();
            obj1.ItsX = 10;
            Assert.AreEqual(obj2.ItsX, 10);
        }
    }
}
