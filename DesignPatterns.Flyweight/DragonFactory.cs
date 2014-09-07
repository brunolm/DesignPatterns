using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class DragonFactory : IDragonFactory
    {
        private readonly ConcurrentDictionary<string, Dragon> cache = new ConcurrentDictionary<string, Dragon>();

        public Dragon GetDragon(string name)
        {
            return this.cache.GetOrAdd(name, (v) => new Dragon { Name = v });
        }
    }
}
