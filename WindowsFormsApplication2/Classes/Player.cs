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
        Helper.Enums.Side side;
        Helper.Enums.Job job;
        char letter;
        bool alive = true;
        int gun = 0;
        int armor = 0;

        public string Name { get { return name; } }
        public Helper.Enums.Side Side { get { return side; } }
        public Helper.Enums.Job Job { get { return job; } }
        public bool Alive { get { return alive; } set { alive = value; } }
        public char Letter { get { return letter; } }
        public bool Gun { get { return (gun > 0 ? true : false); } }

        public Player(string name, Helper.Enums.Job job, char letter)
        {
            this.name = name;
            this.job = job;
            side = jobToSide(this.job);
            this.letter = letter;
        }

        private Helper.Enums.Side jobToSide(Helper.Enums.Job job)
        {
            switch (job)
            {
                case Helper.Enums.Job.MAFIA:
                case Helper.Enums.Job.HOOKER:
                case Helper.Enums.Job.SILENCER:
                case Helper.Enums.Job.GODFATHER:
                    return Helper.Enums.Side.MAFIA;
                case Helper.Enums.Job.FOOL:
                    return Helper.Enums.Side.FOOL;
                default:
                    return Helper.Enums.Side.VILLAGE;
            }
        }

        public void giveItem(Helper.Enums.Item item)
        {
            switch (item)
            {
                case Helper.Enums.Item.GUN:
                    gun++; break;
                case Helper.Enums.Item.ARMOR:
                    armor++; break;
            }
        }

        public bool useItem(Helper.Enums.Item item)
        {
            switch(item)
            {
                case Helper.Enums.Item.GUN:
                    if(gun > 0)
                    {
                        gun--;
                        return true;
                    }
                    else
                        return false;
                case Helper.Enums.Item.ARMOR:
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
