using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class PlayerList : IEnumerable<IPlayer>, IEnumerator<IPlayer>
    {
        private List<IPlayer> players = new List<IPlayer>();

        public int TotalPlayers { get { return players.Count; } }
        public int TotalAlive { get { return players.Count(player => player.Alive); } }
        public List<IPlayer> AlivePlayers { get { if (TotalAlive > 0) return players.Where(player => player.Alive).ToList(); else return null; } }
        public int VillagersAlive { get { return players.Count(player => player.Side != Helper.Enums.Side.MAFIA); } }
        public int MafiaAlive { get { return players.Count(player => player.Side == Helper.Enums.Side.MAFIA); } }

        int position = -1;

        public PlayerList(List<IPlayer> players)
        {
            this.players = players;
        }

        public Helper.Enums.Side GameOver()
        {
            if (MafiaAlive == 0)
                return Helper.Enums.Side.VILLAGE;
            else if (((MafiaAlive >= VillagersAlive) && JobCount(Helper.Enums.Job.DOCTOR) == 0) || MafiaAlive > VillagersAlive)
                return Helper.Enums.Side.MAFIA;
            else if (players.Any(player => player.Job == Helper.Enums.Job.FOOL && player.Lynched))
                return Helper.Enums.Side.FOOL;
            else if (AlivePlayers.Count() == 1 && AlivePlayers.Count(player => player.Job == Helper.Enums.Job.KILLER) == AlivePlayers.Count())
                return Helper.Enums.Side.KILLER;
            else
                return Helper.Enums.Side.INVALID;
        }

        private int JobCount(Helper.Enums.Job job)
        {
            return players.Count(player => player.Job == job);
        }

        public void ClearActions()
        {
            players.ForEach(player => player.ClearActions());
        }

        public IEnumerator<IPlayer> GetEnumerator()
        {
            return (IEnumerator<IPlayer>)this;
        }

        public IPlayer Current
        {
            get { return players[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return position < players.Count();
        }

        public void Reset()
        {
            position = -1;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
