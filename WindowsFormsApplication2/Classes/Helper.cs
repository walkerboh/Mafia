using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    static class Helper
    {
        public static class Job
        {
            public const string VILLAGER = "Villager";
            public const string DOCTOR = "Doctor";
            public const string COP = "Cop";
            public const string INSANE_COP = "Insane Cop";
            public const string BODYGUARD = "Bodyguard";
            public const string ARMORSMITH = "Armorsmith";
            public const string GUNSMITH = "Gunsmith";
            public const string VIGILANTE = "Vigilante";
            public const string HUNTER = "Hunter";
            public const string FOOL = "Fool";
            public const string KILLER = "Killer";
            public const string MAFIA = "Mafia";
            public const string SILENCER = "Silencer";
            public const string HOOKER = "Hooker";
            public const string GODFATHER = "Godfather";

            public static readonly string[] CLASSIC = new string[] { VILLAGER, DOCTOR, COP, MAFIA };
            public static readonly string[] EXTENDED = new string[] {VILLAGER, DOCTOR, COP, INSANE_COP, BODYGUARD, ARMORSMITH, GUNSMITH, VIGILANTE, HUNTER, FOOL,
                                                            KILLER, MAFIA, SILENCER, HOOKER, GODFATHER};

            public static string JobToString(Helper.Enums.Job job)
            {
                switch (job)
                {
                    case Enums.Job.ARMORSMITH:
                        return VILLAGER;
                    case Enums.Job.BODYGUARD:
                        return BODYGUARD;
                    case Enums.Job.COP:
                        return COP;
                    case Enums.Job.DOCTOR:
                        return DOCTOR;
                    case Enums.Job.FOOL:
                        return FOOL;
                    case Enums.Job.GODFATHER:
                        return GODFATHER;
                    case Enums.Job.GUNSMITH:
                        return GUNSMITH;
                    case Enums.Job.HOOKER:
                        return HOOKER;
                    case Enums.Job.HUNTER:
                        return HUNTER;
                    case Enums.Job.INSANECOP:
                        return INSANE_COP;
                    case Enums.Job.KILLER:
                        return KILLER;
                    case Enums.Job.MAFIA:
                        return MAFIA;
                    case Enums.Job.SILENCER:
                        return SILENCER;
                    case Enums.Job.VIGILANTE:
                        return VIGILANTE;
                    default:
                        return VILLAGER;
                }
            }
        }

        public static class Enums
        {
            public enum Side { MAFIA, VILLAGE, FOOL, KILLER, INVALID }
            public enum Job { MAFIA, HOOKER, SILENCER, DOCTOR, COP, INSANECOP, BODYGUARD, ARMORSMITH, GUNSMITH, VIGILANTE, KILLER, FOOL, GODFATHER, HUNTER, VILLAGER }
            public enum Item { GUN, ARMOR }
        }
    }
}
