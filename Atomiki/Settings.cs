using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atomiki
{
    [Serializable]
    public class Score
    {
        public UInt32 score = 0;
        public string name = "Anonymous";
    }

    [Serializable]
    public class Settings
    {
        public Byte level = 0;
        public bool sound = true;
        public Color background = SystemColors.Control;
        public Score[] levelInfos = { new Score(), new Score(), new Score() };
    }
}
