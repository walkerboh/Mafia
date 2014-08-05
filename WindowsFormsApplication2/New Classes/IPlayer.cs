using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    abstract class IPlayer
    {
        private static int IDCounter = 0;

        private int id;
        private string name;
        private bool alive;
        private int gun, armor;
        private Codes.Side side;
        private Codes.Job job;
        private List<IPlayer> killed;
        private List<Bodyguard> guarded;
        private bool saved;
        private bool hooked;

        public bool Alive { get { return alive; } set { alive = value; } }
        public string Name { get { return name; } }
        public int ID { get { return id; } }
        public Codes.Side Side { get { return side; } }
        public Codes.Job Job { get { return job; } }
        public int Gun { get { return gun; } }
        public bool Lynched { get; set; }
        public List<IPlayer> Killed { get { return killed; } set { killed = value; } }
        public List<Bodyguard> Guarded { get { return guarded; } set { guarded = value; } }
        public bool Saved { get { return saved; } set { saved = value; } }
        public bool Hooked { get { return hooked; } set { hooked = value; } }

        public IPlayer(string name, Codes.Job job)
        {
            id = ++IDCounter;
            this.name = name;
            this.job = job;
            side = JobToSide(job);
            alive = true;
            gun = armor = 0;
        }

        private Codes.Side JobToSide(Codes.Job job)
        {
            switch (job)
            {
                case Codes.Job.MAFIA:
                case Codes.Job.HOOKER:
                case Codes.Job.GODFATHER:
                case Codes.Job.SILENCER:
                    return Codes.Side.MAFIA;
                case Codes.Job.FOOL:
                    return Codes.Side.FOOL;
                case Codes.Job.KILLER:
                    return Codes.Side.KILLER;
                default:
                    return Codes.Side.VILLAGE;
            }
        }

        public void ResolveKillsSaves()
        {
            if (!killed.Any() || saved)
            {
                killed.Clear();
            }
            while (killed.Any() && guarded.Any())
            {
                Random rand = new Random();
                if (rand.NextDouble() < 0.5)
                    guarded.First().Killed.Add(killed.First());
                else
                    killed.First().Killed.Add(guarded.First());

                killed.Remove(killed.First());
                guarded.Remove(guarded.First());
            }
            if (killed.Any())
                KillPlayer();
        }

        public void KillPlayer(bool lynched = false)
        {
            alive = false;
            DeathAction(lynched);
        }

        public abstract bool? TakeAction(ref IPlayer player);

        public virtual void DeathAction(bool lynched)
        {
            return;
        }

        public void ClearActions()
        {
            killed.Clear();
            guarded.Clear();
            saved = false;
            hooked = false;
        }

        public bool CopResult()
        {
            return side == Codes.Side.MAFIA && job != Codes.Job.GODFATHER;
        }

        public void GiveItem(Codes.Item item)
        {
            if (item == Codes.Item.ARMOR)
                armor++;
            else if (item == Codes.Item.GUN)
                gun++;
        }

        public bool UseItem(Codes.Item item)
        {
            if(item == Codes.Item.ARMOR)
            {
                if (armor > 0)
                {
                    armor--;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (gun > 0)
                {
                    gun--;
                    return true;
                }
                else
                    return false;
            }
        }
    }
}