namespace Mafia
{
    partial class NewGamePopup
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radExtended = new System.Windows.Forms.RadioButton();
            this.radClassic = new System.Windows.Forms.RadioButton();
            this.lblStyle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(13, 13);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(246, 13);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Starting a new game will end the game in progress.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radExtended);
            this.panel1.Controls.Add(this.radClassic);
            this.panel1.Controls.Add(this.lblStyle);
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // radExtended
            // 
            this.radExtended.AutoSize = true;
            this.radExtended.Location = new System.Drawing.Point(7, 45);
            this.radExtended.Name = "radExtended";
            this.radExtended.Size = new System.Drawing.Size(70, 17);
            this.radExtended.TabIndex = 2;
            this.radExtended.TabStop = true;
            this.radExtended.Text = "Extended";
            this.radExtended.UseVisualStyleBackColor = true;
            this.radExtended.CheckedChanged += new System.EventHandler(this.radExtended_CheckedChanged);
            // 
            // radClassic
            // 
            this.radClassic.AutoSize = true;
            this.radClassic.Location = new System.Drawing.Point(7, 21);
            this.radClassic.Name = "radClassic";
            this.radClassic.Size = new System.Drawing.Size(58, 17);
            this.radClassic.TabIndex = 1;
            this.radClassic.TabStop = true;
            this.radClassic.Text = "Classic";
            this.radClassic.UseVisualStyleBackColor = true;
            this.radClassic.CheckedChanged += new System.EventHandler(this.radClassic_CheckedChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(4, 4);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(115, 13);
            this.lblStyle.TabIndex = 0;
            this.lblStyle.Text = "Select a game rule set:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNewGame.Location = new System.Drawing.Point(20, 185);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(136, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewGamePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWarning);
            this.Name = "NewGamePopup";
            this.Text = "NewGamePopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radExtended;
        private System.Windows.Forms.RadioButton radClassic;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCancel;
    }
}