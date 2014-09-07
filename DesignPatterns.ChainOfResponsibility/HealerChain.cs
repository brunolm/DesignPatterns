using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class HealerChain
    {
        public HealerChain NextLink { get; set; }

        public virtual void Heal(Dragon dragon)
        {
            if (NextLink != null)
                NextLink.Heal(dragon);
        }
    }
}
