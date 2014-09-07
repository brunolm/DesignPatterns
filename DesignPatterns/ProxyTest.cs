using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Proxy;

namespace DesignPatterns
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void CreateUniverseUnderAgeFalse()
        {
            var dragon = new Dragon();
            var proxy = new UniverseProxy(dragon);

            Assert.IsFalse(proxy.Create());
        }


        [TestMethod]
        public void CreateUniverseAboveAgeTrue()
        {
            var dragon = new Dragon { Age = 1000 };
            var proxy = new UniverseProxy(dragon);

            Assert.IsTrue(proxy.Create());
        }
    }
}
