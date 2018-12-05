using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Guess_The_Word
{
    public partial class Game : Form
    {
        private List<GButton> ButtonList = new List<GButton>();
        private List<GButton> SelectedButtons = new List<GButton>();
        private List<char> SelectedLetters = new List<char>();
        private Timer GTimer = new Timer();
        private string word;
        private int difficulty = 0, loopDelay = 35;

        public Game(int difficulty)
        {
            this.InitializeComponent();
            this.difficulty = difficulty;
            this.SetUpGame();
            this.ActiveControl = label1;
            this.GTimer.Interval = 60;
            this.GTimer.Tick += T_Tick;
        }
        private void SetUpGame()
        {
            int textBoxCount = 0;

            switch (difficulty)
            {
                case 0:
                    textBoxCount = 4;
                    break;
                case 1:
                    textBoxCount = 6;
                    break;
                case 2:
                    textBoxCount = 8;
                    break;
            }

            for (int i = 0; i < textBoxCount; i++)
            {
                GButton Button = new GButton();
                ButtonList.Add(Button);
                Button.Click += Button_Click;
                LettersFLP.Controls.Add(Button);
            }
            CenterControls();
            SetRandomWord();
        }
        private void SetRandomWord()
        {
            GTimer.Start();
        }
        private void T_Tick(object sender, EventArgs e)
        {
            word = GetRandomWord();
            string tempWord = Shuffle(word);

            for (int b = 0; b < ButtonList.Count; b++)
            {
                ButtonList[b].FlatAppearance.BorderColor = Color.Gainsboro;
                ButtonList[b].Text = tempWord[b].ToString();
            }

            if (loopDelay == 0)
            {
                GTimer.Stop();

                for (int b = 0; b < ButtonList.Count; b++)
                {
                    ButtonList[b].FlatAppearance.BorderColor = Color.CornflowerBlue;
                }
                loopDelay = 35;
                return;
            }
            loopDelay--;
        }
        public string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        private string GetRandomWord()
        {
            string[] lines = null;

            switch (difficulty)
            {
                case 0:
                    lines = File.ReadAllLines("4Letters.txt");
                    break;
                case 1:
                    lines = File.ReadAllLines("6Letters.txt");
                    break;
                case 2:
                    lines = File.ReadAllLines("8Letters.txt");
                    break;
            }

            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            return lines[randomLineNumber].ToUpper();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            GButton Button = sender as GButton;
            Button.FlatAppearance.BorderColor = Color.Gainsboro;

            SelectedButtons.Add(Button);
            SelectedLetters.Add(Convert.ToChar(Button.Text));

            if (SelectedLetters.Count == 2)
            {
                SelectedButtons[0].Text = SelectedLetters[1].ToString();
                SelectedButtons[1].Text = SelectedLetters[0].ToString();
                SelectedButtons.Clear();
                SelectedLetters.Clear();

                string tempWord = string.Empty;

                for (int b = 0; b < ButtonList.Count; b++)
                {
                    tempWord = tempWord + ButtonList[b].Text;
                    ButtonList[b].FlatAppearance.BorderColor = Color.CornflowerBlue;
                }

                if (tempWord == word)
                {
                    for (int b = 0; b < ButtonList.Count; b++)
                    {
                        ButtonList[b].FlatAppearance.BorderColor = Color.SeaGreen;
                    }
                }
            }
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            for (int b = 0; b < ButtonList.Count; b++)
            {
                ButtonList[b].FlatAppearance.BorderColor = Color.CornflowerBlue;
            }
            SetRandomWord();
        }
        private void RevealBtn_Click(object sender, EventArgs e)
        {
            for(int b = 0; b < ButtonList.Count; b++)
            {
                ButtonList[b].Text = word[b].ToString();
                ButtonList[b].FlatAppearance.BorderColor = Color.SeaGreen;
            }
        }
        private void CenterControls()
        {
            int w = LettersFLP.ClientSize.Width;
            int marge = (w - ButtonList.Sum(x => x.Width)) / 2;
            Padding oldM = ButtonList[0].Margin;
            ButtonList.First().Margin = new Padding(marge, oldM.Top, oldM.Right, oldM.Bottom);
            ButtonList.Last().Margin = new Padding(oldM.Left, oldM.Top, oldM.Right, marge);
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
