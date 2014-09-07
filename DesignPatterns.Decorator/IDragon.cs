using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public interface IDragon
    {
        int FireDamage { get; }

        int WaterDamage { get; }

        int EarthDamage { get; }

        int WindDamage { get; }
    }
}
