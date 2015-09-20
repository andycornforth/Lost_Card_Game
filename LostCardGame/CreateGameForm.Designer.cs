namespace LostCardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayerToGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 19);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(64, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "PlayerName";
            // 
            // btnAddPlayerToGame
            // 
            this.btnAddPlayerToGame.Location = new System.Drawing.Point(197, 8);
            this.btnAddPlayerToGame.Name = "btnAddPlayerToGame";
            this.btnAddPlayerToGame.Size = new System.Drawing.Size(75, 29);
            this.btnAddPlayerToGame.TabIndex = 1;
            this.btnAddPlayerToGame.Text = "Add Player";
            this.btnAddPlayerToGame.UseVisualStyleBackColor = true;
            this.btnAddPlayerToGame.Click += new System.EventHandler(this.btnAddPlayerToGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(83, 11);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 26);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(83, 50);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(100, 95);
            this.lstPlayers.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStartGame.Location = new System.Drawing.Point(197, 148);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 27);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnAddPlayerToGame);
            this.Controls.Add(this.lblPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOST GAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnAddPlayerToGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnStartGame;
    }
}

