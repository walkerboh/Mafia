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
        List<IPlayer> jobMultiples;

        private int currentTurn;
        private int CurrentTurn { get { return currentTurn; } set { currentTurn = value % turnOrder.Count(); } }
        public bool GunActive { get { return players.Any(player => player.Job == Helper.Enums.Job.GUNSMITH); } }
        public List<IPlayer> AlivePlayers { get { return players.AlivePlayers; } }

        public MafiaGame(List<IPlayer> players)
        {
            this.players = new PlayerList(players);
            CurrentTurn = 0;
        }

        public List<PlayerInfo> GetPlayerInfo()
        {
            List<PlayerInfo> playerInfos = new List<PlayerInfo>();
            foreach (IPlayer player in players)
            {
                playerInfos.Add(new PlayerInfo(player));
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

        //TODO: Should probably return a list of strings? Read out for night actions?
        public void ResolveNightActions()
        {
            while (players.AlivePlayers.Any(player => player.Killed.Any() && player.Alive))
            {
                foreach (IPlayer player in players)
                    player.ResolveKillsSaves();
            }

            players.ClearActions();
        }

        public Helper.Enums.Side GameOver()
        {
            return players.GameOver();
        }

        public IPlayer GetFoolKillerWinner(Helper.Enums.Job job)
        {
            if (job == Helper.Enums.Job.FOOL)
                return players.GetFoolWinner();
            else
                return players.AlivePlayers.First();
        }
    }
}
