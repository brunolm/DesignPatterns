using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class GodHealer: HealerChain
    {
        public override void Heal(Dragon dragon)
        {
            if (dragon.Health < 9999)
            {
                dragon.Health++;
                Heal(dragon);
            }
            else
                base.Heal(dragon);
        }
    }
}
