using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void CreatePlayerWithFireDragon()
        {
            var player = new Player(new FireDragonFactory());

            Assert.AreEqual(Dragon.ElementalType.Fire, player.Dragon.Elemental);
        }

        [TestMethod]
        public void CreatePlayerWithWaterDragon()
        {
            var player = new Player(new WaterDragonFactory());

            Assert.AreEqual(Dragon.ElementalType.Water, player.Dragon.Elemental);
        }

        [TestMethod]
        public void CreatePlayerWithEarthDragon()
        {
            var player = new Player(new EarthDragonFactory());

            Assert.AreEqual(Dragon.ElementalType.Earth, player.Dragon.Elemental);
        }

        [TestMethod]
        public void CreatePlayerWithWindDragon()
        {
            var player = new Player(new WindDragonFactory());

            Assert.AreEqual(Dragon.ElementalType.Wind, player.Dragon.Elemental);
        }
    }
}
