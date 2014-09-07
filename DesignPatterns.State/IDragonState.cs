using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.State
{
    public interface IDragonState
    {
        bool Flying { get; }

        bool Walking { get; }

        int Speed { get; }

        void Move(int x, int y);
    }
}
