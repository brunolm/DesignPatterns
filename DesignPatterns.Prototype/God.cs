using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public abstract class God
    {
        public abstract string Name { get; }

        public abstract God Clone();
    }
}
