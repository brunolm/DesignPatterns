using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DragonWaterUpgrade : DragonDecorator
    {
        public DragonWaterUpgrade(IDragon dragon)
            : base(dragon)
        {

        }

        public override int WaterDamage
        {
            get
            {
                return base.WaterDamage + 10;
            }
        }
    }
}
