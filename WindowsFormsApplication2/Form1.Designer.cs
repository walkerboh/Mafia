namespace Mafia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerEntryPanel = new System.Windows.Forms.Panel();
            this.PlayerDone = new System.Windows.Forms.Button();
            this.PlayerSubmit = new System.Windows.Forms.Button();
            this.PlayerJob = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GunPanel = new System.Windows.Forms.Panel();
            this.GunSubmit = new System.Windows.Forms.Button();
            this.GunTarget = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GunUser = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HunterPanel = new System.Windows.Forms.Panel();
            this.HunterSubmit = new System.Windows.Forms.Button();
            this.HunterTarget = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ActionSubmit = new System.Windows.Forms.Button();
            this.TargetSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GameState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Players = new System.Windows.Forms.RichTextBox();
            this.Statistcs = new System.Windows.Forms.RichTextBox();
            this.PlayerEntryPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.GunPanel.SuspendLayout();
            this.HunterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAFIA PROGRAM";
            // 
            // PlayerEntryPanel
            // 
            this.PlayerEntryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerEntryPanel.Controls.Add(this.PlayerDone);
            this.PlayerEntryPanel.Controls.Add(this.PlayerSubmit);
            this.PlayerEntryPanel.Controls.Add(this.PlayerJob);
            this.PlayerEntryPanel.Controls.Add(this.label4);
            this.PlayerEntryPanel.Controls.Add(this.PlayerName);
            this.PlayerEntryPanel.Controls.Add(this.label3);
            this.PlayerEntryPanel.Controls.Add(this.label2);
            this.PlayerEntryPanel.Location = new System.Drawing.Point(13, 38);
            this.PlayerEntryPanel.Name = "PlayerEntryPanel";
            this.PlayerEntryPanel.Size = new System.Drawing.Size(200, 361);
            this.PlayerEntryPanel.TabIndex = 1;
            // 
            // PlayerDone
            // 
            this.PlayerDone.Location = new System.Drawing.Point(18, 297);
            this.PlayerDone.Name = "PlayerDone";
            this.PlayerDone.Size = new System.Drawing.Size(75, 23);
            this.PlayerDone.TabIndex = 6;
            this.PlayerDone.Text = "Done";
            this.PlayerDone.UseVisualStyleBackColor = true;
            this.PlayerDone.Click += new System.EventHandler(this.PlayerDone_Click);
            // 
            // PlayerSubmit
            // 
            this.PlayerSubmit.Location = new System.Drawing.Point(18, 245);
            this.PlayerSubmit.Name = "PlayerSubmit";
            this.PlayerSubmit.Size = new System.Drawing.Size(75, 23);
            this.PlayerSubmit.TabIndex = 5;
            this.PlayerSubmit.Text = "Submit";
            this.PlayerSubmit.UseVisualStyleBackColor = true;
            this.PlayerSubmit.Click += new System.EventHandler(this.PlayerSubmit_Click);
            // 
            // PlayerJob
            // 
            this.PlayerJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerJob.FormattingEnabled = true;
            this.PlayerJob.Location = new System.Drawing.Point(18, 174);
            this.PlayerJob.Name = "PlayerJob";
            this.PlayerJob.Size = new System.Drawing.Size(121, 21);
            this.PlayerJob.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player Job";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(18, 94);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(100, 20);
            this.PlayerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player Entry";
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Controls.Add(this.GunPanel);
            this.GamePanel.Controls.Add(this.HunterPanel);
            this.GamePanel.Controls.Add(this.ActionSubmit);
            this.GamePanel.Controls.Add(this.TargetSelect);
            this.GamePanel.Controls.Add(this.label7);
            this.GamePanel.Controls.Add(this.GameState);
            this.GamePanel.Controls.Add(this.label6);
            this.GamePanel.Controls.Add(this.PlayText);
            this.GamePanel.Controls.Add(this.label5);
            this.GamePanel.Location = new System.Drawing.Point(220, 38);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(463, 361);
            this.GamePanel.TabIndex = 2;
            // 
            // GunPanel
            // 
            this.GunPanel.Controls.Add(this.GunSubmit);
            this.GunPanel.Controls.Add(this.GunTarget);
            this.GunPanel.Controls.Add(this.label12);
            this.GunPanel.Controls.Add(this.GunUser);
            this.GunPanel.Controls.Add(this.label11);
            this.GunPanel.Location = new System.Drawing.Point(321, 183);
            this.GunPanel.Name = "GunPanel";
            this.GunPanel.Size = new System.Drawing.Size(141, 177);
            this.GunPanel.TabIndex = 8;
            this.GunPanel.Visible = false;
            // 
            // GunSubmit
            // 
            this.GunSubmit.Location = new System.Drawing.Point(10, 134);
            this.GunSubmit.Name = "GunSubmit";
            this.GunSubmit.Size = new System.Drawing.Size(75, 23);
            this.GunSubmit.TabIndex = 4;
            this.GunSubmit.Text = "FIRE!";
            this.GunSubmit.UseVisualStyleBackColor = true;
            this.GunSubmit.Click += new System.EventHandler(this.GunSubmit_Click);
            // 
            // GunTarget
            // 
            this.GunTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GunTarget.FormattingEnabled = true;
            this.GunTarget.Location = new System.Drawing.Point(10, 91);
            this.GunTarget.Name = "GunTarget";
            this.GunTarget.Size = new System.Drawing.Size(121, 21);
            this.GunTarget.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Select gun target:";
            // 
            // GunUser
            // 
            this.GunUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GunUser.FormattingEnabled = true;
            this.GunUser.Location = new System.Drawing.Point(7, 33);
            this.GunUser.Name = "GunUser";
            this.GunUser.Size = new System.Drawing.Size(121, 21);
            this.GunUser.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Select gun user:";
            // 
            // HunterPanel
            // 
            this.HunterPanel.Controls.Add(this.HunterSubmit);
            this.HunterPanel.Controls.Add(this.HunterTarget);
            this.HunterPanel.Controls.Add(this.label8);
            this.HunterPanel.Location = new System.Drawing.Point(167, 183);
            this.HunterPanel.Name = "HunterPanel";
            this.HunterPanel.Size = new System.Drawing.Size(148, 177);
            this.HunterPanel.TabIndex = 7;
            this.HunterPanel.Visible = false;
            // 
            // HunterSubmit
            // 
            this.HunterSubmit.Location = new System.Drawing.Point(13, 90);
            this.HunterSubmit.Name = "HunterSubmit";
            this.HunterSubmit.Size = new System.Drawing.Size(75, 23);
            this.HunterSubmit.TabIndex = 2;
            this.HunterSubmit.Text = "Submit";
            this.HunterSubmit.UseVisualStyleBackColor = true;
            this.HunterSubmit.Click += new System.EventHandler(this.HunterSubmit_Click);
            // 
            // HunterTarget
            // 
            this.HunterTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HunterTarget.FormattingEnabled = true;
            this.HunterTarget.Location = new System.Drawing.Point(13, 49);
            this.HunterTarget.Name = "HunterTarget";
            this.HunterTarget.Size = new System.Drawing.Size(121, 21);
            this.HunterTarget.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select hunter\'s target";
            // 
            // ActionSubmit
            // 
            this.ActionSubmit.Location = new System.Drawing.Point(18, 317);
            this.ActionSubmit.Name = "ActionSubmit";
            this.ActionSubmit.Size = new System.Drawing.Size(75, 23);
            this.ActionSubmit.TabIndex = 6;
            this.ActionSubmit.Text = "Submit";
            this.ActionSubmit.UseVisualStyleBackColor = true;
            this.ActionSubmit.Click += new System.EventHandler(this.ActionSubmit_Click);
            // 
            // TargetSelect
            // 
            this.TargetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetSelect.FormattingEnabled = true;
            this.TargetSelect.Location = new System.Drawing.Point(18, 276);
            this.TargetSelect.Name = "TargetSelect";
            this.TargetSelect.Size = new System.Drawing.Size(121, 21);
            this.TargetSelect.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select target of action";
            // 
            // GameState
            // 
            this.GameState.AutoSize = true;
            this.GameState.Location = new System.Drawing.Point(15, 216);
            this.GameState.Name = "GameState";
            this.GameState.Size = new System.Drawing.Size(35, 13);
            this.GameState.TabIndex = 3;
            this.GameState.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Game State:";
            // 
            // PlayText
            // 
            this.PlayText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayText.Location = new System.Drawing.Point(5, 28);
            this.PlayText.Name = "PlayText";
            this.PlayText.ReadOnly = true;
            this.PlayText.Size = new System.Drawing.Size(457, 149);
            this.PlayText.TabIndex = 1;
            this.PlayText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Play Area";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Players";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Statistics";
            // 
            // Players
            // 
            this.Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Players.Location = new System.Drawing.Point(13, 422);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(326, 144);
            this.Players.TabIndex = 5;
            this.Players.Text = "";
            // 
            // Statistcs
            // 
            this.Statistcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Statistcs.Location = new System.Drawing.Point(345, 422);
            this.Statistcs.Name = "Statistcs";
            this.Statistcs.Size = new System.Drawing.Size(335, 144);
            this.Statistcs.TabIndex = 6;
            this.Statistcs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 578);
            this.Controls.Add(this.Statistcs);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.PlayerEntryPanel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayerEntryPanel.ResumeLayout(false);
            this.PlayerEntryPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.GunPanel.ResumeLayout(false);
            this.GunPanel.PerformLayout();
            this.HunterPanel.ResumeLayout(false);
            this.HunterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PlayerEntryPanel;
        private System.Windows.Forms.Button PlayerDone;
        private System.Windows.Forms.Button PlayerSubmit;
        private System.Windows.Forms.ComboBox PlayerJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button ActionSubmit;
        private System.Windows.Forms.ComboBox TargetSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label GameState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox PlayText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox Players;
        private System.Windows.Forms.RichTextBox Statistcs;
        private System.Windows.Forms.Panel HunterPanel;
        private System.Windows.Forms.Button HunterSubmit;
        private System.Windows.Forms.ComboBox HunterTarget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel GunPanel;
        private System.Windows.Forms.Button GunSubmit;
        private System.Windows.Forms.ComboBox GunTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox GunUser;
        private System.Windows.Forms.Label label11;
    }
}

