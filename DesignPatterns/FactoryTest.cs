using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void CreateBlackDragon()
        {
            var dragonFactory = new DragonFactory();

            var dragon = dragonFactory.Create(DragonFactory.DragonBreed.Black);

            Assert.AreEqual("Black Dragon", dragon.Name);
        }

        [TestMethod]
        public void CreateRedDragon()
        {
            var dragonFactory = new DragonFactory();

            var dragon = dragonFactory.Create(DragonFactory.DragonBreed.Red);

            Assert.AreEqual("Red Dragon", dragon.Name);
        }
    }
}
