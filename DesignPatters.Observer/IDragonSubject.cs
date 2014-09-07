using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.Observer
{
    public interface IDragonSubject
    {
        void Subscribe(IDragonObserver observer);
        void Unsubscribe(IDragonObserver observer);
        void Notify();
    }
}
