using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    [Serializable]
    class Music
    {
        public string lrcFilePath { get; set; }
        public string playListName { get; set; }
        public string musicName  { get;set;}
        public string musicFilePath { get; set; }
        public override string ToString()
        {
            return musicName;
        }
    }
}
