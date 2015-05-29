using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class PSController : Controller
    {
        public PSController(PlayableEntity entity)
            : base(entity)
        {

        }

        public override string ButtonA()
        {
            return entity.HandleB();
        }

        public override string ButtonB()
        {
            return entity.HandleA();
        }
    }
}
