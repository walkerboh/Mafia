using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Classes
{
    class TurnReturn
    {
        string message = string.Empty;
        bool success;
        bool refresh;
        bool hunter;
        bool fool;

        public string Message { get { return message; } }
        public bool Success { get { return success; } }
        public bool Refresh { get { return refresh; } }
        public bool Hunter { get { return hunter; } }
        public bool Fool { get { return fool; } }

        public TurnReturn(bool success, string message = "", bool refresh = false, bool hunter = false, bool fool = false)
        {
            this.message = message;
            this.success = success;
            this.refresh = refresh;
            this.hunter = hunter;
            this.fool = fool;

        }
    }
}
