namespace Mafia
{
    partial class PlayerCreationPopup
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerJob = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.ddlPlayerJob = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.gridPlayers = new System.Windows.Forms.DataGridView();
            this.btnDeletePlayers = new System.Windows.Forms.Button();
            this.btmDone = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(120, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Enter tha player\'s name:";
            // 
            // lblPlayerJob
            // 
            this.lblPlayerJob.AutoSize = true;
            this.lblPlayerJob.Location = new System.Drawing.Point(13, 43);
            this.lblPlayerJob.Name = "lblPlayerJob";
            this.lblPlayerJob.Size = new System.Drawing.Size(113, 13);
            this.lblPlayerJob.TabIndex = 1;
            this.lblPlayerJob.Text = "Select the player\'s job:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(139, 10);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // ddlPlayerJob
            // 
            this.ddlPlayerJob.FormattingEnabled = true;
            this.ddlPlayerJob.Location = new System.Drawing.Point(139, 40);
            this.ddlPlayerJob.Name = "ddlPlayerJob";
            this.ddlPlayerJob.Size = new System.Drawing.Size(121, 21);
            this.ddlPlayerJob.TabIndex = 3;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(13, 75);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // gridPlayers
            // 
            this.gridPlayers.AllowUserToAddRows = false;
            this.gridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colJob});
            this.gridPlayers.Location = new System.Drawing.Point(13, 115);
            this.gridPlayers.Name = "gridPlayers";
            this.gridPlayers.ReadOnly = true;
            this.gridPlayers.Size = new System.Drawing.Size(306, 150);
            this.gridPlayers.TabIndex = 5;
            // 
            // btnDeletePlayers
            // 
            this.btnDeletePlayers.Location = new System.Drawing.Point(231, 75);
            this.btnDeletePlayers.Name = "btnDeletePlayers";
            this.btnDeletePlayers.Size = new System.Drawing.Size(88, 23);
            this.btnDeletePlayers.TabIndex = 6;
            this.btnDeletePlayers.Text = "Delete Player";
            this.btnDeletePlayers.UseVisualStyleBackColor = true;
            this.btnDeletePlayers.Click += new System.EventHandler(this.btnDeletePlayers_Click);
            // 
            // btmDone
            // 
            this.btmDone.Location = new System.Drawing.Point(118, 75);
            this.btmDone.Name = "btmDone";
            this.btmDone.Size = new System.Drawing.Size(75, 23);
            this.btmDone.TabIndex = 7;
            this.btmDone.Text = "Done";
            this.btmDone.UseVisualStyleBackColor = true;
            this.btmDone.Click += new System.EventHandler(this.btmDone_Click);
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
            this.colName.HeaderText = "Player Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colJob
            // 
            this.colJob.HeaderText = "Job";
            this.colJob.Name = "colJob";
            this.colJob.ReadOnly = true;
            // 
            // PlayerCreationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.btmDone);
            this.Controls.Add(this.btnDeletePlayers);
            this.Controls.Add(this.gridPlayers);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.ddlPlayerJob);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerJob);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerCreationPopup";
            this.Text = "PlayerCreationPopup";
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerJob;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ComboBox ddlPlayerJob;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.DataGridView gridPlayers;
        private System.Windows.Forms.Button btnDeletePlayers;
        private System.Windows.Forms.Button btmDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJob;
    }
}