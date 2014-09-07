using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Prototype;

namespace DesignPatterns
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void ClonedObjectsAreNotSame()
        {
            Dragon d1 = new Dragon { Attack = 9000 };
            Dragon d2 = d1;
            Dragon d3 = null;

            d3 = (Dragon)d1.Clone();

            Assert.AreSame(d1, d2);
            Assert.AreNotSame(d1, d3);
            Assert.AreEqual(d1.Attack, d3.Attack);

            d3.Attack = 555;

            Assert.AreNotEqual(d1.Attack, d3.Attack);
        }
    }
}
