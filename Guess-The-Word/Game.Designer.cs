namespace Guess_The_Word
{
    partial class Game
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
            this.LettersFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RevealBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LettersFLP
            // 
            this.LettersFLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LettersFLP.Location = new System.Drawing.Point(33, 262);
            this.LettersFLP.Name = "LettersFLP";
            this.LettersFLP.Size = new System.Drawing.Size(702, 65);
            this.LettersFLP.TabIndex = 0;
            // 
            // RevealBtn
            // 
            this.RevealBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.RevealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevealBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.RevealBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.RevealBtn.Location = new System.Drawing.Point(408, 194);
            this.RevealBtn.Name = "RevealBtn";
            this.RevealBtn.Size = new System.Drawing.Size(99, 37);
            this.RevealBtn.TabIndex = 4;
            this.RevealBtn.Text = "Reveal";
            this.RevealBtn.UseVisualStyleBackColor = true;
            this.RevealBtn.Click += new System.EventHandler(this.RevealBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NewBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewBtn.Location = new System.Drawing.Point(288, 194);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(110, 37);
            this.NewBtn.TabIndex = 5;
            this.NewBtn.Text = "New Word";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(809, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.RevealBtn);
            this.Controls.Add(this.LettersFLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Word - by Richard Jacobs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LettersFLP;
        private System.Windows.Forms.Button RevealBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Label label1;
    }
}

