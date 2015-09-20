namespace LostCardGame
{
    partial class CharacterCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCardForm));
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(12, 9);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(61, 24);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Name";
            // 
            // CharacterCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.lblCharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterName;
    }
}