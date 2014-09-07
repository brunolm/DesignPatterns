using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Adapter;

namespace DesignPatterns
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void DragonBreathAttack()
        {
            IDragon dragon = new Dragon();
            IDragon mysticalDragon = new MysticalDragon();
            IDragon samuraiDragon = new SamuraiDragonAdapter(new Samurai());

            Assert.AreEqual("Dragon Breath", dragon.BreathAttack());
            Assert.AreEqual("Mystical Dragon Breath", mysticalDragon.BreathAttack());
            Assert.AreEqual("Slash Dragon Breath", samuraiDragon.BreathAttack());
        }
    }
}
