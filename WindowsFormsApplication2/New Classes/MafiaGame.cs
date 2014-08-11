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
        bool end;
        List<IPlayer> jobMultiples;

        private int currentTurn;
        private int CurrentTurn { get { return currentTurn; } set { currentTurn = value % turnOrder.Count(); } }
        public bool GunActive { get { return players.Any(player => player.Job == Helper.Enums.Job.GUNSMITH); } }
        public List<IPlayer> AlivePlayers { get { return players.AlivePlayers; } }

        public MafiaGame(List<IPlayer> players)
        {
            this.players = new PlayerList(players);
            end = false;
            CurrentTurn = 0;
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

        public IPlayer getCurrentTurn()
        {
            IPlayer returnPlayer;

            if (jobMultiples != null && jobMultiples.Count() > 0)
            {
                returnPlayer = jobMultiples.First();
                jobMultiples.Remove(returnPlayer);
                return returnPlayer;
            }

            while (players.GetJobCount(turnOrder[CurrentTurn]) == 0)
                CurrentTurn++;

            List<IPlayer> jobPlayers = players.GetPlayersOfJob(turnOrder[CurrentTurn]);

            if (jobPlayers.Count() > 1)
            {
                if (jobPlayers.First().Job == Helper.Enums.Job.MAFIA)
                {
                    returnPlayer = jobPlayers[new Random().Next(jobPlayers.Count)];
                    currentTurn++;
                }
                else if (jobPlayers.First().Job == Helper.Enums.Job.VILLAGER)
                {
                    //TODO swap out to UI so that we can get a read out.
                    ResolveNightActions();
                    returnPlayer = jobPlayers[new Random().Next(jobPlayers.Count)];
                    currentTurn++;
                }
                else
                {
                    returnPlayer = jobPlayers.First();
                    jobPlayers.Remove(returnPlayer);
                    jobMultiples = jobPlayers;
                }
            }
            else
            {
                returnPlayer = jobPlayers.First();
                currentTurn++;
            }

            return returnPlayer;
        }

        private void ResolveNightActions()
        {
            while (players.AlivePlayers.Any(player => player.Killed.Any() && player.Alive))
            {
                foreach (IPlayer player in players)
                    player.ResolveKillsSaves();
            }

            players.ClearActions();
        }
    }
}
