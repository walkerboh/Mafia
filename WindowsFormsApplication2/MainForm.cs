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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void InitializeNewGame()
        {
            btnGun.Enabled = false;
            txtGameOutput.Clear();
            gridPlayers.DataSource = null;
            ddlTarget.DataSource = null;
            lblGameStateContent.Text = "Setup";
        }
    }
}
