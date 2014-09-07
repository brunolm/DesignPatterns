using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class MysticalDragon : IDragon
    {
        public string BreathAttack()
        {
            return "Mystical Dragon Breath";
        }
    }
}
