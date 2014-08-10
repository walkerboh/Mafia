using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Mafia : IPlayer
    {
        public Mafia(string name) : base(name, Helper.Enums.Job.MAFIA) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            //TODO ensure that a random Mafia is called every turn
            player.Killed.Add(this);
            return null;
        }
    }
}
