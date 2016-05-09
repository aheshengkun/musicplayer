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
    public partial class MainForm : Form
    {
        //begin 设置窗口可以拖动 
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;
        //end   设置窗口可以拖动

        //begin 设置播放进度条
        private int xPos;
        private bool moveFlag;
        private int minLeft; //播放进度条按钮 距离左边最小值
        private int maxLeft; //播放进度条按钮 距离左边最大值
        private int propressWidth; //播放进度条的宽度
        //end   设置播放进度条

        private PlayList currentPlayList; //当前选择的播放列表
        private Music currentMusic; //当前播放的音乐
        private Boolean isRun = false; //是否正在播放

        //选中要修改播放列表名
        private string selectName = "";

        //歌词优先选择那个， 如果是 “0”  优先选择系统默认的，如果是 “1”  优先用户设置的
        private string lrcLevel = "0";
        //歌词解析类
        LrcParser lrcParser = new LrcParser();
        //歌词窗口唯一
        Boolean isShowLrcWF = false;
        public MainForm()
        {
            InitializeComponent();
            InitSystem();
            InitPlayerProgressbar();
            InitSound();
            InitPlayModel();
            InitPlayList();
            //电脑左下角图标 右击菜单
            this.menuItemShow.Click += new EventHandler(this.ShowWindow);
            this.menuItemExit.Click += new EventHandler(this.CloseWindow);
            //播放列表 右击菜单
            this.itemDelPlayList.Click += new EventHandler(this.DelPlayList);
            this.itemEditPlayList.Click += new EventHandler(this.EditPlayList);
            this.itemClear.Click += new EventHandler(this.ShowWait);
            //音乐列表 右击菜单
            this.itemUp.Click += new EventHandler(this.UpMusic);
            this.itemDown.Click += new EventHandler(this.DownMusic);
            this.itemDelMusic.Click += new EventHandler(this.DelMusic);
            //歌词显示 右击菜单
            this.itemShowLrc.Click += new EventHandler(this.ShowLrcWindow); 
        }

        private void InitSystem()
        {
            StringHelper.CreateFileDirectory(ConstantParams.sysFilePath);
            StringHelper.CreateFileDirectory(ConstantParams.playListFilePath);
            StringHelper.CreateFileDirectory(ConstantParams.lrcFilePath);
            StringHelper.CreateFile(ConstantParams.playModelFile);
            StringHelper.CreateFile(ConstantParams.playSound);
            StringHelper.CreateFile(ConstantParams.lrcLevel);
            
        }

        private void InitPlayerProgressbar()
        {
            int left = lbPropree.Left;
            int size = picRun.Size.Width / 2 ;
            propressWidth = lbPropree.Size.Width;
            minLeft = left - size;
            picRun.Left = minLeft;
            maxLeft = left + propressWidth - 9;
        }

        private void InitSound()
        {
            string index = StringHelper.ReadToEnd(ConstantParams.playModelFile);
            Boolean flag = false;
            for (int i = 0; i < 11; i++)
            {
                string str = i.ToString();
                if (str == index)
                {
                    trackBarSound.Value = int.Parse(index);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                trackBarSound.Value = 5;
            }
        }

        private void InitPlayModel()
        {
            string index = StringHelper.ReadToEnd(ConstantParams.playModelFile);
            if ("0" == index || "1" == index || "2" == index || "3" == index)
            {
                comboBoxPlayModel.SelectedIndex = int.Parse(index);
            }
            else
            {
                comboBoxPlayModel.SelectedIndex = 0;
            }

        }

        private void InitPlayList()
        {
            ltBxPlayList.Items.Clear();
            string fileName = ConstantParams.sysFilePath + "//" + ConstantParams.playListSerializeFile;
            if (StringHelper.FileExists(fileName))
            {
                List<PlayList> tmpList = (List<PlayList>)ListHelper.readObjectFromFile(fileName);
                if (tmpList != null)
                {
                    for (int i = 0; i < tmpList.Count; i++)
                    {
                        ltBxPlayList.Items.Add(tmpList[i]);
                    }
                }
            }
        }

        private void DelPlayList(object sender, EventArgs e)
        {
            PlayList playList = (PlayList)ltBxPlayList.SelectedItem;
            DialogResult dr = MessageBox.Show("是否确认删除<" + playList.playListName + ">吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //用户选择确认的操作
                int i = ltBxPlayList.SelectedIndex;
                string delName = playList.playListName;
                ltBxPlayList.Items.Remove(ltBxPlayList.Items[i]);
                ListHelper.WriteListItem(ltBxPlayList);
                StringHelper.DeleteFile(playList.serializableFile);
                string playingList = lbPlayListName.Text;
                if(playingList == delName)
                {
                    listBoxMusics.Items.Clear();
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                //用户选择取消的操作
            }

        }

        private void EditEnd_Disposed(object sender, EventArgs e)
        {               
            int index = ltBxPlayList.SelectedIndex;
            PlayList pl = (PlayList)ltBxPlayList.SelectedItem;
            //播放列表名没有修改 
            if (selectName == pl.playListName)
            {
                return;
            }
            InitPlayList();
            ltBxPlayList.SelectedIndex = index;
            if (currentPlayList == null)
            {
                return;
            }
            if (this.lbPlayListName.Text == selectName)
            {
                string fileName = currentPlayList.serializableFile;
                List<Music> musics = (List<Music>)ListHelper.readObjectFromFile(fileName);
                listBoxMusics.Items.Clear();
                for (int i = 0; i < musics.Count; i++)
                {
                    listBoxMusics.Items.Add(musics[i]);
                }
                currentPlayList = null;
                currentPlayList = (PlayList)ltBxPlayList.SelectedItem;
                this.lbPlayListName.Text = currentPlayList.playListName;
            }
            if(currentMusic != null)
            {
                if(currentMusic.playListName == selectName)
                {
                    currentMusic.playListName = currentPlayList.playListName;
                }
            }
        }

        private void EditPlayList(object sender, EventArgs e)
        {
            selectName = ltBxPlayList.SelectedItem.ToString();
            PlayListWF newList = new PlayListWF(ltBxPlayList, true);
            newList.Disposed += new EventHandler(this.EditEnd_Disposed);
            newList.ShowDialog();
        }

        private void ShowWait_Disposed(object sender, EventArgs e)
        {
            if (this.lbPlayListName.Text == selectName)
            {
                string fileName = ConstantParams.playListFilePath + "//" + selectName + ".properties";
                List<Music> musics = (List<Music>)ListHelper.readObjectFromFile(fileName);
                listBoxMusics.Items.Clear();
                for (int i = 0; i < musics.Count; i++)
                {
                    listBoxMusics.Items.Add(musics[i]);
                }
            }
        }

        private void ShowWait(object sender, EventArgs e)
        {
            selectName = ltBxPlayList.SelectedItem.ToString();
            PlayList pl = (PlayList)ltBxPlayList.SelectedItem;
            WaitWF wait = new WaitWF(ltBxPlayList);
            wait.Disposed += new EventHandler(this.ShowWait_Disposed);
            wait.ShowDialog();

        }
        private void UpMusic(object sender, EventArgs e)
        {
            int index = listBoxMusics.SelectedIndex;
            if(index == 0)
            {
                return;
            }
            Music m = (Music)listBoxMusics.SelectedItem;
            listBoxMusics.Items.Insert(index-1, m);
            listBoxMusics.Items.RemoveAt(index+1);
            listBoxMusics.SelectedIndex = index-1;
            ListHelper.WriteMusicItem(listBoxMusics, currentPlayList.serializableFile);
        }
        private void DownMusic(object sender, EventArgs e)
        {
            int count = listBoxMusics.Items.Count;
            int index = listBoxMusics.SelectedIndex;
            if(index == (count-1))
            {
                return;
            }
            Music m = (Music)listBoxMusics.SelectedItem;
            listBoxMusics.Items.Insert(index + 2, m);
            listBoxMusics.Items.RemoveAt(index);
            listBoxMusics.SelectedIndex = index + 1;
            ListHelper.WriteMusicItem(listBoxMusics, currentPlayList.serializableFile);
        }
        private void DelMusic(object sender, EventArgs e)
        {
            int i = listBoxMusics.SelectedIndex;
            Music m = (Music)listBoxMusics.Items[i];
            DialogResult dr = MessageBox.Show("是否确认移除<" + m.musicName + ">吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //用户选择确认的操作
                listBoxMusics.Items.Remove(listBoxMusics.Items[i]);
                ListHelper.WriteMusicItem(listBoxMusics, currentPlayList.serializableFile);
            }
            else if (dr == DialogResult.Cancel)
            {
                //用户选择取消的操作
            }
        }
        private void ShowLrcWindow_Disposed(object sender, EventArgs e)
        {
            isShowLrcWF = false;
        }
        private void ShowLrcWindow(object sender, EventArgs e)
        {
            if (isShowLrcWF == false)
            {
                isShowLrcWF = true;
                ShowLrcWF lrcwf = new ShowLrcWF();
                lrcwf.Disposed += new EventHandler(this.ShowLrcWindow_Disposed);
                lrcwf.Show();
                
            }
        }
        private void ShowWinMaxOrNor()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Image = global::MusicPlayer.Properties.Resources.max;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Image = global::MusicPlayer.Properties.Resources.maxMax;
            }
        }

        private void ShowWindow()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIconMusic.Visible = false;
        }

        private void CloseWindow()
        {
            this.notifyIconMusic.Visible = false;
            Application.Exit();
        }

        private void ShowWindow(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            ShowWinMaxOrNor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIconMusic.Visible = true;
            }
        }
        //允许面板1可以拖拽
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }
        //允许面板1可以拖拽
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }   
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        //播放进度条滚动按钮的位置
        private void SetPicRunPositon(int picLeft)
        {
            if (picLeft <= maxLeft && picLeft >= minLeft)
            {
                picRun.Left = picLeft;
            }
            if (picLeft > maxLeft)
            {
                picRun.Left = maxLeft;
            }
            if (picLeft < minLeft)
            {
                picRun.Left = minLeft;
            }
        }
        //播放进度条滚动按钮被拖动时的处理
        private void picRun_MouseDown(object sender, MouseEventArgs e)
        {
            moveFlag = true;//已经按下.
            xPos = e.X;
        }
        //播放进度条滚动按钮被拖动时的处理
        private void picRun_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveFlag)
            {
                int picLeft = picRun.Left;
                picLeft = picLeft + Convert.ToInt16(e.X - xPos);
                SetPicRunPositon(picLeft);
            }
        }
        //设置播放器播放时间
        private void SetPlayPosition()
        {
            if (winMdediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int moveDistance = picRun.Left - minLeft;
                double a = moveDistance;
                double b = propressWidth;
                double c = (double)moveDistance / propressWidth;
                double duration = winMdediaPlayer.currentMedia.duration;
                winMdediaPlayer.Ctlcontrols.currentPosition = duration * c;
            }
        }
        //播放进度条滚动按钮被拖动时的处理
        private void picRun_MouseUp(object sender, MouseEventArgs e)
        {
            moveFlag = false;
            SetPlayPosition();
        }
        //播放进度条被点击时的处理
        private void lbPropree_MouseClick(object sender, MouseEventArgs e)
        {
            int picLeft = e.X + minLeft;
            SetPicRunPositon(picLeft);
            SetPlayPosition();
        }
        //下一首按钮的tip
        private void btnRight_MouseHover(object sender, EventArgs e)
        {
            ControlHelper.ShowTip(btnRight, "下一首");
        }
        //上一首按钮的tips
        private void btnPre_MouseHover(object sender, EventArgs e)
        {
            ControlHelper.ShowTip(btnPre, "上一首");
        }
        //声音条发生改变时的处理
        private void trackBarSound_Scroll(object sender, EventArgs e)
        {
            StringHelper.Write(ConstantParams.playModelFile, trackBarSound.Value.ToString());
            if(!winMdediaPlayer.settings.mute)
            {
                winMdediaPlayer.settings.volume = trackBarSound.Value * 10;
            }
        }
        //根据传入的音乐文件名，该音乐是否已经在音乐类别里
        private Boolean IsContainMusic(string musicName)
        {
            Boolean flag = false;
            foreach (object obj in listBoxMusics.Items)
            {
                Music musicTmp = (Music)obj;
                string name = musicTmp.musicName;
                if (musicName == name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        //将音乐文件增加到音乐类别
        private Boolean AddMusicToList(string fileName)
        {
            Boolean flag = false;
            string musicName = System.IO.Path.GetFileName(fileName);
            string tmpStr = System.IO.Path.GetExtension(fileName);
            if (IsContainMusic(musicName))
            {
                return flag;
            }
            if (tmpStr == ".mp3" || tmpStr == ".wav")
            {
                Music music = new Music();
                music.musicFilePath = fileName;
                music.musicName = musicName;
                music.playListName = currentPlayList.playListName;
                listBoxMusics.Items.Add(music);
                flag = true;
            }
            return flag;
        }
        //将文件拖放到音乐列表时的处理
        private void listBoxMusics_DragDrop(object sender, DragEventArgs e)
        {
            Boolean flag = false; //是否成功添加了音乐文件
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
                foreach (String s in files)
                {
                    if (currentPlayList == null)
                    {
                        MessageBox.Show("请先选择播放列表");
                        return;
                    }
                    string fileName = s.ToString();
                    if(AddMusicToList(fileName))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    ListHelper.WriteMusicItem(listBoxMusics, currentPlayList.serializableFile);
                }
            }
        }
        //将文件拖放到音乐列表时的处理
        private void listBoxMusics_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //将文件拖放到音乐列表时的处理
        private void listBoxMusics_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All; 
        }
        //音乐列表item 双击时的处理
        private void listBoxMusics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int index = this.listBoxMusics.IndexFromPoint(e.Location);
            if(index < 0)
            {
                return;
            }
            currentMusic = (Music)listBoxMusics.Items[index];
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                StartPlay(currentMusic);
            }
        }
        //使用那个歌词文件
        private string WhichOneLrcFile(string sys, string custom)
        {
            if (lrcLevel == "0")
            {
                return sys;
            }
            else
            {
                return custom;
            }
        }
        //歌词文件优先那个处理
        private string LrcFileLeve()
        {
            string lrcFileName = System.IO.Path.GetFileNameWithoutExtension(currentMusic.musicFilePath);
            string sys = ConstantParams.lrcFilePath + "//" + lrcFileName + ".lrc";
            string custom = currentMusic.lrcFilePath;
            Boolean sysFlag = StringHelper.FileExists(sys);
            Boolean customFlag = StringHelper.FileExists(custom);
            if (sysFlag && customFlag)
            {
                return WhichOneLrcFile(sys, custom);
            }
            else if(!sysFlag && !customFlag)
            {
                return "";
            }
            else if (sysFlag && !customFlag)
            {
                return sys;
            }
            else 
            {
                return custom;
            }
        }
        //开始播放
        private void StartPlay(Music playMusic)
        {
            if (playMusic == null)
            {
                return;
            }
            string url = playMusic.musicFilePath;
            if (!StringHelper.FileExists(url))
            {
                //CheckModel();
                return;
            }
            currentMusic = playMusic;
            isRun = true;
            winMdediaPlayer.settings.volume = trackBarSound.Value * 10;
            winMdediaPlayer.URL = url;
            winMdediaPlayer.Ctlcontrols.play();

            string lrcFile = LrcFileLeve();
            if (StringHelper.FileExists(lrcFile))
            {
                InitLrc(lrcFile);
                ShowLrc();
            }
            else 
            {
                listBoxLrc.Items.Clear();
                this.lrcParser.Release();
                listBoxLrc.Items.Add("找不到匹配歌词");
            }
            StartTimer();
        }
        //启动定期
        private void StartTimer()
        {
            timerPlay.Enabled = true;
            timerPlay.Start();
        }
        //定时器  主要用于界面 与 windows media player 的同步 
        private void timerPlay_Tick(object sender, EventArgs e)
        {
            if (isRun)
            {
                double duration = winMdediaPlayer.currentMedia.duration;
                double currentPosition = winMdediaPlayer.Ctlcontrols.currentPosition;
                double scale = currentPosition / duration;
                double value = propressWidth * scale;
                double ps = minLeft + value;
                lbTotalTime.Text = winMdediaPlayer.currentMedia.durationString;
                string currentPositionString = winMdediaPlayer.Ctlcontrols.currentPositionString;
                if (currentPositionString == "")
                {
                    lbTime.Text = "00:00";
                }
                else
                {
                    lbTime.Text = currentPositionString;
                }
                picRun.Left = (int)ps;
                CheckLrcTime(currentPositionString, true);
            }
            else
            {
                timerPlay.Enabled = false;
                timerPlay.Stop();
                CheckModel();
            }
        }
        //获取当前正在播放歌曲所在音乐列表的index
        private int GetCurrentMusicIndex()
        {
            int index = -1;
            foreach (object obj in listBoxMusics.Items)
            {

                index = index + 1;
                Music musicTmp = (Music)obj;
                if (musicTmp.musicName == currentMusic.musicName)
                {
                    break;
                }
            }
            return index;
        }
        //获取音乐列表的数量
        private int GetMusicsCount()
        {
            int count = listBoxMusics.Items.Count;
            return count;
        }
        //检查播放时，播放器根据，播放模式来进行播放
        private void CheckModel()
        {
            if (listBoxMusics.Items.Count <= 0)
            {
                return;
            }
            int index = GetCurrentMusicIndex();
            if(index < 0)
            {
                return;
            }
            //判断播放列表是否发生了变化
            if (currentMusic.playListName != currentPlayList.playListName)
                index = -1;
            int count = GetMusicsCount();
            string model = comboBoxPlayModel.Text;
            if (model == "当前列表顺序播放")
            {
                if (index < count - 1)
                {
                    listBoxMusics.SelectedIndex = index + 1;
                    StartPlay((Music)listBoxMusics.SelectedItem);
                }
                return;
            }
            if (model == "当前列表循环播放")
            {
                if (index < count - 1)
                {
                    listBoxMusics.SelectedIndex = index + 1;
                }
                else
                {
                    listBoxMusics.SelectedIndex = 0;
                }
                StartPlay((Music)listBoxMusics.SelectedItem);
                return;

            }
            if (model == "选中歌曲单次播放")
            {
                return;
            }
            if (model == "选中歌曲循环播放")
            {
                StartPlay(currentMusic);
            }
        }
        //新建播放列表
        private void btnNewList_Click(object sender, EventArgs e)
        {
            PlayListWF newList = new PlayListWF(ltBxPlayList);
            newList.ShowDialog();
        }
        //双击播放列表 item 时的动作处理
        private void ltBxPlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //更新音乐列表
            int index = ltBxPlayList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                currentPlayList = (PlayList)ltBxPlayList.SelectedItem;
                //更新musiclistbox
                string fileName = currentPlayList.serializableFile;
                List<Music> musics = (List<Music>)ListHelper.readObjectFromFile(fileName);
                listBoxMusics.Items.Clear();
                for (int i = 0; i < musics.Count; i++)
                {
                    listBoxMusics.Items.Add(musics[i]);
                }
                lbPlayListName.Text = currentPlayList.playListName;
            }
        }
        //播放列表 选择项 鼠标右击 展示菜单
        private void ltBxPlayList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posindex = ltBxPlayList.IndexFromPoint(new Point(e.X, e.Y));
                ltBxPlayList.ContextMenuStrip = null;
                if (posindex >= 0 && posindex < ltBxPlayList.Items.Count)
                {
                    ltBxPlayList.SelectedIndex = posindex;
                    contextMenuPlayList.Show(ltBxPlayList, new Point(e.X, e.Y));
                }
            }
            lbPlayListName.Refresh();
        }
        //音乐列表 选择项 鼠标右击 展示菜单
        private void listBoxMusics_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posindex = listBoxMusics.IndexFromPoint(new Point(e.X, e.Y));
                listBoxMusics.ContextMenuStrip = null;
                if (posindex >= 0 && posindex < listBoxMusics.Items.Count)
                {
                    listBoxMusics.SelectedIndex = posindex;
                    contextMenuMusic.Show(listBoxMusics, new Point(e.X, e.Y));
                }
            }
            listBoxMusics.Refresh();
        }
        //播放器播放状态发生改变的处理
        private void winMdediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (winMdediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                isRun = false;
                labelMusicName.Text = "";
                listBoxLrc.Items.Clear();
                lrcParser.Release();
            }
            if (winMdediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string fileName = System.IO.Path.GetFileName(winMdediaPlayer.URL);
                labelMusicName.Text = "正在播放歌曲：" + fileName;
            }
        }
        //暂时没有用到
        private void SetItemInfoToListBox()
        {
            /*
            listBox3.Items.Clear();
            listBox3.Items.Add("媒体标题 = " + winMdediaPlayer.currentMedia.getItemInfo("Title"));
            listBox3.Items.Add("艺术家 = " + winMdediaPlayer.currentMedia.getItemInfo("Author"));
            listBox3.Items.Add("版权信息 = " + winMdediaPlayer.currentMedia.getItemInfo("Copyright"));
            listBox3.Items.Add("媒体内容描述 = " + winMdediaPlayer.currentMedia.getItemInfo("Description"));
            listBox3.Items.Add("持续时间（秒） = " + winMdediaPlayer.currentMedia.getItemInfo("Duration"));
            listBox3.Items.Add("文件大小 = " + winMdediaPlayer.currentMedia.getItemInfo("FileSize"));
            listBox3.Items.Add("文件类型 = " + winMdediaPlayer.currentMedia.getItemInfo("FileType"));
            listBox3.Items.Add("原始地址 = " + winMdediaPlayer.currentMedia.getItemInfo("sourceURL"));*/

        }
        //点击上一曲按钮时的处理
        private void btnPre_Click(object sender, EventArgs e)
        {
            if(listBoxMusics.Items.Count <= 0 )
            {
                return;
            }
            int index = GetCurrentMusicIndex();
            int count = GetMusicsCount();
            index = index - 1;
            if (currentMusic.playListName != currentPlayList.playListName)
            {
                index = 0;
            }
            if (index >= 0)
            {
                listBoxMusics.SelectedIndex = index;
                StartPlay((Music)listBoxMusics.SelectedItem);
            }
        }
        //双击电脑右下角图标的处理
        private void notifyIconMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }
        //开始暂停按钮的处理
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (winMdediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Image = global::MusicPlayer.Properties.Resources.stop;
                winMdediaPlayer.Ctlcontrols.pause();
                return;
            }
            if (winMdediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                btnPlay.Image = global::MusicPlayer.Properties.Resources.play;
                winMdediaPlayer.Ctlcontrols.play();
                return;
            }
        }
        //禁音乐按钮的处理
        private void btnSound_Click(object sender, EventArgs e)
        {
            string state = btnSound.Text;
            if (state == "")
            {
                btnSound.Text = "×";
                winMdediaPlayer.settings.mute = true;
            }
            else
            {
                btnSound.Text = "";
                winMdediaPlayer.settings.mute = false;
                winMdediaPlayer.settings.volume = this.trackBarSound.Value*10;
            }
        }
        //下一曲按钮的处理
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (listBoxMusics.Items.Count <= 0)
            {
                return;
            }
            int index = GetCurrentMusicIndex();
            int count = GetMusicsCount();
            index = index + 1;
            if(currentMusic.playListName != currentPlayList.playListName)
            {
                index = 0;
            }
            if (index < count)
            {
                listBoxMusics.SelectedIndex = index;
                StartPlay((Music)listBoxMusics.SelectedItem);
            }
        }
        //播放模式改变时的处理
        private void comboBoxPlayModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StringHelper.Write(ConstantParams.playModelFile, comboBoxPlayModel.SelectedIndex.ToString());
        }
        //按下导入歌曲按钮，程序处理
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPlayList == null)
            {
                MessageBox.Show("请先选择播放列表");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*|mp3 files (*.mp3;*.wav)|*.mp3;*.wav";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            Boolean flag = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                for(int i=0; i<fileNames.Length; i++)
                {
                    Console.WriteLine(fileNames[i]);
                    if(AddMusicToList(fileNames[i]))
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    ListHelper.WriteMusicItem(listBoxMusics, currentPlayList.serializableFile);
                }
            }
        }
        //设置按钮点击处理
        private void btnSet_Click(object sender, EventArgs e)
        {
            SetWF setWf = new SetWF();
            setWf.Show();
        }
        //初始化歌次
        private void InitLrc(string fileName)
        {
            lrcParser.Release();
            lrcParser.Initialize(fileName);
        }
        //根据当前歌曲的时间，获取list的位置,isSelectIndex==true设置SelectedIndex
        private int CheckLrcTime(string time, Boolean isSelectIndex=false)
        {
            List<LyricEntry> ly = lrcParser.m_Lyrics;
            int count = ly.Count;
            for (int i = 0; i < count; i++)
            {
                if (time == ly[i].time)
                {
                    if (isSelectIndex)
                    {
                        listBoxLrc.SelectedIndex = i;
                    }
                    return i;
                }
            }
            return -1;
        }
        //歌词添加到歌词展示列表
        private void ShowLrc()
        {
            int count = lrcParser.m_Lyrics.Count;
            if (count > 0)
            {
                List<LyricEntry> ly = lrcParser.m_Lyrics;
                listBoxLrc.Items.Clear();
                for (int i = 0; i < count; i++)
                {
                    listBoxLrc.Items.Add(ly[i].lyric);
                }
            }
        }
        //歌词向上走 暂时没有使用
        private void ShowLrc(int index)
        {
            if (index < 0)
                return;
            int h = listBoxLrc.Height;
            int maxCount = h / 15;
            int count = lrcParser.m_Lyrics.Count;
            if (count > 0)
            {
                List<LyricEntry> ly = lrcParser.m_Lyrics;
                listBoxLrc.Items.Clear();
                maxCount = maxCount + index - 1;
                for (int i = index; i < count; i++)
                {
                    if (i > maxCount)
                    {
                        break;
                    }
                    listBoxLrc.Items.Add(ly[i].lyric);
                }
                listBoxLrc.SelectedIndex = 0;
            }
        }

    }
}
