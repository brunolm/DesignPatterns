using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DragonDecorator : IDragon
    {
        private IDragon dragon;

        public virtual int FireDamage
        {
            get { return dragon.FireDamage; }
        }

        public virtual int WaterDamage
        {
            get { return dragon.WaterDamage; }
        }

        public virtual int EarthDamage
        {
            get { return dragon.EarthDamage; }
        }

        public virtual int WindDamage
        {
            get { return dragon.WindDamage; }
        }

        public DragonDecorator(IDragon dragon)
        {
            this.dragon = dragon;
        }
    }
}
