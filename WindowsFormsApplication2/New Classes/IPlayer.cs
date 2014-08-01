using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class IPlayer
    {
        private static int IDCounter = 0;

        int ID;
        string name;
        bool alive;
        int gun, armor;
        Codes.Side side;
        Codes.Job job;

        public IPlayer(string name, Codes.Job job)
        {
            ID = ++IDCounter;
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
                    return Codes.Side.OTHER;
                default:
                    return Codes.Side.VILLAGE;
            }
        }

        public virtual void takeAction(ref IPlayer player);

        public void giveItem(Codes.Item item)
        {
            if (item == Codes.Item.ARMOR)
                armor++;
            else if (item == Codes.Item.GUN)
                gun++;
        }

        public bool useItem(Codes.Item item)
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