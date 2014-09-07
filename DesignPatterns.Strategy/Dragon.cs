using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Dragon
    {
        public IDragonMoveStrategy MoveStrategy { get; set; }

        public Dragon()
        {
            MoveStrategy = new FlyStrategy();
        }

        public string Move()
        {
            return MoveStrategy.Move();
        }
    }
}
