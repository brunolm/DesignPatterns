using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void ChangeElementInstanceFire()
        {
            var dragon = new Dragon();
            dragon.ElementMode = new FireBehavior();

            Assert.AreEqual(100, dragon.ResistFire);
            Assert.AreEqual(0, dragon.ResistWater);
            Assert.AreEqual(25, dragon.ResistEarth);
            Assert.AreEqual(50, dragon.ResistWind);
        }

        [TestMethod]
        public void ChangeElementInstanceWater()
        {
            var dragon = new Dragon();
            dragon.ElementMode = new WaterBehavior();

            Assert.AreEqual(50, dragon.ResistFire);
            Assert.AreEqual(100, dragon.ResistWater);
            Assert.AreEqual(0, dragon.ResistEarth);
            Assert.AreEqual(25, dragon.ResistWind);
        }

        [TestMethod]
        public void ChangeElementInstanceEarth()
        {
            var dragon = new Dragon();
            dragon.ElementMode = new EarthBehavior();

            Assert.AreEqual(25, dragon.ResistFire);
            Assert.AreEqual(50, dragon.ResistWater);
            Assert.AreEqual(100, dragon.ResistEarth);
            Assert.AreEqual(0, dragon.ResistWind);
        }

        [TestMethod]
        public void ChangeElementInstanceWind()
        {
            var dragon = new Dragon();
            dragon.ElementMode = new WindBehavior();

            Assert.AreEqual(0, dragon.ResistFire);
            Assert.AreEqual(25, dragon.ResistWater);
            Assert.AreEqual(50, dragon.ResistEarth);
            Assert.AreEqual(100, dragon.ResistWind);
        }
    }
}
