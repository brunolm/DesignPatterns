using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Dragon : God
    {
        public override string Name
        {
            get { return "Yorae Dragon"; }
        }

        public int Attack { get; set; }

        public override God Clone()
        {
            return (God)this.MemberwiseClone();
        }
    }
}
