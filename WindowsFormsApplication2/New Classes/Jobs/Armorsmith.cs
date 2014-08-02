using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Armorsmith : IPlayer
    {
        public Armorsmith(string name) : base(name, Codes.Job.ARMORSMITH) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            player.GiveItem(Codes.Item.ARMOR);
            return null;
        }
    }
}
