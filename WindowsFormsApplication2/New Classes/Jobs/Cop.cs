using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Cop : IPlayer
    {
        public Cop(String name) : base(name, Codes.Job.COP) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return player.CopResult();
        }
    }
}
