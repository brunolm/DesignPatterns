using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class FireDragonBuilder : DragonBuilder
    {
        public FireDragonBuilder()
        {
            base.dragon = new Dragon();
        }

        public override void CreateElemental()
        {
            base.dragon.Elemental = Dragon.ElementalType.Fire;
        }

        public override void CreateStatus()
        {
            base.dragon.Power = 9999;
        }
    }
}
