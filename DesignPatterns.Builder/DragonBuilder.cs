using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public abstract class DragonBuilder
    {
        protected Dragon dragon;

        public abstract void CreateElemental();

        public abstract void CreateStatus();

        public Dragon GetResult()
        {
            return this.dragon;
        }
    }
}
