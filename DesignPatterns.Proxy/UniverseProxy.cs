using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class UniverseProxy : IUniverse
    {
        public IDragon Dragon { get; set; }

        public UniverseProxy(IDragon dragon)
        {
            Dragon = dragon;
        }

        public bool Create()
        {
            if (Dragon.Age > 500)
            {
                var universe = new Universe();
                return universe.Create();
            }

            return false;
        }
    }
}
