using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class DragonComponent
    {
        public abstract int Attack(int reduction = 0);
    }
}
