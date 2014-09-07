using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Dragon : DragonComponent
    {
        public override int Attack(int reduction = 0)
        {
            return 100 - reduction;
        }
    }
}
