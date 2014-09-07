using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Bridge;

namespace DesignPatterns
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void DragonMoveFly()
        {
            var dragon = new Dragon();

            Assert.AreEqual("Flying", dragon.Move(new FlyMoveBridge()));
        }

        [TestMethod]
        public void DragonMoveWalk()
        {
            var dragon = new Dragon();

            Assert.AreEqual("Walking", dragon.Move(new WalkMoveBridge()));
        }
    }
}
