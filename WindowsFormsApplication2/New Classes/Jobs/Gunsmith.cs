using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Gunsmith : IPlayer
    {
        public Gunsmith(string name) : base(name, Codes.Job.GUNSMITH) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            player.GiveItem(Codes.Item.GUN);
            return null;
        }
    }
}
