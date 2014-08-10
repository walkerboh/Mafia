using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Fool : IPlayer
    {
        public Fool(String name) : base(name, Helper.Enums.Job.FOOL) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return null;
        }

        public override void DeathAction(bool lynched)
        {
            this.Lynched = lynched;
        }
    }
}
