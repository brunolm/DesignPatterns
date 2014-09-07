using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class WalkingState : IDragonState
    {
        private Dragon dragon;
        public WalkingState(Dragon dragon)
        {
            this.dragon = dragon;
        }

        public bool Flying
        {
            get { return false; }
        }

        public bool Walking
        {
            get { return true; }
        }

        public int Speed
        {
            get { return 10; }
        }

        public void Move(int x, int y)
        {
            dragon.PositionX = x;
            dragon.PositionY = y;
        }
    }
}
