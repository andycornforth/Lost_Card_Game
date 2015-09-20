namespace LostCardGame
{
    partial class SwapCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwapCardForm));
            this.lstPlayerCards = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlayerCards
            // 
            this.lstPlayerCards.FormattingEnabled = true;
            this.lstPlayerCards.Location = new System.Drawing.Point(12, 12);
            this.lstPlayerCards.Name = "lstPlayerCards";
            this.lstPlayerCards.Size = new System.Drawing.Size(260, 95);
            this.lstPlayerCards.TabIndex = 0;
            this.lstPlayerCards.SelectedIndexChanged += new System.EventHandler(lstPlayerCards_SelectIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.Location = new System.Drawing.Point(13, 114);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(259, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Discard Card From Collection";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SwapCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstPlayerCards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SwapCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayerCards;
        private System.Windows.Forms.Button btnRemove;
    }
}