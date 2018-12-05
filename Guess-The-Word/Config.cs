using System;
using System.Windows.Forms;

namespace Guess_The_Word
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            DifficultyCmb.SelectedIndex = 1;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (DifficultyCmb.SelectedIndex == - 1) { return; }

            Game GameFrm = new Game(DifficultyCmb.SelectedIndex);
            GameFrm.Show();
            this.Hide();
        }
    }
}
