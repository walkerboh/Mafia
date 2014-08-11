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
            btnGun.Visible = false;
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
            btnGun.Visible = mafiaGame.GunActive;
            IPlayer currentPlayer = mafiaGame.getCurrentTurn();
            GameStateAndTargets(currentPlayer);
            btnSubmitAction.Enabled = true;
        }

        private void RefreshPlayerStatus()
        {
            gridPlayers.Rows.Clear();
            List<object[]> playerInfo = mafiaGame.GetPlayerInfo();
            foreach (object[] info in playerInfo)
                gridPlayers.Rows.Add(info);
        }

        private void GameStateAndTargets(IPlayer player)
        {
            if (player.Job == Helper.Enums.Job.VILLAGER)
                lblGameStateContent.Text = "Day";
            else if (player.Job == Helper.Enums.Job.MAFIA)
                lblGameStateContent.Text = "Mafia";
            else
                lblGameStateContent.Text = string.Concat(Helper.Job.JobToString(player.Job), " (", player.Name, ")");

            ddlTarget.DataSource = GetTargetList(player);
        }

        private List<string> GetTargetList(IPlayer exclusion)
        {
            List<string> nameIdStrings = new List<string>();

            List<IPlayer> players = new List<IPlayer>(mafiaGame.AlivePlayers);

            if (exclusion.Side == Helper.Enums.Side.MAFIA)
                players.RemoveAll(player => player.Side == Helper.Enums.Side.MAFIA);

            foreach (IPlayer player in players)
                nameIdStrings.Add(string.Concat(player.Name, " (", player.ID, ")"));

            return nameIdStrings;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
