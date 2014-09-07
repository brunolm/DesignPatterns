using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class DragonBuildDirector
    {
        public void BuildType1(DragonBuilder dragonBuilder)
        {
            dragonBuilder.CreateElemental();
            dragonBuilder.CreateStatus();
        }

        public void BuildType2(DragonBuilder dragonBuilder)
        {
            dragonBuilder.CreateElemental();
        }
    }
}
