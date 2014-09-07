using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class FlyMoveBridge : IMoveBridge
    {
        public string Move()
        {
            return "Flying";
        }
    }
}
