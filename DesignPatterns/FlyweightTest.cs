using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using DesignPatterns.Flyweight;
using System.Diagnostics;

namespace DesignPatterns
{
    [TestClass]
    public class FlyweightTest
    {
        [TestMethod]
        public void FlyweightSavesTime()
        {
            Stopwatch fly = new Stopwatch();
            Stopwatch non = new Stopwatch();

            fly.Start();
            var df = new DragonFactory();

            Parallel.For(0, 100, (i) =>
            {
                var n = i % 10;
                var dragon = df.GetDragon("Dragon " + n);
            });
            fly.Stop();

            non.Start();
            Parallel.For(0, 100, (i) =>
            {
                var n = i % 10;
                var dragon = new Dragon { Name = "Dragon " + n };
            });
            non.Stop();

            Assert.IsTrue(fly.ElapsedMilliseconds < non.ElapsedMilliseconds);
        }
    }
}
