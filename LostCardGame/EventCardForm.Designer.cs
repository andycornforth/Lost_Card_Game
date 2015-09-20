namespace LostCardGame
{
    partial class EventCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCardForm));
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventType.Location = new System.Drawing.Point(94, 9);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(43, 20);
            this.lblEventType.TabIndex = 0;
            this.lblEventType.Text = "Type";
            this.lblEventType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(226, 38);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(46, 13);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Season ";
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.Location = new System.Drawing.Point(17, 117);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(120, 82);
            this.lstCharacters.TabIndex = 3;
            // 
            // EventCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEventType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ListBox lstCharacters;
    }
}