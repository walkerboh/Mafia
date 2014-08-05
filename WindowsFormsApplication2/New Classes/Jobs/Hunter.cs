using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Hunter : IPlayer
    {
        public Hunter(String name) : base(name, Codes.Job.HUNTER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return null;
        }

        public override void DeathAction(bool lynched)
        {
            if (lynched)
            {
                //TODO UI element to get target
                IPlayer player = null;
                player.KillPlayer();
            }
        }
    }
}
