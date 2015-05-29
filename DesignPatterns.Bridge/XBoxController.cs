using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class XBoxController : Controller
    {
        public XBoxController(PlayableEntity entity)
            : base(entity)
        {

        }

        public override string ButtonA()
        {
            return entity.HandleA();
        }

        public override string ButtonB()
        {
            return entity.HandleB();
        }
    }
}
