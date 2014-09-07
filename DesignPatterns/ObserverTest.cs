using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatters.Observer;

namespace DesignPatterns
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void DragonFlyPeopleLookUp()
        {
            Dragon dragon = new Dragon();

            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            dragon.Subscribe(p1);
            dragon.Subscribe(p2);

            dragon.Flying = true;

            Assert.AreEqual(Person.LookingDirectionTypes.Up, p1.LookingDirection);
            Assert.AreEqual(Person.LookingDirectionTypes.Up, p2.LookingDirection);
            Assert.AreEqual(Person.LookingDirectionTypes.Foward, p3.LookingDirection);
        }
    }
}
