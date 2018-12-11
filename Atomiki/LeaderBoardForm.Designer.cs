namespace Atomiki
{
    partial class LeaderBoardForm
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
            this.beginnerGroup = new System.Windows.Forms.GroupBox();
            this.beginnerScoreLabel = new System.Windows.Forms.Label();
            this.beginnerNameLabel = new System.Windows.Forms.Label();
            this.intermediateGroup = new System.Windows.Forms.GroupBox();
            this.intermediateScoreLabel = new System.Windows.Forms.Label();
            this.intermediateNameLabel = new System.Windows.Forms.Label();
            this.expertGroup = new System.Windows.Forms.GroupBox();
            this.expertScoreLabel = new System.Windows.Forms.Label();
            this.expertNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.beginnerGroup.SuspendLayout();
            this.intermediateGroup.SuspendLayout();
            this.expertGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginnerGroup
            // 
            this.beginnerGroup.Controls.Add(this.beginnerScoreLabel);
            this.beginnerGroup.Controls.Add(this.beginnerNameLabel);
            this.beginnerGroup.Location = new System.Drawing.Point(12, 12);
            this.beginnerGroup.Name = "beginnerGroup";
            this.beginnerGroup.Size = new System.Drawing.Size(162, 38);
            this.beginnerGroup.TabIndex = 0;
            this.beginnerGroup.TabStop = false;
            this.beginnerGroup.Text = "Beginner";
            // 
            // beginnerScoreLabel
            // 
            this.beginnerScoreLabel.AutoSize = true;
            this.beginnerScoreLabel.Location = new System.Drawing.Point(116, 16);
            this.beginnerScoreLabel.Name = "beginnerScoreLabel";
            this.beginnerScoreLabel.Size = new System.Drawing.Size(33, 13);
            this.beginnerScoreLabel.TabIndex = 1;
            this.beginnerScoreLabel.Text = "score";
            // 
            // beginnerNameLabel
            // 
            this.beginnerNameLabel.AutoSize = true;
            this.beginnerNameLabel.Location = new System.Drawing.Point(6, 16);
            this.beginnerNameLabel.Name = "beginnerNameLabel";
            this.beginnerNameLabel.Size = new System.Drawing.Size(103, 13);
            this.beginnerNameLabel.TabIndex = 0;
            this.beginnerNameLabel.Text = "gggggggggggggggg";
            // 
            // intermediateGroup
            // 
            this.intermediateGroup.Controls.Add(this.intermediateScoreLabel);
            this.intermediateGroup.Controls.Add(this.intermediateNameLabel);
            this.intermediateGroup.Location = new System.Drawing.Point(12, 56);
            this.intermediateGroup.Name = "intermediateGroup";
            this.intermediateGroup.Size = new System.Drawing.Size(162, 38);
            this.intermediateGroup.TabIndex = 2;
            this.intermediateGroup.TabStop = false;
            this.intermediateGroup.Text = "Intermediate";
            // 
            // intermediateScoreLabel
            // 
            this.intermediateScoreLabel.AutoSize = true;
            this.intermediateScoreLabel.Location = new System.Drawing.Point(116, 16);
            this.intermediateScoreLabel.Name = "intermediateScoreLabel";
            this.intermediateScoreLabel.Size = new System.Drawing.Size(33, 13);
            this.intermediateScoreLabel.TabIndex = 1;
            this.intermediateScoreLabel.Text = "score";
            // 
            // intermediateNameLabel
            // 
            this.intermediateNameLabel.AutoSize = true;
            this.intermediateNameLabel.Location = new System.Drawing.Point(6, 16);
            this.intermediateNameLabel.Name = "intermediateNameLabel";
            this.intermediateNameLabel.Size = new System.Drawing.Size(103, 13);
            this.intermediateNameLabel.TabIndex = 0;
            this.intermediateNameLabel.Text = "gggggggggggggggg";
            // 
            // expertGroup
            // 
            this.expertGroup.Controls.Add(this.expertScoreLabel);
            this.expertGroup.Controls.Add(this.expertNameLabel);
            this.expertGroup.Location = new System.Drawing.Point(12, 100);
            this.expertGroup.Name = "expertGroup";
            this.expertGroup.Size = new System.Drawing.Size(162, 38);
            this.expertGroup.TabIndex = 2;
            this.expertGroup.TabStop = false;
            this.expertGroup.Text = "Expert";
            // 
            // expertScoreLabel
            // 
            this.expertScoreLabel.AutoSize = true;
            this.expertScoreLabel.Location = new System.Drawing.Point(116, 16);
            this.expertScoreLabel.Name = "expertScoreLabel";
            this.expertScoreLabel.Size = new System.Drawing.Size(33, 13);
            this.expertScoreLabel.TabIndex = 1;
            this.expertScoreLabel.Text = "score";
            // 
            // expertNameLabel
            // 
            this.expertNameLabel.AutoSize = true;
            this.expertNameLabel.Location = new System.Drawing.Point(6, 16);
            this.expertNameLabel.Name = "expertNameLabel";
            this.expertNameLabel.Size = new System.Drawing.Size(103, 13);
            this.expertNameLabel.TabIndex = 0;
            this.expertNameLabel.Text = "gggggggggggggggg";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(53, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // LeaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 174);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.expertGroup);
            this.Controls.Add(this.intermediateGroup);
            this.Controls.Add(this.beginnerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LeaderBoardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leaderboard";
            this.TopMost = true;
            this.beginnerGroup.ResumeLayout(false);
            this.beginnerGroup.PerformLayout();
            this.intermediateGroup.ResumeLayout(false);
            this.intermediateGroup.PerformLayout();
            this.expertGroup.ResumeLayout(false);
            this.expertGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox beginnerGroup;
        private System.Windows.Forms.Label beginnerScoreLabel;
        private System.Windows.Forms.Label beginnerNameLabel;
        private System.Windows.Forms.GroupBox intermediateGroup;
        private System.Windows.Forms.Label intermediateScoreLabel;
        private System.Windows.Forms.Label intermediateNameLabel;
        private System.Windows.Forms.GroupBox expertGroup;
        private System.Windows.Forms.Label expertScoreLabel;
        private System.Windows.Forms.Label expertNameLabel;
        private System.Windows.Forms.Button okButton;
    }
}