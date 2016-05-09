using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlayListWF : Form
    {
        private ListBox listBoxPlayList;
        private Boolean isEdit = false;
        private string name;
        public PlayListWF(ListBox listBox, Boolean flag = false)
        {
            listBoxPlayList = listBox;
            isEdit = flag;
            InitializeComponent();
            if (isEdit == true)
            {
                PlayList tmp = (PlayList)listBoxPlayList.SelectedItem;
                name = tmp.playListName;
                textBoxListName.Text = name;
                this.Text = "编辑播放列表";
            }
            else
            {
                this.Text = "新建播放列表";
            }
        }
        private void Add(string name)
        {
            //实列化 分组对象
            PlayList playList = new PlayList();
            string fileName = ConstantParams.playListFilePath + "//" + name + ".properties";
            playList.serializableFile = fileName;
            playList.playListName = name;
            //将对象 存入playlist
            listBoxPlayList.Items.Add(playList);
            //创建 音乐对象的序列化文件
            List<Music> muiscList = new List<Music>();
            ListHelper.WriteObjectToFile(fileName, muiscList);
        }
        private Boolean IsSame(string name)
        {
            Boolean flag = false;
            foreach (object obj in listBoxPlayList.Items)
            {
                if (obj.ToString() == name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private Boolean SaveAdd(string name)
        {
            if(IsSame(name))
            {
                MessageBox.Show("列表名已经存在");
                return false;
            }
            else
            {
                Add(name);
                //将playlist对象重新序列化到文件
                ListHelper.WriteListItem(listBoxPlayList);
                return true;
            }
        }

        private Boolean SaveEdit(string name)
        {
            if(IsSame(name))
            {
                MessageBox.Show("列表名已经存在");
                return false;
            }
            else
            {
                string desFile = ConstantParams.playListFilePath + "//" + name + ".properties";
                PlayList tempList = (PlayList)listBoxPlayList.SelectedItem;
                string srcFile = tempList.serializableFile;
                tempList.playListName = name;
                tempList.serializableFile = desFile;
                listBoxPlayList.Update();
                StringHelper.ChangeFileName(srcFile, desFile);
                ListHelper.WriteListItem(listBoxPlayList);
                //修改对应的音乐类别属性
                List<Music> musics = (List<Music>)ListHelper.readObjectFromFile(desFile);
                for (int i = 0; i < musics.Count; i++)
                {
                    musics[i].playListName = name;
                }
                ListHelper.WriteObjectToFile(desFile, musics);
                return true;
            }
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBoxListName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("列表名不能为空");
                return ;
            }
            if (isEdit == true)
            {
                if (SaveEdit(name))
                {
                    this.Dispose();
                }
            }
            else 
            {
                if(SaveAdd(name))
                {
                    this.Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
