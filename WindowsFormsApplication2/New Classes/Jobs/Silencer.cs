﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Silencer : IPlayer
    {
        public Silencer(string name) : base(name, Codes.Job.SILENCER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            //print out that player is silenced
            return null;
        }
    }
}
