using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void MoveStrategyFly()
        {
            var dragon = new Dragon();
            dragon.MoveStrategy = new FlyStrategy();

            Assert.AreEqual("Fly", dragon.Move());
        }
        [TestMethod]
        public void MoveStrategyWalk()
        {
            var dragon = new Dragon();
            dragon.MoveStrategy = new WalkStrategy();

            Assert.AreEqual("Walk", dragon.Move());
        }
    }
}
