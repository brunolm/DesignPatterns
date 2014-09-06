using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface IDragonElementalBehavior
    {
        void ChangeElement(Dragon dragon);
    }
}
