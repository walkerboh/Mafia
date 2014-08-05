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
                case Codes.Job.ARMORSMITH:
                    return new Armorsmith(name);
                case Codes.Job.BODYGUARD:
                    return new Bodyguard(name);
                case Codes.Job.COP:
                    return new Cop(name);
                case Codes.Job.DOCTOR:
                    return new Doctor(name);
                case Codes.Job.FOOL:
                    return new Fool(name);
                case Codes.Job.GODFATHER:
                    return new Godfather(name);
                case Codes.Job.GUNSMITH:
                    return new Gunsmith(name);
                case Codes.Job.HOOKER:
                    return new Hooker(name);
                case Codes.Job.HUNTER:
                    return new Hunter(name);
                case Codes.Job.INSANECOP:
                    return new InsaneCop(name);
                case Codes.Job.KILLER:
                    return new Killer(name);
                case Codes.Job.MAFIA:
                    return new Mafia(name);
                case Codes.Job.SILENCER:
                    return new Silencer(name);
                case Codes.Job.VIGILANTE:
                    return new Vigilante(name);
                case Codes.Job.VILLAGER:
                    return new Villager(name);
                default:
                    return null;
            }
        }
    }
}
