using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Recorder
    {
        private Dragon dragon;

        private List<MementoDragon> moves = new List<MementoDragon>();

        private int currentIndex = -1;

        public Recorder(Dragon dragon)
        {
            this.dragon = dragon;
        }

        public void Record()
        {
            moves.Add(dragon.Memento);
            ++currentIndex;
        }

        public void Reset()
        {
            moves.Clear();
        }

        public void Rewind()
        {
            if (currentIndex > 0)
            {
                --currentIndex;
                dragon.Memento = moves.ElementAt(currentIndex);
            }
        }

        public void Foward()
        {
            if (currentIndex < moves.Count - 1)
            {
                ++currentIndex;
                dragon.Memento = moves.ElementAt(currentIndex);
            }
        }
    }
}
