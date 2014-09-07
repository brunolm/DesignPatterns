using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Singleton;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPatterns
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void ThereCanOnlyBeOne()
        {
            // var dragon = new Dragon(); // private

            Dragon x;
            Parallel.For(0, 100, (i) =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    x = Dragon.Instance;
                });
            });

            var dragon = Dragon.Instance;

            dragon.Power = 100;

            Assert.AreEqual(100, dragon.Power);

            var dragon2 = Dragon.Instance;

            Assert.AreEqual(100, dragon2.Power);

            Assert.AreEqual(1, Dragon.InstanceCount);
        }
    }
}
