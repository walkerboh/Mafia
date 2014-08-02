﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class Villager : IPlayer
    {
        public Villager(string name) : base(name, Codes.Job.VILLAGER) { }

        public override bool? TakeAction(ref IPlayer player)
        {
            return null;
        }
    }
}