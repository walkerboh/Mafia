using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafia
{
    public partial class NewGamePopup : Form
    {
        public NewGamePopup()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void radClassic_CheckedChanged(object sender, EventArgs e)
        {
            btnNewGame.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void radExtended_CheckedChanged(object sender, EventArgs e)
        {
            btnNewGame.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
