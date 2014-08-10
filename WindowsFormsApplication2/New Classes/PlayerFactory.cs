using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    static class PlayerFactory
    {
        public static IPlayer CreatePlayer(String name, string job)
        {
            switch (job)
            {
                case Helper.Job.ARMORSMITH:
                    return new Armorsmith(name);
                case Helper.Job.BODYGUARD:
                    return new Bodyguard(name);
                case Helper.Job.COP:
                    return new Cop(name);
                case Helper.Job.DOCTOR:
                    return new Doctor(name);
                case Helper.Job.FOOL:
                    return new Fool(name);
                case Helper.Job.GODFATHER:
                    return new Godfather(name);
                case Helper.Job.GUNSMITH:
                    return new Gunsmith(name);
                case Helper.Job.HOOKER:
                    return new Hooker(name);
                case Helper.Job.HUNTER:
                    return new Hunter(name);
                case Helper.Job.INSANE_COP:
                    return new InsaneCop(name);
                case Helper.Job.KILLER:
                    return new Killer(name);
                case Helper.Job.MAFIA:
                    return new Mafia(name);
                case Helper.Job.SILENCER:
                    return new Silencer(name);
                case Helper.Job.VIGILANTE:
                    return new Vigilante(name);
                case Helper.Job.VILLAGER:
                    return new Villager(name);
                default:
                    return null;
            }
        }
    }
}
