using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Universe : IUniverse
    {
        public bool Create()
        {
            return true;
        }
    }
}
