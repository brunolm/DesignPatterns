using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Dragon
    {
        public int Health { get; set; }

        public Dragon()
        {
            Health = 1;
        }
    }
}
