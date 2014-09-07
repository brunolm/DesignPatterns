using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.ChainOfResponsibility;

namespace DesignPatterns
{
    [TestClass]
    public class ChainOfResponsibilityTest
    {
        [TestMethod]
        public void HealTo9999()
        {
            var dragon = new Dragon();

            var mediumHealer = new MediumHealer();
            var godHealer = new GodHealer();

            mediumHealer.NextLink = godHealer;

            mediumHealer.Heal(dragon);

            Assert.AreEqual(9999, dragon.Health);
        }

        [TestMethod]
        public void HealTo99()
        {
            var dragon = new Dragon();

            var mediumHealer = new MediumHealer();

            mediumHealer.Heal(dragon);

            Assert.AreEqual(99, dragon.Health);
        }
    }
}
