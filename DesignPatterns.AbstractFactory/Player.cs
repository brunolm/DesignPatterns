using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Player
    {
        public Dragon Dragon { get; set; }

        public Player(IElementalFactory elementalFactory)
        {
            Dragon = elementalFactory.CreateDragon();
        }
    }
}
