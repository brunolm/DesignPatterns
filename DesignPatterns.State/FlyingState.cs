using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class FlyingState : IDragonState
    {
        private Dragon dragon;

        public FlyingState(Dragon dragon)
        {
            this.dragon = dragon;
        }

        public bool Flying
        {
            get { return true; }
        }

        public bool Walking
        {
            get { return false; }
        }

        public int Speed
        {
            get { return 1000; }
        }

        public void Move(int x, int y)
        {
            dragon.PositionX = x;
            dragon.PositionY = y;
        }
    }
}
