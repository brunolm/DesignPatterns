using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class DragonMoveCommand : ICommand
    {
        private Dragon dragon;
        private int x;
        private int y;

        public DragonMoveCommand(Dragon dragon, int x, int y)
        {
            this.dragon = dragon;
            this.x = x;
            this.y = y;
        }

        public void Execute()
        {
            dragon.Move(this.x, this.y);
        }
    }
}
