namespace Atomiki
{
    partial class HowToPlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayForm));
            this.howToPlayTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // howToPlayTextBox
            // 
            this.howToPlayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.howToPlayTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.howToPlayTextBox.Location = new System.Drawing.Point(0, 0);
            this.howToPlayTextBox.Name = "howToPlayTextBox";
            this.howToPlayTextBox.ReadOnly = true;
            this.howToPlayTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.howToPlayTextBox.Size = new System.Drawing.Size(235, 323);
            this.howToPlayTextBox.TabIndex = 0;
            this.howToPlayTextBox.Text = resources.GetString("howToPlayTextBox.Text");
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 323);
            this.Controls.Add(this.howToPlayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HowToPlayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "How To Play";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox howToPlayTextBox;
    }
}