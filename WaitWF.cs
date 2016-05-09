using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MusicPlayer
{
    public partial class WaitWF : Form
    {
        private ListBox listBoxPlay;
        public WaitWF(ListBox listBox)
        {
            InitializeComponent();
            this.ControlBox = false;
            listBoxPlay = listBox;
            timerWait.Enabled = true;
            timerWait.Start();
        }

        private void DealInvalidMusic(string fileName)
        {   
            List<Music> musics = (List<Music>)ListHelper.readObjectFromFile(fileName);
            Boolean flag = false;
            List<Music> desMusics = new List<Music>();
            for (int i = 0; i < musics.Count; i++ )
            {
                string musicPath = musics[i].musicFilePath;
                Console.WriteLine(musicPath);
                if(!StringHelper.FileExists(musicPath))
                {
                    flag = true;
                }
                else
                {
                    desMusics.Add(musics[i]);
                }
            }
            if(flag)
            {
                ListHelper.WriteObjectToFile(fileName, desMusics);
            }
            this.Dispose();
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            timerWait.Enabled = false;
            timerWait.Stop();
            PlayList listPlay = (PlayList)listBoxPlay.SelectedItem;
            string fileName = listPlay.serializableFile;
            DealInvalidMusic(fileName);
        }
    }
}
