using DesignPatterns.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void FireUpgradeIncreasesFireDamage()
        {
            IDragon dragon = new Dragon();

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);

            dragon = new DragonFireUpgrade(dragon);

            Assert.AreEqual(11, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);
        }

        [TestMethod]
        public void WaterUpgradeIncreasesWaterDamage()
        {
            IDragon dragon = new Dragon();

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);

            dragon = new DragonWaterUpgrade(dragon);

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(11, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);
        }

        [TestMethod]
        public void EarthUpgradeIncreasesEarthDamage()
        {
            IDragon dragon = new Dragon();

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);

            dragon = new DragonEarthUpgrade(dragon);

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(11, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);
        }

        [TestMethod]
        public void WindUpgradeIncreasesWindDamage()
        {
            IDragon dragon = new Dragon();

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);

            dragon = new DragonWindUpgrade(dragon);

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(11, dragon.WindDamage);
        }

        [TestMethod]
        public void UpgradeStacks()
        {
            IDragon dragon = new Dragon();

            Assert.AreEqual(1, dragon.FireDamage);
            Assert.AreEqual(1, dragon.WaterDamage);
            Assert.AreEqual(1, dragon.EarthDamage);
            Assert.AreEqual(1, dragon.WindDamage);

            dragon = new DragonFireUpgrade(dragon);
            dragon = new DragonFireUpgrade(dragon);
            dragon = new DragonWaterUpgrade(dragon);
            dragon = new DragonEarthUpgrade(dragon);
            dragon = new DragonWindUpgrade(dragon);

            Assert.AreEqual(21, dragon.FireDamage);
            Assert.AreEqual(11, dragon.WaterDamage);
            Assert.AreEqual(11, dragon.EarthDamage);
            Assert.AreEqual(11, dragon.WindDamage);
        }
    }
}
