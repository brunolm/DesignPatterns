using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DragonEarthUpgrade : DragonDecorator
    {
        public DragonEarthUpgrade(IDragon dragon)
            : base(dragon)
        {

        }

        public override int EarthDamage
        {
            get
            {
                return base.EarthDamage + 10;
            }
        }
    }
}
