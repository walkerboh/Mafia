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
        private MafiaGame mafiaGame;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mafiaGame = new MafiaGame();
        }

        public void InitializeNewGame()
        {
            btnSubmitAction.Enabled = false;
            btnGun.Enabled = false;
            txtGameOutput.Clear();
            gridPlayers.DataSource = null;
            ddlTarget.DataSource = null;
            lblGameStateContent.Text = "Setup";
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            NewGamePopup popup = new NewGamePopup();
            DialogResult extended = popup.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
