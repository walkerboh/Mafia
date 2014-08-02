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
            //TODO ensure bodyguard is last save and kill character
            if (player.Saved)
                return null;
            else if (player.Killed == null)
                return null;
            Random rand = new Random();
            if (rand.NextDouble() < 0.5)
                KillPlayer();
            else
                player.Killed.KillPlayer();
            return null;
        }
    }
}
