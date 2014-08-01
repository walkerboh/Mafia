using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mafia.Classes;

namespace Mafia
{
    public partial class Form1 : Form
    {
        PlayerList players = new PlayerList();
        TurnHandler turn = new TurnHandler();
        int num;
        bool end = false;
        bool gunPresent = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Codes.Job[] jobs = { Codes.Job.MAFIA, Codes.Job.VILLAGER, Codes.Job.COP, Codes.Job.DOCTOR, Codes.Job.INSANECOP, Codes.Job.BODYGUARD, Codes.Job.GODFATHER, 
                                   Codes.Job.FOOL, Codes.Job.HUNTER, Codes.Job.SILENCER, Codes.Job.HOOKER, Codes.Job.VIGILANTE, Codes.Job.KILLER, Codes.Job.ARMORSMITH, Codes.Job.GUNSMITH};
            foreach (Codes.Job j in jobs)
                PlayerJob.Items.Add(j);
            GameState.Text = "Setup";
            GamePanel.Enabled = false;
            players.initialize();
        }

        private void PlayerSubmit_Click(object sender, EventArgs e)
        {
            if (PlayerName.Text == "")
                MessageBox.Show("Player must have non-empty string as name. Try again.", "Improper Name Format", MessageBoxButtons.OK);
            else if (players.nameUsed(PlayerName.Text))
                MessageBox.Show("Player name is taken. Have player use different name.", "Name Taken", MessageBoxButtons.OK);
            else
            {
                string name = PlayerName.Text;
                Codes.Job job = (Codes.Job)PlayerJob.SelectedItem;
                players.addPlayer(name, job);
                PlayerName.Text = string.Empty;
                PlayerName.Focus();
                updatePlayers();
            }
        }

        private void updatePlayers()
        {
            Players.Text = string.Empty;
            List<string> text = players.getPlayerStatus();
            foreach (string s in text)
            {
                Players.Text += s;
            }
        }

        private void PlayerDone_Click(object sender, EventArgs e)
        {
            if (players.MafiaAlive >= players.VillageAlive || players.MafiaAlive == 0)
            {
                MessageBox.Show("Number of mafia equal or greater than number of townies. Invalid setup. Re-enter all players.", "Invalid Setup", MessageBoxButtons.OK);
                players = new PlayerList();
                players.initialize();
                Players.Text = "";
            }
            else
            {
                PlayText.Text = "Setup Complete...";
                PlayerEntryPanel.Visible = false;
                GamePanel.Enabled = true;
                players.refreshAlive();
                updateStatistics();
                num = -1;
                players.sort();
                if (players.countJobPresent(Codes.Job.GUNSMITH) >= 1)
                    gunPresent = true;
                addTextPlayText("\nInitialization Complete...\n------Game Starting------");
                nextGameState();
            }
        }

        private void updateStatistics()
        {
            Statistcs.Text = string.Empty;
            string[] text = new string[4];
            text[0] = "Number of mafia alive: " + players.MafiaAlive + "\n";
            text[1] = "Number of townies alive: " + players.VillageAlive + "\n";
            text[2] = "Number of players alive: " + players.PlayersAlive + "\n";
            text[3] = "Number of players total: " + players.TotalPlayers;
            foreach (string s in text)
                Statistcs.AppendText(s);
        }

        private void nextGameState()
        {
            players.refreshAlive();
            Codes.Job[] self = { Codes.Job.DOCTOR, Codes.Job.BODYGUARD, Codes.Job.GUNSMITH, Codes.Job.ARMORSMITH, Codes.Job.SILENCER, Codes.Job.VILLAGER, Codes.Job.MAFIA}; 
            num = (num + 1) % players.Count;
            while (players[num].Job == Codes.Job.HUNTER || players[num].Job == Codes.Job.GODFATHER || players[num].Job == Codes.Job.FOOL)
                num = (num + 1) % players.Count;
            if (players[num].Alive || players[num].Job == Codes.Job.VILLAGER || players[num].Job != Codes.Job.MAFIA)
            {
                if (players[num].Job != Codes.Job.VILLAGER)
                    GameState.Text = players[num].Job + " " + players[num].Letter;
                else
                {
                    GameState.Text = "DAY";
                    if (gunPresent)
                        GunPanel.Visible = true;
                }
                if (players[num].Job != Codes.Job.VILLAGER && players[num].Job != Codes.Job.MAFIA)
                {
                    addTextPlayText("\nPlay moves to " + players[num].Name + " - " + players[num].Job + (players[num].Letter == ' ' ? string.Empty : " " + players[num].Letter));
                    addTextPlayText("\nSelect target of action.");
                }
                else if (players[num].Job == Codes.Job.MAFIA)
                {
                    addTextPlayText("\nPlay moves to MAFIA.");
                    addTextPlayText("\nSelect target of action.");
                }
                else
                {
                    List<string> text = turn.handleNightActions(players);
                    foreach (string s in text)
                        addTextPlayText(s);
                    updatePlayers();
                    updateStatistics();
                    gameOver(players.gameOver());
                    if (!end)
                    {
                        addTextPlayText("\nPlay moves to DAY");
                        addTextPlayText("\nSelect target to lynch.");
                        refreshGunPanel();
                        GunPanel.Visible = true;
                    }
                }
                if (!end)
                {
                    TargetSelect.Items.Clear();
                    if (self.Contains<Codes.Job>(players[num].Job))
                        foreach (Player p in players.Alive)
                            TargetSelect.Items.Add(p.Name);
                    else
                        foreach (Player p in players.Alive)
                            if (p != players[num])
                                TargetSelect.Items.Add(p.Name);
                }
            }
            else
            {
                MessageBox.Show(players[num].Name + " with job " + players[num].Job + " is dead. Fake prompt.", "Fake prompt reminder.", MessageBoxButtons.OK);
                nextGameState();
            }
        }

