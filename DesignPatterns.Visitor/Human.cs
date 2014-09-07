using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Human : IUnit
    {
        public int HitPoints { get; set; }

        public void Accept(GigaBlastProjectile projectile)
        {
            projectile.Visit(this);
        }
    }
}
