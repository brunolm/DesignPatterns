using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IUnit
    {
        int HitPoints { get; set; }

        void Accept(GigaBlastProjectile projectile);
    }
}
