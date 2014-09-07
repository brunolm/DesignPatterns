using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class DragonFactory
    {
        public enum DragonBreed
        {
            Black,
            Red,
        }

        public Dragon Create(DragonBreed breed)
        {
            switch (breed)
            {
                case DragonBreed.Black:
                    return new BlackDragon();
                case DragonBreed.Red:
                    return new RedDragon();
            }

            return null;
        }
    }
}
