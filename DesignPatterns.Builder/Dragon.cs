using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Dragon
    {
        public enum ElementalType
        {
            None,
            Fire,
            Water,
            Earth,
            Wind,
        }

        public ElementalType Elemental { get; set; }

        public int Power { get; set; }
    }
}
