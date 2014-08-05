using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Vigilante : IPlayer
    {
        public Vigilante(String name) : base(name, Codes.Job.VIGILANTE) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if (!this.Hooked)
                player.Killed.Add(this);
            return null;
        }
    }
}
