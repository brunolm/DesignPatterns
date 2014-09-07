using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Dragon : IDragon
    {
        public string BreathAttack()
        {
            return "Dragon Breath";
        }
    }
}
