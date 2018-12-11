using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atomiki
{
    public partial class MainForm : Form
    {
        Settings gameSettings;
        Random rand = new Random();
        Rectangle playArea;
        bool isGameRunning = false;
        Cursor swatterCursor, swatterHitCursor;

        enum Volume : uint
        {
            Normal = 1717986918
        }
        
        SoundPlayer gameMusic = new SoundPlayer();

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        // Form constructor
        public MainForm()
        {
            InitializeComponent();
            
            // Create swatter cursors
            swatterCursor = new Cursor(((Bitmap)swatter.Image).GetHicon());
            swatterHitCursor = new Cursor(((Bitmap)swatter_hit.Image).GetHicon());

            // Load settings
            try
            {
                using (Stream stream = File.Open("swat.fly", FileMode.Open))
                {
                    gameSettings = (Settings)new BinaryFormatter().Deserialize(stream);
                }
            }
            catch (Exception)
            {
                gameSettings = new Settings();
            }

            // Adjust form size depending on the predefined level
            switch (gameSettings.level)
            {
                case 0:
                    beginnerMenu.Checked = true;
                    this.ClientSize = new Size(256, 256 + menuStrip.Height);
                    break;
                case 1:
                    intermediateMenu.Checked = true;
                    this.ClientSize = new Size(384, 384 + menuStrip.Height);
                    break;
                case 2:
                    expertMenu.Checked = true;
                    this.ClientSize = new Size(512, 384 + menuStrip.Height);
                    break;
            }

            this.BackColor = gameSettings.background;

            // Final stuff
            if (gameSettings.sound)
            {
                soundMenu.Checked = true;
                waveOutSetVolume(IntPtr.Zero, (uint)Volume.Normal);
            }
            else
            {
                soundMenu.Checked = false;
                waveOutSetVolume(IntPtr.Zero, 0);
            }
            menuStrip.BringToFront();
            remainingTimeLabel.BringToFront();
        }

        // Menu strip level and sound events
        private void beginnerMenu_Click(object sender, EventArgs e)
        {
            if (intermediateMenu.Checked || expertMenu.Checked)
            {
                beginnerMenu.Checked = true;
                intermediateMenu.Checked = false;
                expertMenu.Checked = false;
            }
            else beginnerMenu.Checked = true;
            gameSettings.level = 0;
            if (!isGameRunning) this.ClientSize = new Size(256, 256 + menuStrip.Height);
        }
        private void intermediateMenu_Click(object sender, EventArgs e)
        {
            if (beginnerMenu.Checked || expertMenu.Checked)
            {
                beginnerMenu.Checked = false;
                intermediateMenu.Checked = true;
                expertMenu.Checked = false;
            }
            else intermediateMenu.Checked = true;
            gameSettings.level = 1;
            if (!isGameRunning) this.ClientSize = new Size(384, 384 + menuStrip.Height);
        }
        private void expertMenu_Click(object sender, EventArgs e)
        {
            if (beginnerMenu.Checked || intermediateMenu.Checked)
            {
                beginnerMenu.Checked = false;
                intermediateMenu.Checked = false;
                expertMenu.Checked = true;
            }
            else expertMenu.Checked = true;
            gameSettings.level = 2;
            if (!isGameRunning) this.ClientSize = new Size(512, 384 + menuStrip.Height);
        }
        private void soundMenu_Click(object sender, EventArgs e)
        {
            if (soundMenu.Checked)
            {
                gameSettings.sound = true;
                waveOutSetVolume(IntPtr.Zero, (uint)Volume.Normal);
            }
            else
            {
                gameSettings.sound = false;
                waveOutSetVolume(IntPtr.Zero, 0);
            }
        }
        private void backgroundMenu_Click(object sender, EventArgs e)
        {
            backgroundColourDialog.ShowDialog();
            this.BackColor = backgroundColourDialog.Color;
            gameSettings.background = backgroundColourDialog.Color;
        }
        private void leaderboardMenu_Click(object sender, EventArgs e)
        {
            new LeaderBoardForm(gameSettings).ShowDialog();
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void howToPlayMenu_Click(object sender, EventArgs e)
        {
            new HowToPlayForm().ShowDialog();
        }
        private void aboutMenu_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (Stream stream = File.Open("swat.fly", FileMode.Create))
            {
                new BinaryFormatter().Serialize(stream, gameSettings);
            }
        }
        
        // Gameplay variables
        int offsetX, offsetY;
        bool randomAllowed = true;
        int elapsedTime, totalRemainingTime;
        uint score, consecutive;
        public static string NewHighScoreName { set; get; }

        private void newMenu_Click(object sender, EventArgs e)
        {
            switch (gameSettings.level)
            {
                case 0:
                    this.ClientSize = new Size(256, 256 + menuStrip.Height);
                    movementTimer.Interval = 20;
                    totalRemainingTime = 60000;
                    gameMusic = new SoundPlayer("audio\\beginner.wav");
                    break;
                case 1:
                    this.ClientSize = new Size(384, 384 + menuStrip.Height);
                    movementTimer.Interval = 10;
                    totalRemainingTime = 55000;
                    gameMusic = new SoundPlayer("audio\\intermediate.wav");
                    break;
                case 2:
                    this.ClientSize = new Size(512, 384 + menuStrip.Height);
                    movementTimer.Interval = 1;
                    totalRemainingTime = 50000;
                    gameMusic = new SoundPlayer("audio\\expert.wav");
                    break;
            }
            gameMusic.Load();
            elapsedTime = 0;
            playArea = new Rectangle(this.ClientRectangle.X - 15, this.ClientRectangle.Y + menuStrip.Height - 15, ClientSize.Width - /*32*/ 47, ClientSize.Height - /*32*/ 47); ;
            fly.Location = new Point(playArea.X + playArea.Width / 2, playArea.Y + playArea.Height / 2);
            fly.Visible = true;
            remainingTimeLabel.Text = "Time: " + (totalRemainingTime / 60000).ToString() + ":" + (totalRemainingTime % 60000 / 1000 < 10 ? "0" : "") + (totalRemainingTime % 60000 / 1000).ToString();
            remainingTimeLabel.Location = new Point(ClientRectangle.X + ClientSize.Width - remainingTimeLabel.Width, ClientRectangle.Y + menuStrip.Height / 2 - remainingTimeLabel.Height / 2);
            remainingTimeLabel.Visible = true;
            score = 0;
            consecutive = 0;
            this.Text = "Score: " + score.ToString();
            movementTimer.Start();
            gamePlayTimer.Start();
            isGameRunning = true;
            this.Cursor = swatterCursor;
            gameMusic.Play();
        }

        // -----Cursor handling methods-----
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (isGameRunning) this.Cursor = swatterHitCursor;
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isGameRunning) this.Cursor = swatterCursor;
        }
        private void fly_MouseDown(object sender, MouseEventArgs e)
        {
            if (isGameRunning) this.Cursor = swatterHitCursor;
        }
        private void fly_MouseUp(object sender, MouseEventArgs e)
        {
            if (isGameRunning) this.Cursor = swatterCursor;
        }
        private void menuStrip_MouseEnter(object sender, EventArgs e)
        {
            if (isGameRunning) this.Cursor = DefaultCursor;
        }
        private void menuStrip_MouseLeave(object sender, EventArgs e)
        {
            if (isGameRunning) this.Cursor = swatterCursor;
        }

        // -----Gameplay methods-----
        private void gamePlayTimer_Tick(object sender, EventArgs e)
        {
            totalRemainingTime -= gamePlayTimer.Interval;
            remainingTimeLabel.Text = "Time: " + (totalRemainingTime / 60000).ToString() + ":" + (totalRemainingTime % 60000 / 1000 < 10 ? "0" : "") + (totalRemainingTime % 60000 / 1000).ToString();
        }

        private void fly_Click(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                score++;
                consecutive++;
                this.Text = "Score: " + score.ToString() + (consecutive > 2 ? " +" + (consecutive - 2).ToString() : string.Empty);
            }
        }
        private void MainForm_Click(object sender, EventArgs e)
        {
            if (isGameRunning && consecutive > 2)
            {
                score += consecutive < 3 ? 0 : consecutive - 2;
                this.Text = "Score: " + score.ToString();
                consecutive = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // End game when time runs out
            if (totalRemainingTime <= 0)
            {
                gameMusic.Stop();
                this.Cursor = DefaultCursor;
                score += consecutive < 3 ? 0: consecutive - 2;
                this.Text = "Score: " + score.ToString();
                randomAllowed = true;
                movementTimer.Stop();
                gamePlayTimer.Stop();
                fly.Visible = false;
                isGameRunning = false;
                if (score > gameSettings.levelInfos[gameSettings.level].score)
                {
                    // Update leaderboard settings (name and score)
                    new HighScoreForm(gameSettings.level).ShowDialog();
                    gameSettings.levelInfos[gameSettings.level].score = score;
                    gameSettings.levelInfos[gameSettings.level].name = NewHighScoreName;

                    // Show leaderboard
                    new LeaderBoardForm(gameSettings).ShowDialog();
                }
                else MessageBox.Show("Game over!\nScore: " + score.ToString());
                this.Text = "Fly Swatter";
                score = 0;
                consecutive = 0;
                remainingTimeLabel.Visible = false;
                return;
            }
            
            // Generate new random fly coordinate offset
            elapsedTime += movementTimer.Interval;
            if (randomAllowed)
            {
                do
                {
                    offsetX = rand.Next() % 5 - 2;
                    offsetY = rand.Next() % 5 - 2;
                } while ((offsetX == 0 && offsetY == 0) || (offsetX == 2 && offsetY == 2));
                randomAllowed = false;
            }
            else
            {
                if (elapsedTime > (rand.Next() % 11 + 20) * movementTimer.Interval)
                {
                    randomAllowed = true;
                    elapsedTime = 0;
                }
            }
            
            // Change offset if fly is about to reach borders, so that it "bounces" back into the playable area
            offsetX = fly.Location.X + offsetX > playArea.Width ? -offsetX : offsetX;
            offsetY = fly.Location.Y + offsetY > playArea.Height ? -offsetY : offsetY;
            offsetX = fly.Location.X + offsetX < playArea.X ? -offsetX : offsetX;
            offsetY = fly.Location.Y + offsetY < playArea.Y ? -offsetY : offsetY;

            // Change fly's coordinates on the screen
            fly.Location = new Point(fly.Location.X + offsetX, fly.Location.Y + offsetY);
        }
    }
}
