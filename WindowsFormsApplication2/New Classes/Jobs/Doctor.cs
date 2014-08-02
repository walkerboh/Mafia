using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Doctor : IPlayer
    {
        public Doctor(String name) : base(name, Codes.Job.DOCTOR) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            player.Saved = true;
            return null;
        }
    }
}
