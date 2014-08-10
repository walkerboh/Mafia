using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Godfather : IPlayer
    {
        public Godfather(string name) : base(name, Helper.Enums.Job.GODFATHER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return null;
        }
    }
}
