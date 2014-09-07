using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Dragon
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public MementoDragon Memento
        {
            get{ return new MementoDragon(PositionX, PositionY); }
            set
            {
                this.PositionX = value.PositionX;
                this.PositionY = value.PositionY;
            }
        }
    }
}
