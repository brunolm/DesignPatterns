using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class WaterDragonBuilder : DragonBuilder
    {
        public WaterDragonBuilder()
        {
            base.dragon = new Dragon();
        }

        public override void CreateElemental()
        {
            base.dragon.Elemental = Dragon.ElementalType.Water;
        }

        public override void CreateStatus()
        {
            base.dragon.Power = 9999;
        }
    }
}
