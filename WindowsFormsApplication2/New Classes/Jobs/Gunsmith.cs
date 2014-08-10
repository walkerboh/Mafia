using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Gunsmith : IPlayer
    {
        public Gunsmith(string name) : base(name, Helper.Enums.Job.GUNSMITH) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if(!this.Hooked)
                player.GiveItem(Helper.Enums.Item.GUN);
            return null;
        }
    }
}
