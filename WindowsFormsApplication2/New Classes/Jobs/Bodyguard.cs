using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Bodyguard : IPlayer
    {
        public Bodyguard(string name) : base(name, Codes.Job.BODYGUARD) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if (!this.Hooked)
                player.Guarded.Add(this);
            return null;
        }
    }
}
