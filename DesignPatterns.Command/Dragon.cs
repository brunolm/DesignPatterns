using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
    public class Dragon
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
