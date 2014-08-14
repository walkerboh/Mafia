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
        private Helper.Enums.Side side;
        private Helper.Enums.Job job;
        private List<IPlayer> killed;
        private List<Bodyguard> guarded;
        private bool saved;
        private bool hooked;

        public bool Alive { get { return alive; } set { alive = value; } }
        public string Name { get { return name; } }
        public int ID { get { return id; } }
        public Helper.Enums.Side Side { get { return side; } }
        public Helper.Enums.Job Job { get { return job; } }
        public int Gun { get { return gun; } }
        public int Armor { get { return armor; } }
        public bool Lynched { get; set; }
        public List<IPlayer> Killed { get { return killed; } set { killed = value; } }
        public List<Bodyguard> Guarded { get { return guarded; } set { guarded = value; } }
        public bool Saved { get { return saved; } set { saved = value; } }
        public bool Hooked { get { return hooked; } set { hooked = value; } }

        public IPlayer(string name, Helper.Enums.Job job)
        {
            id = ++IDCounter;
            this.name = name;
            this.job = job;
            side = JobToSide(job);
            alive = true;
            gun = armor = 0;
            killed = new List<IPlayer>();
            guarded = new List<Bodyguard>();
        }

        private Helper.Enums.Side JobToSide(Helper.Enums.Job job)
        {
            switch (job)
            {
                case Helper.Enums.Job.MAFIA:
                case Helper.Enums.Job.HOOKER:
                case Helper.Enums.Job.GODFATHER:
                case Helper.Enums.Job.SILENCER:
                    return Helper.Enums.Side.MAFIA;
                case Helper.Enums.Job.FOOL:
                    return Helper.Enums.Side.FOOL;
                case Helper.Enums.Job.KILLER:
                    return Helper.Enums.Side.KILLER;
                default:
                    return Helper.Enums.Side.VILLAGE;
            }
        }

        public void ResolveKillsSaves()
        {
            if (alive)
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
            return side == Helper.Enums.Side.MAFIA && job != Helper.Enums.Job.GODFATHER;
        }

        public void GiveItem(Helper.Enums.Item item)
        {
            if (item == Helper.Enums.Item.ARMOR)
                armor++;
            else if (item == Helper.Enums.Item.GUN)
                gun++;
        }

        public bool UseItem(Helper.Enums.Item item)
        {
            if (item == Helper.Enums.Item.ARMOR)
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