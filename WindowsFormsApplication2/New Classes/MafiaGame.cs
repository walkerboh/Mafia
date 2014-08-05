using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class MafiaGame
    {
        PlayerList players;
        Codes.Job[] turnOrder = {Codes.Job.MAFIA, Codes.Job.HOOKER, Codes.Job.SILENCER, Codes.Job.DOCTOR, Codes.Job.COP, Codes.Job.INSANECOP, 
                                    Codes.Job.BODYGUARD, Codes.Job.ARMORSMITH, Codes.Job.GUNSMITH, Codes.Job.VIGILANTE, Codes.Job.KILLER};
        bool end, gunActive;
        MainForm game;

        public MafiaGame(MainForm game)
        {
            players = new PlayerList();
            end = gunActive = false;
            this.game = game;
        }
    }
}
