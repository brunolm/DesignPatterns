using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class DragonMediator : IDragonMediator
    {
        public delegate void DragonsCallEvent(Dragon dragon);
        public event DragonsCallEvent OnDragonsCall;

        public void DragonsCall(Dragon dragon)
        {
            if (OnDragonsCall != null)
                OnDragonsCall(dragon);
        }
    }
}
