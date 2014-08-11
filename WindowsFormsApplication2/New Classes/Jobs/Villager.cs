using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Villager : IPlayer
    {
        public Villager(string name) : base(name, Helper.Enums.Job.VILLAGER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            player.KillPlayer(true);
            return null;
        }
    }
}
