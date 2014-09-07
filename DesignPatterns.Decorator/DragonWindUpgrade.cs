using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DragonWindUpgrade : DragonDecorator
    {
        public DragonWindUpgrade(IDragon dragon)
            : base(dragon)
        {

        }

        public override int WindDamage
        {
            get
            {
                return base.WindDamage + 10;
            }
        }
    }
}
