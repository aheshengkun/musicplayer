using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    class LyricEntry
    {
        public string lyric { get; set; }
        public int offset { get; set; }
        public string time { get; set; }
        public override string ToString()
        {
            return lyric;
        }
    }
}
