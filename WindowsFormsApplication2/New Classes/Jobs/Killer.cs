using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Killer : IPlayer
    {
        public Killer(String name) : base(name, Codes.Job.KILLER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if (!this.Hooked)
                player.Killed.Add(this);
            return null;
        }
    }
}
