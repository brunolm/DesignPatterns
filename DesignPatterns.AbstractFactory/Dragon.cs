using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Dragon
    {
        public enum ElementalType
        {
            Fire,
            Water,
            Earth,
            Wind,
        }

        public ElementalType Elemental { get; set; }
    }
}
