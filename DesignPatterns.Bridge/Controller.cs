using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Controller
    {
        protected PlayableEntity entity;

        public Controller(PlayableEntity entity)
        {
            this.entity = entity;
        }
        public abstract string ButtonA();
        public abstract string ButtonB();
    }
}
