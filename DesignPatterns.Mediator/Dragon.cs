using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Dragon
    {
        private DragonMediator mediator;

        public int Rage { get; set; }

        public Dragon(DragonMediator mediator)
        {
            this.mediator = mediator;
            this.mediator.OnDragonsCall += mediator_OnDragonsCall;
        }

        void mediator_OnDragonsCall(Dragon dragon)
        {
            this.Rage = dragon.Rage;
        }

        public void DragonsCall()
        {
            Rage += 100;

            mediator.DragonsCall(this);
        }
    }
}
