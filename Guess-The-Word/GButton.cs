using System;
using System.Windows.Forms;

namespace Guess_The_Word
{
    class GButton : Button
    {
        public GButton()
        {
            this.Size = new System.Drawing.Size(60, 60);
            this.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 20);
            this.BackColor = System.Drawing.Color.FromArgb(0, 0, 20);
            this.Font = new System.Drawing.Font("Century Gothic", 24, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
}
