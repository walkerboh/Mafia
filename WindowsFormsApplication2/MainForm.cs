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
        private IPlayer currentPlayer;

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
            currentPlayer = mafiaGame.getCurrentTurn();
            GameStateAndTargets();
            btnSubmitAction.Enabled = true;
        }

        private void RefreshPlayerStatus()
        {
            gridPlayers.Rows.Clear();
            List<object[]> playerInfo = mafiaGame.GetPlayerInfo();
            foreach (object[] info in playerInfo)
                gridPlayers.Rows.Add(info);
            gridPlayers.Refresh();
        }

        private void GameStateAndTargets()
        {
            if (currentPlayer.Job == Helper.Enums.Job.VILLAGER)
                lblGameStateContent.Text = "Day";
            else if (currentPlayer.Job == Helper.Enums.Job.MAFIA)
                lblGameStateContent.Text = "Mafia";
            else
                lblGameStateContent.Text = string.Concat(Helper.Job.JobToString(currentPlayer.Job), " (", currentPlayer.Name, ")");

            ddlTarget.DataSource = GetTargetList(currentPlayer);
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

        private void btnSubmitAction_Click(object sender, EventArgs e)
        {
            string targetId = Convert.ToString(ddlTarget.SelectedItem);
            targetId = targetId.Substring(targetId.IndexOf("(") + 1).Trim(')');
            IPlayer target = mafiaGame.AlivePlayers.FirstOrDefault(player => player.ID == Convert.ToInt32(targetId));

            if (target == null)
                throw new Exception("How the hell did this ever happen?");

            bool? result = currentPlayer.TakeAction(ref target);

            if((currentPlayer.Job == Helper.Enums.Job.COP || currentPlayer.Job == Helper.Enums.Job.INSANECOP) && result != null)
                WriteToOutput(string.Format("Inform cop ({0}) that target ({1}) is {2}.", currentPlayer.Name, target.Name, Convert.ToBoolean(result) ? "Mafia" : "not Mafia"));

            //Do I want other outputs? Reiterate that player is hooked, given gun, etc. Probably will want when verbose logging is included.
            //Once all the game play logic is in, should probably just decide what all needs to be printed out.
            //Oh yeah, TODO ^^

            //Move to next turn
            RefreshPlayerStatus();
            currentPlayer = mafiaGame.getCurrentTurn();
            GameStateAndTargets();
        }

        private void WriteToOutput(string message)
        {
            txtGameOutput.AppendText(string.Concat("\n", message));

            //Cheat to keep textbox scrolled to bottom. Is there a better way?
            txtGameOutput.SelectionStart = txtGameOutput.Text.Length;
            txtGameOutput.ScrollToCaret();
        }
    }
}
