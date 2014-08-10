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
        Helper.Enums.Job[] turnOrder = {Helper.Enums.Job.MAFIA, Helper.Enums.Job.HOOKER, Helper.Enums.Job.SILENCER, Helper.Enums.Job.DOCTOR, Helper.Enums.Job.COP, Helper.Enums.Job.INSANECOP, 
                                    Helper.Enums.Job.BODYGUARD, Helper.Enums.Job.ARMORSMITH, Helper.Enums.Job.GUNSMITH, Helper.Enums.Job.VIGILANTE, Helper.Enums.Job.KILLER};
        bool end, gunActive;

        public MafiaGame(List<IPlayer> players)
        {
            this.players = new PlayerList(players);
            end = gunActive = false;
        }

        public List<object[]> GetPlayerInfo()
        {
            List<object[]> playerInfos = new List<object[]>();
            foreach (IPlayer player in players)
            {
                playerInfos.Add(new object[] { player.ID, player.Name, player.Side, player.Job, player.Alive, player.Gun, player.Armor });
            }

            return playerInfos;
        }
    }
}
