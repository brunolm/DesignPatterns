using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class DragonComposite : DragonComponent
    {
        public List<Dragon> Dragons { get; set; }

        public DragonComposite()
        {
            Dragons = new List<Dragon>();
        }

        public void Add(Dragon dragon)
        {
            Dragons.Add(dragon);
        }

        public void Remove(Dragon dragon)
        {
            Dragons.Remove(dragon);
        }

        public override int Attack(int reduction = 0)
        {
            int sumDamage = 0;

            foreach (var dragon in Dragons)
            {
                sumDamage += dragon.Attack(reduction);
                reduction += 10;
            }

            return sumDamage;
        }
    }
}
