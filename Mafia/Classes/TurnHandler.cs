using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafia.Classes
{
    class TurnHandler
    {
        string mafiaTarget;
        List<string> docTarget = new List<string>();
        List<TurnNode> bodyTarget = new List<TurnNode>();
        List<string> silenceTarget = new List<string>();
        List<string> hookTarget = new List<string>();
        List<TurnNode> vigTarget = new List<TurnNode>();
        List<TurnNode> killerTarget = new List<TurnNode>();

        private const string INVALID = "Target is invalid.";
        private const string HOOKED = "Player was hooked. Action nullified.";

        public void refresh()
        {
            mafiaTarget = string.Empty;
            docTarget.Clear();
            bodyTarget.Clear();
            silenceTarget.Clear();
            hookTarget.Clear();
        }

        public TurnReturn handle(Codes.Job job, string target, PlayerList players, string player)
        {
            int targ;
            TurnReturn info = null;
            switch (job)
            {
                case Codes.Job.MAFIA:
                    targ = players.getPlayer(target);
                    if (targ == -1)
                        info = new TurnReturn(false, INVALID);
                    else if (players[targ].Alive)
                    {
                        mafiaTarget = target;
                        info = new TurnReturn(true, "Mafia targets " + target);
                    }
                    else
                        info = new TurnReturn(false, target + " is already dead.");
                    break;
                case Codes.Job.DOCTOR:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                            info = new TurnReturn(false, INVALID);
                        else if (players[targ].Alive)
                        {
                            docTarget.Add(target);
                            info = new TurnReturn(true, "Doctor saves " + target);
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.COP:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                            info = new TurnReturn(false, INVALID);
                        else if (players[targ].Alive)
                        {
                            if (players[targ].Job == Codes.Job.GODFATHER)
                                info = new TurnReturn(true, target + " is innocent.");
                            else if (players[targ].Side == Codes.Side.MAFIA)
                                info = new TurnReturn(true, target + " is Mafia.");
                            else
                                info = new TurnReturn(true, target + " is innocent.");
                            MessageBox.Show(info.Message, "Cop Result", MessageBoxButtons.OK);
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.INSANECOP:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                            info = new TurnReturn(false, INVALID);
                        else if (players[targ].Alive)
                        {
                            if (players[targ].Job == Codes.Job.GODFATHER)
                                info = new TurnReturn(true, target + " is Mafia");
                            else if (players[targ].Side == Codes.Side.MAFIA)
                                info = new TurnReturn(true, target + " is innocent.");
                            else
                                info = new TurnReturn(true, target + " is Mafia.");
                            MessageBox.Show(info.Message, "Insane Cop Result", MessageBoxButtons.OK);
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.BODYGUARD:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                            info = new TurnReturn(false, INVALID);
                        else if (players[targ].Alive)
                        {
                            bodyTarget.Add(new TurnNode(player, target));
                            info = new TurnReturn(true, "Bodyguard protects " + target);
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.GUNSMITH:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                        {
                            info = new TurnReturn(false, INVALID);
                        }
                        else if (players[targ].Alive)
                        {
                            players[targ].giveItem(Codes.Item.GUN);
                            info = new TurnReturn(true, target + "was given a gun.");
                        }
                        else
                            info = new TurnReturn(false, target + " is dead and thus cannot receive a gun.");
                    }
                    break;
                case Codes.Job.ARMORSMITH:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                        {
                            info = new TurnReturn(false, INVALID);
                        }
                        else if (players[targ].Alive)
                        {
                            players[targ].giveItem(Codes.Item.ARMOR);
                            info = new TurnReturn(true, target + "was given armor.");
                        }
                        else
                            info = new TurnReturn(false, target + " is dead and thus cannot receive armor.");
                    }
                    break;
                case Codes.Job.SILENCER:
                    targ = players.getPlayer(target);
                    if (targ == -1)
                    {
                        info = new TurnReturn(false, INVALID);
                    }
                    else if (players[targ].Alive)
                    {
                        silenceTarget.Add(target);
                        info = new TurnReturn(true, target + " is silenced.");
                    }
                    else
                        info = new TurnReturn(false, target + " is already dead.");
                    break;
                case Codes.Job.HOOKER:
                    targ = players.getPlayer(target);
                    if (targ == -1)
                    {
                        info = new TurnReturn(false, INVALID);
                    }
                    else if (players[targ].Alive)
                    {
                        hookTarget.Add(target);
                        info = new TurnReturn(true, target + " is hooked.");
                    }
                    else
                        info = new TurnReturn(false, target + " is already dead.");
                    break;
                case Codes.Job.VIGILANTE:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                        {
                            info = new TurnReturn(false, INVALID);
                        }
                        else if (players[targ].Alive)
                        {
                            vigTarget.Add(new TurnNode(player, target));
                            info = new TurnReturn(true, target + "Vigilante shoots " + target + ".");
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.KILLER:
                    if (hookTarget.Any<string>(name => name == player))
                        info = new TurnReturn(true, HOOKED);
                    else
                    {
                        targ = players.getPlayer(target);
                        if (targ == -1)
                        {
                            info = new TurnReturn(false, INVALID);
                        }
                        else if (players[targ].Alive)
                        {
                            killerTarget.Add(new TurnNode(player, target));
                            info = new TurnReturn(true, target + "Killer shoots " + target + ".");
                        }
                        else
                            info = new TurnReturn(false, target + " is already dead.");
                    }
                    break;
                case Codes.Job.VILLAGER:
                    targ = players.getPlayer(target);
                    if (targ == -1)
                    {
                        info = new TurnReturn(false, INVALID);
                        break;
                    }
                    bool success = players.killPlayer(targ);
                    bool hunter = false;
                    bool fool = false;
                    if (players[targ].Job == Codes.Job.HUNTER)
                        hunter = true;
                    else if (players[targ].Job == Codes.Job.FOOL)
                        fool = true;
                    info = new TurnReturn(success, (success ?  target + " has been lynched." : target + " is already dead."), success, hunter, fool);
                    break;
            }
            return info;
        }

        public TurnReturn handleHunter(string target, PlayerList players)
        {
            TurnReturn info;
            int targ = players.getPlayer(target);
            if (targ == -1)
                return info = new TurnReturn(false, INVALID);
            if (players[targ].Alive)
            {
                players.killPlayer(targ);
                return info = new TurnReturn(true, "Hunter has shot " + target);
            }
            return info = new TurnReturn(false, target + " is already dead.");
        }

        public TurnReturn handleGunFire(string userS, string targetS, PlayerList players)
        {
            int user = players.getPlayer(userS);
            int target = players.getPlayer(targetS);
            if (user == -1)
                return new TurnReturn(false, "User is invalid.");
            if(target > -1)
            {
                if(!players[target].Alive)
                    return new TurnReturn(false, target + " is already dead.");
            }
            else
                return new TurnReturn(false, "Target is invalid.");
            if (players[user].Alive && players[user].useItem(Codes.Item.GUN))
            {
                if (!players[target].useItem(Codes.Item.ARMOR))
                {
                    players.killPlayer(target);
                    return new TurnReturn(true, user + " shot and killed " + target);
                }
                return new TurnReturn(true, user + " shot " + target + " but they had armor.");
            }
            return new TurnReturn(false, user + " does not have a gun.");
        }

        public List<string> handleNightActions(PlayerList players)
        {
            List<string> text = new List<string>();
            List<TurnNode> targets = new List<TurnNode>();
            bool targetKilled;
            int num;

            targets.Add(new TurnNode("", mafiaTarget));
            targets.AddRange(vigTarget);
            targets.AddRange(killerTarget);

            while (targets.Count > 0)
            {
                targetKilled = true;
                num = players.getPlayer(targets[0].Target);
                if (players[num].useItem(Codes.Item.ARMOR))
                    targetKilled = false;
                foreach (string s in docTarget)
                    if (s == targets[0].Target)
                    {
                        targetKilled = false;
                    }
                if (targetKilled)
                {
                    int index = 1;
                    foreach (TurnNode n in bodyTarget)
                    {
                        if (n.Target == targets[0].Target)
                        {
                            targetKilled = false;
                            break;
                        }
                        index++;
                    }
                    if (!targetKilled)
                    {
                        Random rand = new Random();
                        int chance = (rand.Next()) % 10;
                        if (chance < 5)
                            targets.Add(new TurnNode(targets[0].Name, bodyTarget[index].Name));
                        else
                        {
                            if (targets[0].Name == "")
                                targets.Add(new TurnNode(bodyTarget[index].Name, players.randomMafia()));
                            else
                                targets.Add(new TurnNode(bodyTarget[index].Name, targets[0].Name));
                        }
                    }
                    if (targetKilled)
                    {
                        players.killPlayer(num);
                        text.Add(targets[0].Target + " has died.");
                    }
                }
                targets.RemoveAt(0);
            }
            return text;
        }
    }
}
