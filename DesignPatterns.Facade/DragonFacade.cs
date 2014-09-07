using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class DragonFacade
    {
        private Dragon dragon;
        private FireEnergy fireEnergy;
        private Star star;

        public DragonFacade(Dragon dragon, FireEnergy fireEnergy, Star star)
        {
            this.dragon = dragon;
            this.fireEnergy = fireEnergy;
            this.star = star;
        }

        public string CreateNuclearFusion()
        {
            if (this.dragon.Power > 9000 && this.fireEnergy.Intencity > 10)
            {
                this.star.Radius = 0;
                return "Star has been consumed to create Nuclear Fusion";
            }

            return null;
        }
    }
}
