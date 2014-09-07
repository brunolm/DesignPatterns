using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.Observer
{
    public interface IDragonObserver
    {
        void Update(Dragon dragon);
    }
}
