using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Dragon : IDragon
    {
        public int FireDamage { get { return 1; } }

        public int WaterDamage { get { return 1; } }

        public int EarthDamage { get { return 1; } }

        public int WindDamage { get { return 1; } }
    }
}
