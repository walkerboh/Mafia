using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Hooker : IPlayer
    {
        public Hooker(string name) : base(name, Helper.Enums.Job.HOOKER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            player.Hooked = true;
            return null;
        }
    }
}
