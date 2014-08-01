using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Classes
{
    class TurnNode
    {
        string name;
        string target;

        public string Name { get { return name; } }
        public string Target { get { return target; } }

        public TurnNode(string name, string target)
        {
            this.name = name;
            this.target = target;
        }
    }
}
