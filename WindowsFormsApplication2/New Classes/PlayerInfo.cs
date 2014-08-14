using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    class PlayerInfo
    {
        private string name, id, job, side, alive, gun, armor;

        public string Name { get { return name; } set { name = value; } }
        public string ID { get { return id; } set { id = value; } }
        public string Job { get { return job; } set { job = value; } }
        public string Side { get { return side; } set { side = value; } }
        public string Alive { get { return alive; } set { alive = value; } }
        public string Gun { get { return gun; } set { gun = value; } }
        public string Armor { get { return armor; } set { armor = value; } }

        public PlayerInfo(IPlayer player)
        {
            name = player.Name;
            id = Convert.ToString(player.ID);
            job = Convert.ToString(player.Job);
            side = Convert.ToString(player.Side);
            alive = Convert.ToString(player.Alive);
            gun = Convert.ToString(player.Gun);
            armor = Convert.ToString(player.Armor);
        }
    }
}
