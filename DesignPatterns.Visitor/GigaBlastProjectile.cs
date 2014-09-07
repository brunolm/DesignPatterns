using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class GigaBlastProjectile
    {
        public void Visit(Dragon dragon)
        {
            dragon.HitPoints--;
        }
        
        public void Visit(Human human)
        {
            human.HitPoints -= 1001;
        }
    }
}
