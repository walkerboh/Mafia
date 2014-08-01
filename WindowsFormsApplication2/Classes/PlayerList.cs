using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Classes
{
    class PlayerList
    {
        private List<Player> players = new List<Player>();
        private List<Player> alive = new List<Player>();
        private int[] jobCounts = new int[15];
        int mafiaAlive = 0;
        int villageAlive = 0;
        int totalPlayers = 0;
        int playersAlive = 0;
        Codes.Job[] req = {Codes.Job.ARMORSMITH, Codes.Job.BODYGUARD, Codes.Job.COP, Codes.Job.DOCTOR, Codes.Job.GUNSMITH, Codes.Job.HOOKER, Codes.Job.HUNTER, Codes.Job.INSANECOP, Codes.Job.KILLER,
                              Codes.Job.SILENCER, Codes.Job.VIGILANTE};

        public int VillageAlive { get { return villageAlive; } }
        public int MafiaAlive { get { return mafiaAlive; } }
        public int TotalPlayers { get { return totalPlayers; } }
        public int PlayersAlive { get { return alive.Count; } }
        public int Count { get { return players.Count; } }
        public List<Player> Alive { get { return alive; } }

        public void initialize()
        {
            for (int i = 0; i < jobCounts.Length; i++)
                jobCounts[i] = 0;
        }

        public int gameOver()
        {
            if (mafiaAlive == 0 )
                return 1;
            if(((mafiaAlive >= villageAlive) && countJobPresent(Codes.Job.DOCTOR) == 0) || mafiaAlive > villageAlive)
                return 2;
            else
                return 0;
        }

        public void addPlayer(string name, Codes.Job job)
        {
            char letter = ' ';
            if (req.Contains(job))
                letter = (char)((int)'A' + (jobCounts[(int)job]++));
            Player newPlayer = new Player(name, job, letter);
            players.Add(newPlayer);
            alive.Add(newPlayer);
            if (newPlayer.Side == Codes.Side.MAFIA)
                mafiaAlive++;
            else
                villageAlive++;
            totalPlayers++;
        }

        public Player this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
                players[index] = value;
            }
        }

        public int getPlayer(string name)
        {
            foreach (Player p in players)
            {
                if (p.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                    return players.IndexOf(p);
            }
            return -1;
        }

        public bool killPlayer(int index)
        {
            if (players[index].Alive)
            {
                players[index].Alive = false;
                if (players[index].Side == Codes.Side.MAFIA)
                {
                    mafiaAlive--;
                    playersAlive--;
                }
                else
                {
                    villageAlive--;
                    playersAlive--;
                }
                return true;
            }
            else
                return false;
        }

        public int countJobPresent(Codes.Job job)
        {
            int count = 0;
            foreach (Player p in players)
                if (p.Job == job)
                    count++;
            return count;
        }

        public List<string> getPlayerStatus()
        {
            List<string> text = new List<string>();
            foreach (Player p in players)
            {
                text.Add(p.Name + " - " + (p.Alive ? "ALIVE" : "DEAD") + " - " + p.Job + (p.Letter == ' ' ? string.Empty : " " + p.Letter) + " - " + p.Side + "\n");
            }
            return text;
        }

        public void sort()
        {
            players.TrimExcess();
            for (int j = 0; j < players.Count; j++)
            {
                for (int i = 0; i < players.Count - 1; i++)
                {
                    if (players[i].Job > players[i + 1].Job)
                    {
                        Player temp = players[i + 1];
                        players[i + 1] = players[i];
                        players[i] = temp;
                    }
                }
            }
        }

        public int skipToNextJob(int index)
        {
            while (players[index].Job == players[(index + 1) % players.Count].Job)
                index = (index + 1) % players.Count;
            return index;
        }

        public void refreshAlive()
        {
            alive.Clear();
            for (int i = 0; i < players.Count; i++)
                if (players[i].Alive)
                    alive.Add(players[i]);
        }

        public string killRandomMafia()
        {
            List<string> maf = new List<string>();
            foreach (Player p in players)
                if (p.Alive)
                    maf.Add(p.Name);
            Random rand = new Random();
            int choice = (rand.Next()) % maf.Count;
            killPlayer(getPlayer(maf[choice]));
            return maf[choice];
        }

        public string randomMafia()
        {
            List<string> maf = new List<string>();
            foreach (Player p in players)
                if (p.Alive)
                    maf.Add(p.Name);
            Random rand = new Random();
            int choice = (rand.Next()) % maf.Count;
            return maf[choice];
        }

        public bool nameUsed(string name)
        {
            return players.Any(player => player.Name == name);
        }
    }
}