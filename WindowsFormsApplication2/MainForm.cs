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
            InitializeNewGame();
            NewGamePopup popup = new NewGamePopup();
            DialogResult extended = popup.ShowDialog();
            PlayerCreationPopup playerCreation = new PlayerCreationPopup(this, extended == System.Windows.Forms.DialogResult.Yes);
            playerCreation.ShowDialog();
            mafiaGame = new MafiaGame(playerCreation.players);
            SetupGame();
        }

        private void SetupGame()
        {
            RefreshPlayerStatus();
        }

        private void RefreshPlayerStatus()
        {
            gridPlayers.Rows.Clear();
            List<object[]> playerInfo = mafiaGame.GetPlayerInfo();
            foreach (object[] info in playerInfo)
                gridPlayers.Rows.Add(info);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
