using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    static class PlayerFactory
    {
        public static IPlayer CreatePlayer(String name, Codes.Job job)
        {
            switch (job)
            {
                case Codes.Job.VILLAGER:
                    return new Villager(name);
                case Codes.Job.DOCTOR:
                    return new Doctor(name);
                case Codes.Job.COP:
                    return new Cop(name);
                case Codes.Job.MAFIA:
                    return new Mafia(name);
                default:
                    return null;
            }
        }
    }
}
