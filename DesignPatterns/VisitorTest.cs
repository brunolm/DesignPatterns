using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Visitor;

namespace DesignPatterns
{
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void DealDamageDifferentTypes()
        {
            var dragon = new Dragon { HitPoints = 1000 };
            var human = new Human { HitPoints = 1 };

            var projectile = new GigaBlastProjectile();

            dragon.Accept(projectile);
            human.Accept(projectile);

            Assert.AreEqual(999, dragon.HitPoints);
            Assert.AreEqual(-1000, human.HitPoints);
        }
    }
}
