using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.Observer
{
    public class Person : IDragonObserver
    {
        public enum LookingDirectionTypes
        {
            Foward,
            Up,
            Down,
            Left,
            Right,
        }

        public LookingDirectionTypes LookingDirection { get; set; }

        public void Update(Dragon dragon)
        {
            if (dragon.Flying)
                LookingDirection = Person.LookingDirectionTypes.Up;
            else
                LookingDirection = LookingDirectionTypes.Foward;
        }
    }
}
