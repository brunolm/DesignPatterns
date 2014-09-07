using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Composite;

namespace DesignPatterns
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void CompositeAttackDealsCompositeDamage()
        {
            var d1 = new Dragon();
            var d2 = new Dragon();
            var d3 = new Dragon();
            var d4 = new Dragon();
            var d5 = new Dragon();

            var composite = new DragonComposite();
            composite.Add(d1);
            composite.Add(d2);
            composite.Add(d3);
            composite.Add(d4);

            Assert.AreEqual(340, composite.Attack());
            Assert.AreEqual(100, d5.Attack());
        }
    }
}
