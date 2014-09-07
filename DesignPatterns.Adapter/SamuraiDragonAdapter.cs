using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SamuraiDragonAdapter : IDragon
    {
        private Samurai samurai;

        public SamuraiDragonAdapter(Samurai samurai)
        {
            this.samurai = samurai;
        }

        public string BreathAttack()
        {
            this.samurai.SlashAttack();

            return "Slash Dragon Breath";
        }
    }
}
