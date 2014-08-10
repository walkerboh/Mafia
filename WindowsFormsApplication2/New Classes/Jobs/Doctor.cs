using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Doctor : IPlayer
    {
        public Doctor(String name) : base(name, Helper.Enums.Job.DOCTOR) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if(!this.Hooked)
                player.Saved = true;
            return null;
        }
    }
}
