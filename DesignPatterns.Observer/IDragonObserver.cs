using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface IDragonObserver
    {
        void Update(Dragon dragon);
    }
}