        private void ActionSubmit_Click(object sender, EventArgs e)
        {
            GunPanel.Visible = false;
            bool skipNext = false;
            TurnReturn info = turn.handle(players[num].Job, TargetSelect.Text, players, players[num].Name);
            if (info.Success)
            {
                if(info.Message != string.Empty)
                    addTextPlayText("\n" + info.Message);
                if (info.Refresh)
                {
                    if (info.Fool)
                        gameOver(3);
                    else if (info.Hunter)
                    {
                        skipNext = true;
                        HunterPanel.Visible = true;
                        ActionSubmit.Enabled = false;
                        GameState.Text = "HUNTER";
                        players.refreshAlive();
                        foreach (Player p in players.Alive)
                            HunterTarget.Items.Add(p.Name);
                        MessageBox.Show("Hunter was lynched. Pick hunter target.", "Hunter Action.", MessageBoxButtons.OK);
                    }
                    if(!end)
                        gameOver(players.gameOver());
                    players.refreshAlive();
                    turn.refresh();
                    updatePlayers();
                    updateStatistics();
                }
                if (!end)
                {
                    if (!skipNext)
                    {
                        if(players[num].Job == Codes.Job.VILLAGER || players[num].Job == Codes.Job.MAFIA)
                            num = players.skipToNextJob(num);
                        nextGameState();
                    }
                }
            }
            else
            {
                if(info.Message != string.Empty)
                    addTextPlayText("\n" + info.Message);
            }
        }

        private void gameOver(int code)
        {
            if (code == 1)
            {
                addTextPlayText("\nGAME OVER ----- VILLAGE WINS");
                TargetSelect.Enabled = ActionSubmit.Enabled = false;
                end = true;
            }
            else if (code == 2)
            {
                addTextPlayText("\nGAME OVER ----- MAFIA WINS");
                TargetSelect.Enabled = ActionSubmit.Enabled = false;
                end = true;
            }
            else if (code == 3)
            {
                addTextPlayText("\nGAME OVER ----- FOOL WINS");
                TargetSelect.Enabled = ActionSubmit.Enabled = false;
                end = true;
            }
        }

        private void addTextPlayText(string text)
        {
            PlayText.AppendText(text);
            PlayText.SelectionStart = PlayText.Text.Length;
            PlayText.ScrollToCaret();
        }

        private void HunterSubmit_Click(object sender, EventArgs e)
        {
            TurnReturn info = turn.handleHunter(HunterTarget.SelectedText, players);
            if (info.Success)
            {
                if (info.Message != string.Empty)
                    addTextPlayText("\n" + info.Message);
                gameOver(players.gameOver());
                players.refreshAlive();
                turn.refresh();
                updatePlayers();
                updateStatistics();
                HunterPanel.Visible = false;
                ActionSubmit.Enabled = true;
                if (!end)
                {
                    num = players.skipToNextJob(num);
                    nextGameState();
                }
            }
            else
            {
                if (info.Message != string.Empty)
                    addTextPlayText("\n" + info.Message);
            }
        }

        private void refreshGunPanel()
        {
            GunUser.Items.Clear();
            GunTarget.Items.Clear();
            foreach (Player p in players.Alive)
            {
                if (p.Gun)
                    GunUser.Items.Add(p.Name);
                GunTarget.Items.Add(p.Name);
            }
        }

        private void GunSubmit_Click(object sender, EventArgs e)
        {
            TurnReturn info = turn.handleGunFire(GunUser.SelectedText, GunTarget.SelectedText, players);
            addTextPlayText(info.Message);
            updatePlayers();
            updateStatistics();
            gameOver(players.gameOver());
        }
    }
}
