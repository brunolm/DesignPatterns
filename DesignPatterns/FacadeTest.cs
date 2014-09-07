using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Facade;

namespace DesignPatterns
{
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void CreateNuclearFusion()
        {
            var dragonFacade = new DragonFacade(
                new Dragon { Power = 9999 },
                new FireEnergy { Intencity = 99 },
                new Star { Radius = 999999 }
            );

            Assert.AreEqual("Star has been consumed to create Nuclear Fusion"
                , dragonFacade.CreateNuclearFusion());
        }

        [TestMethod]
        public void CreateNuclearFusionFails()
        {
            var dragonFacade = new DragonFacade(
                new Dragon { Power = 0 },
                new FireEnergy { Intencity = 99 },
                new Star { Radius = 999999 }
            );

            Assert.AreNotEqual("Star has been consumed to create Nuclear Fusion"
                , dragonFacade.CreateNuclearFusion());
        }
    }
}
