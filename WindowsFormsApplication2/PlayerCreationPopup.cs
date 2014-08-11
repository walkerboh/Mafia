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
    partial class PlayerCreationPopup : Form
    {
        MainForm mainForm;
        public List<IPlayer> players;

        public PlayerCreationPopup()
        {
            InitializeComponent();
        }

        public PlayerCreationPopup(MainForm mainForm, bool extended)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            List<string> jobs = new List<string>();

            if (extended)
            {
                foreach (string job in Helper.Job.EXTENDED)
                {
                    jobs.Add(job);
                }
            }
            else
            {
                foreach (string job in Helper.Job.CLASSIC)
                {
                    jobs.Add(job);
                }
            }

            jobs.Sort();
            ddlPlayerJob.DataSource = jobs;

            this.Text = "Player Creation";

            players = new List<IPlayer>();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.TextLength == 0)
            {
                MessageBox.Show("Please enter a player name.", "Invalid Player Name", MessageBoxButtons.OK);
                return;
            }
            else if (txtPlayerName.Text.Contains("(") || txtPlayerName.Text.Contains(")"))
            {
                MessageBox.Show("Please do not include parenthesis in the player name.", "Invalid Player Name", MessageBoxButtons.OK);
                return;
            }

            IPlayer newPlayer = PlayerFactory.CreatePlayer(txtPlayerName.Text, Convert.ToString(ddlPlayerJob.SelectedValue));

            gridPlayers.Rows.Add(new object[] { newPlayer.ID, txtPlayerName.Text, ddlPlayerJob.SelectedValue });

            players.Add(newPlayer);
        }

        private void btnDeletePlayers_Click(object sender, EventArgs e)
        {
            if (gridPlayers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridPlayers.SelectedRows[0];

                players.RemoveAll(player => player.ID == Convert.ToInt32(row.Cells["colID"].Value));

                gridPlayers.Rows.Remove(row);
            }
        }

        private void btmDone_Click(object sender, EventArgs e)
        {
            int mafiaCount = players.Count(player => player.Side == Helper.Enums.Side.MAFIA);
            int villageCount = players.Count(player => player.Side != Helper.Enums.Side.MAFIA);

            if (mafiaCount >= villageCount)
                MessageBox.Show("Must have more villagers than mafia members.", "Invalid Setup", MessageBoxButtons.OK);
            else if (mafiaCount == 0 || villageCount == 0)
                MessageBox.Show("Must have at least one member on each side.", "Invalid Setup", MessageBoxButtons.OK);
            else
            {
                //mainForm.tempPlayerList = players;
                Close();
            }
        }
    }
}
