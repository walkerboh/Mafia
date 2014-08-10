using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Armorsmith : IPlayer
    {
        public Armorsmith(string name) : base(name, Helper.Enums.Job.ARMORSMITH) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if (!this.Hooked)
            {
                player.GiveItem(Helper.Enums.Item.ARMOR);
            }
            return null;
        }
    }
}
