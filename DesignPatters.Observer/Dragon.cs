using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.Observer
{
    public class Dragon : IDragonSubject
    {
        private IList<IDragonObserver> observers;

        private bool flying;
        public bool Flying
        {
            get { return flying; }
            set
            {
                if (flying != value)
                {
                    flying = value;
                    Notify();
                }
            }

        }

        public Dragon()
        {
            observers = new List<IDragonObserver>();
        }

        public void Subscribe(IDragonObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IDragonObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
