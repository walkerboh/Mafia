using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Silencer : IPlayer
    {
        public Silencer(string name) : base(name, Helper.Enums.Job.SILENCER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if (!this.Hooked)
            {
                //print out that player is silenced
            }
            return null;
        }
    }
}
