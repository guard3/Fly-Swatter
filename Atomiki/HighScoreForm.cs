using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atomiki
{
    public partial class HighScoreForm : Form
    {
        public HighScoreForm(int _Level)
        {
            InitializeComponent();

            //MessageBox.Show((nameTextBox.Location.X - highscoreLabel.Location.X - highscoreLabel.Height).ToString());
            //highscoreLabel.MinimumSize = new Size(ClientSize.Width - 24, 0);
            highscoreLabel.Text = "New high score for\n";
            switch (_Level)
            {
                case 0: highscoreLabel.Text += "beginner"; break;
                case 1: highscoreLabel.Text += "intermediate"; break;
                case 2: highscoreLabel.Text += "expert"; break;
            }
            highscoreLabel.Text += " level!\nType your name:";
            highscoreLabel.Location = new Point(ClientSize.Width / 2 - highscoreLabel.Width / 2, highscoreLabel.Location.Y);
            nameTextBox.Location = new Point(nameTextBox.Location.X, highscoreLabel.Location.Y + highscoreLabel.Height + 5);
            okButton.Location = new Point(okButton.Location.X, nameTextBox.Location.Y + nameTextBox.Height + 5);
            ClientSize = new Size(ClientSize.Width, okButton.Location.Y + okButton.Height + 12);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MainForm.NewHighScoreName = nameTextBox.Text == "" ? "Anonymous" : nameTextBox.Text;
            this.Close();
        }
    }
}
