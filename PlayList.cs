using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    [Serializable]
    class PlayList
    {
        public string playListName { get; set; }
        public string serializableFile { get; set; }
        public override string ToString()
        {
            return playListName;
        }
    }

}
