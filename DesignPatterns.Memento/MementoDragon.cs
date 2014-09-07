using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Memento
{
    public class MementoDragon
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public MementoDragon(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
