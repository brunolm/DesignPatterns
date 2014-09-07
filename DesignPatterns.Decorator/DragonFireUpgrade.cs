using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DragonFireUpgrade : DragonDecorator
    {
        public DragonFireUpgrade(IDragon dragon)
            : base(dragon)
        {

        }

        public override int FireDamage
        {
            get
            {
                return base.FireDamage + 10;
            }
        }
    }
}
