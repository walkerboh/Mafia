﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class InsaneCop : IPlayer
    {
        public InsaneCop(string name) : base(name, Helper.Enums.Job.INSANECOP) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            if(!this.Hooked)
                return !player.CopResult();
            return null;
        }
    }
}
