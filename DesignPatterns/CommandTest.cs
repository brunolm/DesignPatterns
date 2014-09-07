using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Command;

namespace DesignPatterns
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void DragonMoves()
        {
            var dragon = new Dragon();
            var moveCommand = new DragonMoveCommand(dragon, 10, 5);

            Assert.AreEqual(0, dragon.PositionX);
            Assert.AreEqual(0, dragon.PositionY);

            moveCommand.Execute();

            Assert.AreEqual(10, dragon.PositionX);
            Assert.AreEqual(5, dragon.PositionY);
        }
    }
}
