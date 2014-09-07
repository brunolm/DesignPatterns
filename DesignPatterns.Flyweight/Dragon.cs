using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class Dragon
    {
        public string Name { get; set; }

        public Dragon()
        {
            Thread.Sleep(4);
        }
    }
}
