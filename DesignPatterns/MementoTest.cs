using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Memento;

namespace DesignPatterns
{
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void DragonsMoveAreRecorded()
        {
            var dragon = new Dragon();
            var dragonRecorder = new Recorder(dragon);
            dragonRecorder.Record();

            Assert.AreEqual(0, dragon.PositionX);
            Assert.AreEqual(0, dragon.PositionY);

            dragon.PositionX = 100;
            dragon.PositionY = 50;
            dragonRecorder.Record();

            Assert.AreEqual(100, dragon.PositionX);
            Assert.AreEqual(50, dragon.PositionY);

            dragon.PositionX = 500;
            dragon.PositionY = 500;
            dragonRecorder.Record();

            Assert.AreEqual(500, dragon.PositionX);
            Assert.AreEqual(500, dragon.PositionY);

            dragonRecorder.Rewind();

            Assert.AreEqual(100, dragon.PositionX);
            Assert.AreEqual(50, dragon.PositionY);

            dragonRecorder.Rewind();

            Assert.AreEqual(0, dragon.PositionX);
            Assert.AreEqual(0, dragon.PositionY);

            dragonRecorder.Foward();

            Assert.AreEqual(100, dragon.PositionX);
            Assert.AreEqual(50, dragon.PositionY);

            dragonRecorder.Foward();

            Assert.AreEqual(500, dragon.PositionX);
            Assert.AreEqual(500, dragon.PositionY);
        }
    }
}
