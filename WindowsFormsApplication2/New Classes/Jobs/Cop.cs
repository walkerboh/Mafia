using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Cop : IPlayer
    {
        public Cop(String name) : base(name, Helper.Enums.Job.COP) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if(!this.Hooked)
                return player.CopResult();
            return null;
        }
    }
}
