using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Bridge;

namespace DesignPatterns
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void DragonBridge()
        {
            var dragon = new Dragon();

            var xboxController = new XBoxController(dragon);
            var psController = new PSController(dragon);

            Assert.AreEqual("Run", xboxController.ButtonA());
            Assert.AreEqual("Fly", xboxController.ButtonB());

            Assert.AreEqual("Fly", psController.ButtonA());
            Assert.AreEqual("Run", psController.ButtonB());
        }


        [TestMethod]
        public void BikeBridge()
        {
            var bike = new Bike();

            var xboxController = new XBoxController(bike);
            var psController = new PSController(bike);

            Assert.AreEqual("Run", xboxController.ButtonA());
            Assert.AreEqual("Stop", xboxController.ButtonB());

            Assert.AreEqual("Stop", psController.ButtonA());
            Assert.AreEqual("Run", psController.ButtonB());
        }
    }
}