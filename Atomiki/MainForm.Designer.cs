namespace Atomiki
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.beginnerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.expertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.soundMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.gamePlayTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundColourDialog = new System.Windows.Forms.ColorDialog();
            this.swatter_hit = new System.Windows.Forms.PictureBox();
            this.swatter = new System.Windows.Forms.PictureBox();
            this.fly = new System.Windows.Forms.PictureBox();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swatter_hit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swatter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(314, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MouseEnter += new System.EventHandler(this.menuStrip_MouseEnter);
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.beginnerToolStripMenuItem,
            this.beginnerMenu,
            this.intermediateMenu,
            this.expertMenu,
            this.highScoresToolStripMenuItem,
            this.soundMenu,
            this.separatorToolStripMenuItem,
            this.backgroundMenu,
            this.leaderboardMenu,
            this.exitMenu});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // beginnerMenu
            // 
            this.beginnerMenu.Name = "beginnerMenu";
            this.beginnerMenu.ShortcutKeyDisplayString = "";
            this.beginnerMenu.Size = new System.Drawing.Size(180, 22);
            this.beginnerMenu.Text = "Beginner";
            this.beginnerMenu.Click += new System.EventHandler(this.beginnerMenu_Click);
            // 
            // intermediateMenu
            // 
            this.intermediateMenu.Name = "intermediateMenu";
            this.intermediateMenu.ShortcutKeyDisplayString = "";
            this.intermediateMenu.Size = new System.Drawing.Size(180, 22);
            this.intermediateMenu.Text = "Intermediate";
            this.intermediateMenu.Click += new System.EventHandler(this.intermediateMenu_Click);
            // 
            // expertMenu
            // 
            this.expertMenu.Name = "expertMenu";
            this.expertMenu.ShortcutKeyDisplayString = "";
            this.expertMenu.Size = new System.Drawing.Size(180, 22);
            this.expertMenu.Text = "Expert";
            this.expertMenu.Click += new System.EventHandler(this.expertMenu_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // soundMenu
            // 
            this.soundMenu.CheckOnClick = true;
            this.soundMenu.Name = "soundMenu";
            this.soundMenu.ShortcutKeyDisplayString = "";
            this.soundMenu.Size = new System.Drawing.Size(180, 22);
            this.soundMenu.Text = "Music";
            this.soundMenu.Click += new System.EventHandler(this.soundMenu_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayMenu,
            this.aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // movementTimer
            // 
            this.movementTimer.Interval = 10;
            this.movementTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.BackColor = System.Drawing.Color.White;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingTimeLabel.Location = new System.Drawing.Point(226, 0);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(88, 15);
            this.remainingTimeLabel.TabIndex = 2;
            this.remainingTimeLabel.Text = "remaining time";
            this.remainingTimeLabel.Visible = false;
            // 
            // gamePlayTimer
            // 
            this.gamePlayTimer.Interval = 1000;
            this.gamePlayTimer.Tick += new System.EventHandler(this.gamePlayTimer_Tick);
            // 
            // backgroundColourDialog
            // 
            this.backgroundColourDialog.Color = System.Drawing.SystemColors.Control;
            // 
            // swatter_hit
            // 
            this.swatter_hit.Image = global::Atomiki.Properties.Resources.swatter_hit;
            this.swatter_hit.Location = new System.Drawing.Point(244, 76);
            this.swatter_hit.Name = "swatter_hit";
            this.swatter_hit.Size = new System.Drawing.Size(64, 128);
            this.swatter_hit.TabIndex = 4;
            this.swatter_hit.TabStop = false;
            this.swatter_hit.Visible = false;
            // 
            // swatter
            // 
            this.swatter.Image = global::Atomiki.Properties.Resources.swatter;
            this.swatter.Location = new System.Drawing.Point(174, 76);
            this.swatter.Name = "swatter";
            this.swatter.Size = new System.Drawing.Size(64, 128);
            this.swatter.TabIndex = 3;
            this.swatter.TabStop = false;
            this.swatter.Visible = false;
            // 
            // fly
            // 
            this.fly.Image = global::Atomiki.Properties.Resources.fly;
            this.fly.Location = new System.Drawing.Point(96, 86);
            this.fly.Name = "fly";
            this.fly.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.fly.Size = new System.Drawing.Size(51, 51);
            this.fly.TabIndex = 1;
            this.fly.TabStop = false;
            this.fly.Visible = false;
            this.fly.Click += new System.EventHandler(this.fly_Click);
            this.fly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fly_MouseDown);
            this.fly.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fly_MouseUp);
            // 
            // newMenu
            // 
            this.newMenu.Image = global::Atomiki.Properties.Resources._new;
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeyDisplayString = "F2";
            this.newMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newMenu.Size = new System.Drawing.Size(180, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // backgroundMenu
            // 
            this.backgroundMenu.Image = global::Atomiki.Properties.Resources.background;
            this.backgroundMenu.Name = "backgroundMenu";
            this.backgroundMenu.Size = new System.Drawing.Size(180, 22);
            this.backgroundMenu.Text = "Background";
            this.backgroundMenu.Click += new System.EventHandler(this.backgroundMenu_Click);
            // 
            // leaderboardMenu
            // 
            this.leaderboardMenu.Image = global::Atomiki.Properties.Resources.leaderboard;
            this.leaderboardMenu.Name = "leaderboardMenu";
            this.leaderboardMenu.Size = new System.Drawing.Size(180, 22);
            this.leaderboardMenu.Text = "Leaderboard";
            this.leaderboardMenu.Click += new System.EventHandler(this.leaderboardMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Image = global::Atomiki.Properties.Resources.exit;
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeyDisplayString = "Alt+F4";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // howToPlayMenu
            // 
            this.howToPlayMenu.Image = global::Atomiki.Properties.Resources.help;
            this.howToPlayMenu.Name = "howToPlayMenu";
            this.howToPlayMenu.Size = new System.Drawing.Size(138, 22);
            this.howToPlayMenu.Text = "How to play";
            this.howToPlayMenu.Click += new System.EventHandler(this.howToPlayMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = global::Atomiki.Properties.Resources.info;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(138, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.swatter_hit);
            this.Controls.Add(this.swatter);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.fly);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fly Swatter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swatter_hit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swatter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem beginnerMenu;
        private System.Windows.Forms.ToolStripMenuItem intermediateMenu;
        private System.Windows.Forms.ToolStripMenuItem expertMenu;
        private System.Windows.Forms.ToolStripMenuItem soundMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.PictureBox fly;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Timer gamePlayTimer;
        private System.Windows.Forms.ToolStripMenuItem leaderboardMenu;
        private System.Windows.Forms.PictureBox swatter;
        private System.Windows.Forms.PictureBox swatter_hit;
        private System.Windows.Forms.ToolStripMenuItem howToPlayMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenu;
        private System.Windows.Forms.ColorDialog backgroundColourDialog;
    }
}

