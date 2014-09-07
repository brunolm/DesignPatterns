using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Dragon
    {
        public string Move(IMoveBridge moveBridge)
        {
            return moveBridge.Move();
        }
    }
}
