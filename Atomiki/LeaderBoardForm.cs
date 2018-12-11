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
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm(Settings _Settings)
        {
            InitializeComponent();
            beginnerNameLabel.Text = _Settings.levelInfos[0].name;
            beginnerScoreLabel.Text = _Settings.levelInfos[0].score.ToString();
            intermediateNameLabel.Text = _Settings.levelInfos[1].name;
            intermediateScoreLabel.Text = _Settings.levelInfos[1].score.ToString();
            expertNameLabel.Text = _Settings.levelInfos[2].name;
            expertScoreLabel.Text = _Settings.levelInfos[2].score.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
