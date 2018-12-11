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
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();

            howToPlayTextBox.SelectionStart = 0;
            for (int i = 0; i < 3; i++) howToPlayTextBox.SelectionStart += howToPlayTextBox.Lines[i].Length + 1;
            howToPlayTextBox.SelectionLength = howToPlayTextBox.Lines[3].Length;
            howToPlayTextBox.SelectionFont = new Font(howToPlayTextBox.Font, FontStyle.Bold);
            //howToPlayTextBox.SelectionStart++;
            for (int i = 3; i < 10; i++) howToPlayTextBox.SelectionStart += howToPlayTextBox.Lines[i].Length + 1;
            howToPlayTextBox.SelectionLength = howToPlayTextBox.Lines[10].Length;
            howToPlayTextBox.SelectionFont = new Font(howToPlayTextBox.Font, FontStyle.Bold);
            for (int i = 10; i < 13; i++) howToPlayTextBox.SelectionStart += howToPlayTextBox.Lines[i].Length + 1;
            howToPlayTextBox.SelectionLength = howToPlayTextBox.Lines[13].Length;
            howToPlayTextBox.SelectionFont = new Font(howToPlayTextBox.Font, FontStyle.Bold);
            for (int i = 13; i < 29; i++) howToPlayTextBox.SelectionStart += howToPlayTextBox.Lines[i].Length + 1;
            howToPlayTextBox.SelectionLength = howToPlayTextBox.Lines[29].Length;
            howToPlayTextBox.SelectionFont = new Font(howToPlayTextBox.Font, FontStyle.Bold);
            howToPlayTextBox.SelectionStart = 0;
            howToPlayTextBox.SelectionLength = 0;
        }
    }
}
