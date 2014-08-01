using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Classes
{
    class Player
    {
        string name;
        Codes.Side side;
        Codes.Job job;
        char letter;
        bool alive = true;
        int gun = 0;
        int armor = 0;

        public string Name { get { return name; } }
        public Codes.Side Side { get { return side; } }
        public Codes.Job Job { get { return job; } }
        public bool Alive { get { return alive; } set { alive = value; } }
        public char Letter { get { return letter; } }
        public bool Gun { get { return (gun > 0 ? true : false); } }

        public Player(string name, Codes.Job job, char letter)
        {
            this.name = name;
            this.job = job;
            side = jobToSide(this.job);
            this.letter = letter;
        }

        private Codes.Side jobToSide(Codes.Job job)
        {
            switch (job)
            {
                case Codes.Job.MAFIA:
                case Codes.Job.HOOKER:
                case Codes.Job.SILENCER:
                case Codes.Job.GODFATHER:
                    return Codes.Side.MAFIA;
                case Codes.Job.FOOL:
                    return Codes.Side.OTHER;
                default:
                    return Codes.Side.VILLAGE;
            }
        }

        public void giveItem(Codes.Item item)
        {
            switch (item)
            {
                case Codes.Item.GUN:
                    gun++; break;
                case Codes.Item.ARMOR:
                    armor++; break;
            }
        }

        public bool useItem(Codes.Item item)
        {
            switch(item)
            {
                case Codes.Item.GUN:
                    if(gun > 0)
                    {
                        gun--;
                        return true;
                    }
                    else
                        return false;
                case Codes.Item.ARMOR:
                    if (armor > 0)
                    {
                        armor--;
                        return true;
                    }
                    else
                        return false;
                default:
                    return false;
            }
        }
    }
}
