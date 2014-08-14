namespace Mafia
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGameOutput = new System.Windows.Forms.RichTextBox();
            this.lblGameState = new System.Windows.Forms.Label();
            this.lblGameStateContent = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.ddlTarget = new System.Windows.Forms.ComboBox();
            this.btnSubmitAction = new System.Windows.Forms.Button();
            this.gridPlayers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArmor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGun = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMenuItem,
            this.configurationMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.exitMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.ShortcutKeyDisplayString = "";
            this.systemMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemMenuItem.Text = "System";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGameMenuItem.Text = "New Game";
            this.newGameMenuItem.Click += new System.EventHandler(this.newGameMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // configurationMenuItem
            // 
            this.configurationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.configurationMenuItem.Name = "configurationMenuItem";
            this.configurationMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationMenuItem.Text = "Congifuration";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsMenuItem.Text = "Settings";
            // 
            // txtGameOutput
            // 
            this.txtGameOutput.Location = new System.Drawing.Point(12, 58);
            this.txtGameOutput.Name = "txtGameOutput";
            this.txtGameOutput.ReadOnly = true;
            this.txtGameOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtGameOutput.Size = new System.Drawing.Size(648, 176);
            this.txtGameOutput.TabIndex = 1;
            this.txtGameOutput.Text = "";
            // 
            // lblGameState
            // 
            this.lblGameState.AutoSize = true;
            this.lblGameState.Location = new System.Drawing.Point(13, 241);
            this.lblGameState.Name = "lblGameState";
            this.lblGameState.Size = new System.Drawing.Size(66, 13);
            this.lblGameState.TabIndex = 2;
            this.lblGameState.Text = "Game State:";
            // 
            // lblGameStateContent
            // 
            this.lblGameStateContent.AutoSize = true;
            this.lblGameStateContent.Location = new System.Drawing.Point(85, 241);
            this.lblGameStateContent.Name = "lblGameStateContent";
            this.lblGameStateContent.Size = new System.Drawing.Size(0, 13);
            this.lblGameStateContent.TabIndex = 3;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(174, 241);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(74, 13);
            this.lblTarget.TabIndex = 4;
            this.lblTarget.Text = "Select Target:";
            // 
            // ddlTarget
            // 
            this.ddlTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTarget.FormattingEnabled = true;
            this.ddlTarget.Location = new System.Drawing.Point(254, 238);
            this.ddlTarget.Name = "ddlTarget";
            this.ddlTarget.Size = new System.Drawing.Size(121, 21);
            this.ddlTarget.TabIndex = 5;
            // 
            // btnSubmitAction
            // 
            this.btnSubmitAction.Location = new System.Drawing.Point(393, 238);
            this.btnSubmitAction.Name = "btnSubmitAction";
            this.btnSubmitAction.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAction.TabIndex = 6;
            this.btnSubmitAction.Text = "Submit";
            this.btnSubmitAction.UseVisualStyleBackColor = true;
            this.btnSubmitAction.Click += new System.EventHandler(this.btnSubmitAction_Click);
            // 
            // gridPlayers
            // 
            this.gridPlayers.AllowUserToAddRows = false;
            this.gridPlayers.AllowUserToDeleteRows = false;
            this.gridPlayers.AllowUserToOrderColumns = true;
            this.gridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSide,
            this.colJob,
            this.colAlive,
            this.colGun,
            this.colArmor});
            this.gridPlayers.Location = new System.Drawing.Point(16, 271);
            this.gridPlayers.Name = "gridPlayers";
            this.gridPlayers.ReadOnly = true;
            this.gridPlayers.Size = new System.Drawing.Size(644, 213);
            this.gridPlayers.TabIndex = 7;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSide
            // 
            this.colSide.HeaderText = "Side";
            this.colSide.Name = "colSide";
            this.colSide.ReadOnly = true;
            // 
            // colJob
            // 
            this.colJob.HeaderText = "Job";
            this.colJob.Name = "colJob";
            this.colJob.ReadOnly = true;
            // 
            // colAlive
            // 
            this.colAlive.HeaderText = "Alive";
            this.colAlive.Name = "colAlive";
            this.colAlive.ReadOnly = true;
            // 
            // colGun
            // 
            this.colGun.HeaderText = "Gun";
            this.colGun.Name = "colGun";
            this.colGun.ReadOnly = true;
            // 
            // colArmor
            // 
            this.colArmor.HeaderText = "Armor";
            this.colArmor.Name = "colArmor";
            this.colArmor.ReadOnly = true;
            // 
            // btnGun
            // 
            this.btnGun.Location = new System.Drawing.Point(582, 238);
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(75, 23);
            this.btnGun.TabIndex = 8;
            this.btnGun.Text = "Fire Gun";
            this.btnGun.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 496);
            this.Controls.Add(this.gridPlayers);
            this.Controls.Add(this.btnGun);
            this.Controls.Add(this.btnSubmitAction);
            this.Controls.Add(this.ddlTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblGameStateContent);
            this.Controls.Add(this.lblGameState);
            this.Controls.Add(this.txtGameOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.RichTextBox txtGameOutput;
        private System.Windows.Forms.Label lblGameState;
        private System.Windows.Forms.Label lblGameStateContent;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox ddlTarget;
        private System.Windows.Forms.Button btnSubmitAction;
        private System.Windows.Forms.DataGridView gridPlayers;
        private System.Windows.Forms.Button btnGun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArmor;
    }
}