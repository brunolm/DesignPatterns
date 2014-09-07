using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class WalkStrategy : IDragonMoveStrategy
    {
        public string Move()
        {
            return "Walk";
        }
    }
}
