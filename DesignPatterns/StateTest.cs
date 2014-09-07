using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.State;

namespace DesignPatterns
{
    [TestClass]
    public class StateTest
    {
        [TestMethod]
        public void SwitchStates()
        {
            var dragon = new Dragon();

            dragon.Fly();

            Assert.AreEqual(1000, dragon.State.Speed);
            Assert.IsTrue(dragon.State.Flying);
            Assert.IsFalse(dragon.State.Walking);

            dragon.Walk();

            Assert.AreEqual(10, dragon.State.Speed);
            Assert.IsFalse(dragon.State.Flying);
            Assert.IsTrue(dragon.State.Walking);
        }
    }
}
