using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Mediator;

namespace DesignPatterns
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void DragonsRage()
        {
            var dragonsHoardNorth = new DragonMediator();
            var dragonsHoardSoulth = new DragonMediator();

            var d1 = new Dragon(dragonsHoardNorth);
            var d2 = new Dragon(dragonsHoardNorth);
            var d3 = new Dragon(dragonsHoardSoulth);
            var d4 = new Dragon(dragonsHoardSoulth);

            d1.DragonsCall();

            Assert.AreEqual(100, d1.Rage);
            Assert.AreEqual(100, d2.Rage);

            d2.DragonsCall();

            Assert.AreEqual(200, d1.Rage);
            Assert.AreEqual(200, d2.Rage);

            Assert.AreEqual(0, d3.Rage);
            Assert.AreEqual(0, d4.Rage);
        }
    }
}
