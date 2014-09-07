using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class Dragon
    {
        private static object syncroot = new object();
        private static volatile Dragon instance;

        public static int InstanceCount { get; set; }

        public static Dragon Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncroot)
                    {
                        if (instance == null)
                        {
                            instance = new Dragon();
                        }
                    }
                }
                return instance;
            }
        }

        public int Power { get; set; }

        private Dragon()
        {
            ++InstanceCount;
        }
    }
}
