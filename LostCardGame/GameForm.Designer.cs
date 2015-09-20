namespace LostCardGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.lstPivotalEvents = new System.Windows.Forms.ListBox();
            this.lstStandardEvents = new System.Windows.Forms.ListBox();
            this.btnPickCharacter = new System.Windows.Forms.Button();
            this.btnPickEvent = new System.Windows.Forms.Button();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.lblPivotalEvents = new System.Windows.Forms.Label();
            this.lblStandardEvents = new System.Windows.Forms.Label();
            this.lstPivotalEventCharacters = new System.Windows.Forms.ListBox();
            this.lstDiscardPile = new System.Windows.Forms.ListBox();
            this.btnDiscardCard = new System.Windows.Forms.Button();
            this.lblDiscardPile = new System.Windows.Forms.Label();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(13, 13);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(68, 24);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lstCharacters
            // 
            this.lstCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 20;
            this.lstCharacters.Location = new System.Drawing.Point(16, 88);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(200, 124);
            this.lstCharacters.TabIndex = 1;
            // 
            // lstPivotalEvents
            // 
            this.lstPivotalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPivotalEvents.FormattingEnabled = true;
            this.lstPivotalEvents.ItemHeight = 20;
            this.lstPivotalEvents.Location = new System.Drawing.Point(223, 88);
            this.lstPivotalEvents.Name = "lstPivotalEvents";
            this.lstPivotalEvents.Size = new System.Drawing.Size(350, 124);
            this.lstPivotalEvents.TabIndex = 2;
            this.lstPivotalEvents.SelectedIndexChanged += new System.EventHandler(this.lstPivotalEvents_SelectedIndexChanged);
            // 
            // lstStandardEvents
            // 
            this.lstStandardEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStandardEvents.FormattingEnabled = true;
            this.lstStandardEvents.ItemHeight = 20;
            this.lstStandardEvents.Location = new System.Drawing.Point(710, 88);
            this.lstStandardEvents.Name = "lstStandardEvents";
            this.lstStandardEvents.Size = new System.Drawing.Size(350, 124);
            this.lstStandardEvents.TabIndex = 3;
            // 
            // btnPickCharacter
            // 
            this.btnPickCharacter.BackColor = System.Drawing.Color.Red;
            this.btnPickCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickCharacter.Location = new System.Drawing.Point(17, 272);
            this.btnPickCharacter.Name = "btnPickCharacter";
            this.btnPickCharacter.Size = new System.Drawing.Size(150, 104);
            this.btnPickCharacter.TabIndex = 4;
            this.btnPickCharacter.Text = "Character Card";
            this.btnPickCharacter.UseVisualStyleBackColor = false;
            this.btnPickCharacter.Click += new System.EventHandler(this.btnPickCharacter_Click);
            // 
            // btnPickEvent
            // 
            this.btnPickEvent.BackColor = System.Drawing.Color.Blue;
            this.btnPickEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickEvent.Location = new System.Drawing.Point(172, 272);
            this.btnPickEvent.Name = "btnPickEvent";
            this.btnPickEvent.Size = new System.Drawing.Size(150, 104);
            this.btnPickEvent.TabIndex = 5;
            this.btnPickEvent.Text = "Event Card";
            this.btnPickEvent.UseVisualStyleBackColor = false;
            this.btnPickEvent.Click += new System.EventHandler(this.btnPickEvent_Click);
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Location = new System.Drawing.Point(14, 62);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(58, 13);
            this.lblCharacters.TabIndex = 6;
            this.lblCharacters.Text = "Characters";
            // 
            // lblPivotalEvents
            // 
            this.lblPivotalEvents.AutoSize = true;
            this.lblPivotalEvents.Location = new System.Drawing.Point(219, 62);
            this.lblPivotalEvents.Name = "lblPivotalEvents";
            this.lblPivotalEvents.Size = new System.Drawing.Size(75, 13);
            this.lblPivotalEvents.TabIndex = 7;
            this.lblPivotalEvents.Text = "Pivotal Events";
            // 
            // lblStandardEvents
            // 
            this.lblStandardEvents.AutoSize = true;
            this.lblStandardEvents.Location = new System.Drawing.Point(707, 62);
            this.lblStandardEvents.Name = "lblStandardEvents";
            this.lblStandardEvents.Size = new System.Drawing.Size(86, 13);
            this.lblStandardEvents.TabIndex = 8;
            this.lblStandardEvents.Text = "Standard Events";
            // 
            // lstPivotalEventCharacters
            // 
            this.lstPivotalEventCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPivotalEventCharacters.FormattingEnabled = true;
            this.lstPivotalEventCharacters.Location = new System.Drawing.Point(579, 99);
            this.lstPivotalEventCharacters.Name = "lstPivotalEventCharacters";
            this.lstPivotalEventCharacters.Size = new System.Drawing.Size(125, 95);
            this.lstPivotalEventCharacters.TabIndex = 9;
            // 
            // lstDiscardPile
            // 
            this.lstDiscardPile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDiscardPile.FormattingEnabled = true;
            this.lstDiscardPile.Location = new System.Drawing.Point(328, 273);
            this.lstDiscardPile.Name = "lstDiscardPile";
            this.lstDiscardPile.Size = new System.Drawing.Size(150, 69);
            this.lstDiscardPile.TabIndex = 10;
            this.lstDiscardPile.SelectedIndexChanged += new System.EventHandler(this.lstDiscardPile_SelectedIndexChanged);
            // 
            // btnDiscardCard
            // 
            this.btnDiscardCard.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDiscardCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscardCard.Location = new System.Drawing.Point(329, 343);
            this.btnDiscardCard.Name = "btnDiscardCard";
            this.btnDiscardCard.Size = new System.Drawing.Size(149, 33);
            this.btnDiscardCard.TabIndex = 11;
            this.btnDiscardCard.Text = "Take";
            this.btnDiscardCard.UseVisualStyleBackColor = false;
            this.btnDiscardCard.Click += new System.EventHandler(this.btnDiscardCard_Click);
            // 
            // lblDiscardPile
            // 
            this.lblDiscardPile.AutoSize = true;
            this.lblDiscardPile.Location = new System.Drawing.Point(326, 257);
            this.lblDiscardPile.Name = "lblDiscardPile";
            this.lblDiscardPile.Size = new System.Drawing.Size(63, 13);
            this.lblDiscardPile.TabIndex = 12;
            this.lblDiscardPile.Text = "Discard Pile";
            // 
            // pictureMain
            // 
            this.pictureMain.Location = new System.Drawing.Point(1172, 13);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(500, 281);
            this.pictureMain.TabIndex = 13;
            this.pictureMain.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1684, 408);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.lblDiscardPile);
            this.Controls.Add(this.btnDiscardCard);
            this.Controls.Add(this.lstDiscardPile);
            this.Controls.Add(this.lstPivotalEventCharacters);
            this.Controls.Add(this.lblStandardEvents);
            this.Controls.Add(this.lblPivotalEvents);
            this.Controls.Add(this.lblCharacters);
            this.Controls.Add(this.btnPickEvent);
            this.Controls.Add(this.btnPickCharacter);
            this.Controls.Add(this.lstStandardEvents);
            this.Controls.Add(this.lstPivotalEvents);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.lblPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOST GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.ListBox lstPivotalEvents;
        private System.Windows.Forms.ListBox lstStandardEvents;
        private System.Windows.Forms.Button btnPickCharacter;
        private System.Windows.Forms.Button btnPickEvent;
        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.Label lblPivotalEvents;
        private System.Windows.Forms.Label lblStandardEvents;
        private System.Windows.Forms.ListBox lstPivotalEventCharacters;
        private System.Windows.Forms.ListBox lstDiscardPile;
        private System.Windows.Forms.Button btnDiscardCard;
        private System.Windows.Forms.Label lblDiscardPile;
        private System.Windows.Forms.PictureBox pictureMain;
    }
}