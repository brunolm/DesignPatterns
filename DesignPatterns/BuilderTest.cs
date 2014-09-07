using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Builder;

namespace DesignPatterns
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void BuildFireDragonType1()
        {
            var director = new DragonBuildDirector();

            var dragonBuilder = new FireDragonBuilder();

            director.BuildType1(dragonBuilder);

            Dragon dragon = dragonBuilder.GetResult();

            Assert.AreEqual(Dragon.ElementalType.Fire, dragon.Elemental);
            Assert.AreEqual(9999, dragon.Power);
        }


        [TestMethod]
        public void BuildWaterDragonType1()
        {
            var director = new DragonBuildDirector();

            var dragonBuilder = new WaterDragonBuilder();

            director.BuildType1(dragonBuilder);

            Dragon dragon = dragonBuilder.GetResult();

            Assert.AreEqual(Dragon.ElementalType.Water, dragon.Elemental);
            Assert.AreEqual(9999, dragon.Power);
        }


        [TestMethod]
        public void BuildFireDragonType2()
        {
            var director = new DragonBuildDirector();

            var dragonBuilder = new FireDragonBuilder();

            director.BuildType2(dragonBuilder);

            Dragon dragon = dragonBuilder.GetResult();
            
            Assert.AreEqual(Dragon.ElementalType.Fire, dragonBuilder.GetResult().Elemental);
            Assert.AreEqual(0, dragon.Power);
        }
    }
}
