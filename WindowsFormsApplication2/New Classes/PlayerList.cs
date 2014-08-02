using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class PlayerList
    {
        private List<IPlayer> players = new List<IPlayer>();

        public int TotalPlayers { get { return players.Count; } }
        public int TotalAlive { get { return players.Count(player => player.Alive); } }
        public List<IPlayer> AlivePlayers { get { if (TotalAlive > 0) return players.Where(player => player.Alive).ToList(); else return null; } }
        public int VillagersAlive { get { return players.Count(player => player.Side == Codes.Side.VILLAGE); } }
        public int MafiaAlive { get { return players.Count(player => player.Side == Codes.Side.MAFIA); } }

        public Codes.Side GameOver()
        {
            if (MafiaAlive == 0)
                return Codes.Side.VILLAGE;
            else if (((MafiaAlive >= VillagersAlive) && JobCount(Codes.Job.DOCTOR) == 0) || MafiaAlive > VillagersAlive)
                return Codes.Side.MAFIA;
            else
                return Codes.Side.INVALID;
        }

        private int JobCount(Codes.Job job)
        {
            return players.Count(player => player.Job == job);
        }
    }
}
