using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class InsaneCop : IPlayer
    {
        public InsaneCop(string name) : base(name, Codes.Job.INSANECOP) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return !player.CopResult();
        }
    }
}
