using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Dragon
    {
        public IDragonState State { get; set; }

        private readonly FlyingState flying;
        private readonly WalkingState walking;

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public Dragon()
        {
            flying = new FlyingState(this);
            walking = new WalkingState(this);
        }

        public void Fly()
        {
            State = flying;
        }

        public void Walk()
        {
            State = walking;
        }
    }
}
