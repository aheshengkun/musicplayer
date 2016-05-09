namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.labelMusicName = new System.Windows.Forms.Label();
            this.winMdediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayListName = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.picRun = new System.Windows.Forms.PictureBox();
            this.trackBarSound = new System.Windows.Forms.TrackBar();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.listBoxMusics = new System.Windows.Forms.ListBox();
            this.lbPropree = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.comboBoxPlayModel = new System.Windows.Forms.ComboBox();
            this.ltBxPlayList = new System.Windows.Forms.ListBox();
            this.listBoxLrc = new System.Windows.Forms.ListBox();
            this.contextMenuLrc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemShowLrc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.notifyIconMusic = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.contextMenuPlayList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemEditPlayList = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelPlayList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMusic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDown = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winMdediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuLrc.SuspendLayout();
            this.notifyContextMenu.SuspendLayout();
            this.contextMenuPlayList.SuspendLayout();
            this.contextMenuMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnMix);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.labelMusicName);
            this.panel1.Controls.Add(this.winMdediaPlayer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 520);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSet.Image = global::MusicPlayer.Properties.Resources.set;
            this.btnSet.Location = new System.Drawing.Point(437, 0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(40, 40);
            this.btnSet.TabIndex = 7;
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // labelMusicName
            // 
            this.labelMusicName.AutoSize = true;
            this.labelMusicName.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMusicName.Location = new System.Drawing.Point(43, 15);
            this.labelMusicName.Name = "labelMusicName";
            this.labelMusicName.Size = new System.Drawing.Size(0, 12);
            this.labelMusicName.TabIndex = 6;
            // 
            // winMdediaPlayer
            // 
            this.winMdediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winMdediaPlayer.Enabled = true;
            this.winMdediaPlayer.Location = new System.Drawing.Point(307, 8);
            this.winMdediaPlayer.Name = "winMdediaPlayer";
            this.winMdediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMdediaPlayer.OcxState")));
            this.winMdediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.winMdediaPlayer.TabIndex = 5;
            this.winMdediaPlayer.Visible = false;
            this.winMdediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.winMdediaPlayer_PlayStateChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.music;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbPlayListName);
            this.splitContainer1.Panel1.Controls.Add(this.lbTotalTime);
            this.splitContainer1.Panel1.Controls.Add(this.lbTime);
            this.splitContainer1.Panel1.Controls.Add(this.picRun);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarSound);
            this.splitContainer1.Panel1.Controls.Add(this.btnSound);
            this.splitContainer1.Panel1.Controls.Add(this.btnRight);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlay);
            this.splitContainer1.Panel1.Controls.Add(this.btnPre);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxMusics);
            this.splitContainer1.Panel1.Controls.Add(this.lbPropree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(600, 478);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "播放列表：";
            // 
            // lbPlayListName
            // 
            this.lbPlayListName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPlayListName.AutoSize = true;
            this.lbPlayListName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbPlayListName.Location = new System.Drawing.Point(68, 460);
            this.lbPlayListName.Name = "lbPlayListName";
            this.lbPlayListName.Size = new System.Drawing.Size(0, 12);
            this.lbPlayListName.TabIndex = 10;
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Location = new System.Drawing.Point(262, 16);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(35, 12);
            this.lbTotalTime.TabIndex = 9;
            this.lbTotalTime.Text = "00:00";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(6, 15);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(35, 12);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "00:00";
            // 
            // picRun
            // 
            this.picRun.BackgroundImage = global::MusicPlayer.Properties.Resources.picRun;
            this.picRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picRun.Location = new System.Drawing.Point(49, 17);
            this.picRun.Name = "picRun";
            this.picRun.Size = new System.Drawing.Size(17, 9);
            this.picRun.TabIndex = 6;
            this.picRun.TabStop = false;
            this.picRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRun_MouseDown);
            this.picRun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRun_MouseMove);
            this.picRun.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picRun_MouseUp);
            // 
            // trackBarSound
            // 
            this.trackBarSound.Location = new System.Drawing.Point(193, 47);
            this.trackBarSound.Name = "trackBarSound";
            this.trackBarSound.Size = new System.Drawing.Size(104, 45);
            this.trackBarSound.TabIndex = 5;
            this.trackBarSound.Scroll += new System.EventHandler(this.trackBarSound_Scroll);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSound.ForeColor = System.Drawing.Color.Red;
            this.btnSound.Image = global::MusicPlayer.Properties.Resources.sound;
            this.btnSound.Location = new System.Drawing.Point(147, 37);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(40, 40);
            this.btnSound.TabIndex = 4;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRight.Image = global::MusicPlayer.Properties.Resources.right;
            this.btnRight.Location = new System.Drawing.Point(95, 37);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 40);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseHover += new System.EventHandler(this.btnRight_MouseHover);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Image = global::MusicPlayer.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(51, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Transparent;
            this.btnPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPre.Image = global::MusicPlayer.Properties.Resources.left;
            this.btnPre.Location = new System.Drawing.Point(3, 37);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(40, 40);
            this.btnPre.TabIndex = 4;
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            this.btnPre.MouseHover += new System.EventHandler(this.btnPre_MouseHover);
            // 
            // listBoxMusics
            // 
            this.listBoxMusics.AllowDrop = true;
            this.listBoxMusics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMusics.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxMusics.FormattingEnabled = true;
            this.listBoxMusics.ItemHeight = 15;
            this.listBoxMusics.Location = new System.Drawing.Point(3, 92);
            this.listBoxMusics.Name = "listBoxMusics";
            this.listBoxMusics.Size = new System.Drawing.Size(294, 364);
            this.listBoxMusics.TabIndex = 0;
            this.listBoxMusics.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxMusics_DragDrop);
            this.listBoxMusics.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxMusics_DragEnter);
            this.listBoxMusics.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxMusics_DragOver);
            this.listBoxMusics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMusics_MouseDoubleClick);
            this.listBoxMusics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxMusics_MouseUp);
            // 
            // lbPropree
            // 
            this.lbPropree.BackColor = System.Drawing.Color.White;
            this.lbPropree.Location = new System.Drawing.Point(50, 17);
            this.lbPropree.Name = "lbPropree";
            this.lbPropree.Size = new System.Drawing.Size(198, 9);
            this.lbPropree.TabIndex = 7;
            this.lbPropree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPropree_MouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnNewList);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxPlayModel);
            this.splitContainer2.Panel1.Controls.Add(this.ltBxPlayList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxLrc);
            this.splitContainer2.Size = new System.Drawing.Size(290, 472);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "导入歌曲";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Location = new System.Drawing.Point(130, 10);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(75, 23);
            this.btnNewList.TabIndex = 2;
            this.btnNewList.Text = "新建列表";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // comboBoxPlayModel
            // 
            this.comboBoxPlayModel.FormattingEnabled = true;
            this.comboBoxPlayModel.Items.AddRange(new object[] {
            "当前列表顺序播放",
            "当前列表循环播放",
            "选中歌曲单次播放",
            "选中歌曲循环播放"});
            this.comboBoxPlayModel.Location = new System.Drawing.Point(2, 11);
            this.comboBoxPlayModel.Name = "comboBoxPlayModel";
            this.comboBoxPlayModel.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlayModel.TabIndex = 1;
            this.comboBoxPlayModel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPlayModel_SelectionChangeCommitted);
            // 
            // ltBxPlayList
            // 
            this.ltBxPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltBxPlayList.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ltBxPlayList.FormattingEnabled = true;
            this.ltBxPlayList.ItemHeight = 15;
            this.ltBxPlayList.Location = new System.Drawing.Point(0, 44);
            this.ltBxPlayList.Name = "ltBxPlayList";
            this.ltBxPlayList.Size = new System.Drawing.Size(290, 184);
            this.ltBxPlayList.TabIndex = 0;
            this.ltBxPlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltBxPlayList_MouseDoubleClick);
            this.ltBxPlayList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ltBxPlayList_MouseUp);
            // 
            // listBoxLrc
            // 
            this.listBoxLrc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLrc.ContextMenuStrip = this.contextMenuLrc;
            this.listBoxLrc.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxLrc.FormattingEnabled = true;
            this.listBoxLrc.ItemHeight = 15;
            this.listBoxLrc.Location = new System.Drawing.Point(0, 4);
            this.listBoxLrc.Name = "listBoxLrc";
            this.listBoxLrc.Size = new System.Drawing.Size(290, 244);
            this.listBoxLrc.TabIndex = 0;
            // 
            // contextMenuLrc
            // 
            this.contextMenuLrc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShowLrc});
            this.contextMenuLrc.Name = "contextMenuLrc";
            this.contextMenuLrc.Size = new System.Drawing.Size(125, 26);
            this.contextMenuLrc.Text = "显示歌词";
            // 
            // itemShowLrc
            // 
            this.itemShowLrc.Name = "itemShowLrc";
            this.itemShowLrc.Size = new System.Drawing.Size(124, 22);
            this.itemShowLrc.Text = "显示歌词";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = global::MusicPlayer.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(560, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMax.Image = global::MusicPlayer.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(519, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 40);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMix
            // 
            this.btnMix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMix.BackColor = System.Drawing.Color.Transparent;
            this.btnMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMix.FlatAppearance.BorderSize = 0;
            this.btnMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMix.Image = global::MusicPlayer.Properties.Resources.mix;
            this.btnMix.Location = new System.Drawing.Point(477, 0);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(40, 40);
            this.btnMix.TabIndex = 0;
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // notifyIconMusic
            // 
            this.notifyIconMusic.ContextMenuStrip = this.notifyContextMenu;
            this.notifyIconMusic.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMusic.Icon")));
            this.notifyIconMusic.Text = "MusicPlayer";
            this.notifyIconMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMusic_MouseDoubleClick);
            // 
            // notifyContextMenu
            // 
            this.notifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShow,
            this.menuItemExit});
            this.notifyContextMenu.Name = "notifyContextMenu";
            this.notifyContextMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // menuItemShow
            // 
            this.menuItemShow.Name = "menuItemShow";
            this.menuItemShow.Size = new System.Drawing.Size(100, 22);
            this.menuItemShow.Text = "显示";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(100, 22);
            this.menuItemExit.Text = "退出";
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 500;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // contextMenuPlayList
            // 
            this.contextMenuPlayList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEditPlayList,
            this.itemDelPlayList,
            this.toolStripSeparator1,
            this.itemClear});
            this.contextMenuPlayList.Name = "contextMenuPlayList";
            this.contextMenuPlayList.Size = new System.Drawing.Size(149, 76);
            // 
            // itemEditPlayList
            // 
            this.itemEditPlayList.Name = "itemEditPlayList";
            this.itemEditPlayList.Size = new System.Drawing.Size(148, 22);
            this.itemEditPlayList.Text = "编辑";
            // 
            // itemDelPlayList
            // 
            this.itemDelPlayList.Name = "itemDelPlayList";
            this.itemDelPlayList.Size = new System.Drawing.Size(148, 22);
            this.itemDelPlayList.Text = "删除";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // itemClear
            // 
            this.itemClear.Name = "itemClear";
            this.itemClear.Size = new System.Drawing.Size(148, 22);
            this.itemClear.Text = "清除无效歌曲";
            // 
            // contextMenuMusic
            // 
            this.contextMenuMusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemUp,
            this.itemDown,
            this.itemDelMusic});
            this.contextMenuMusic.Name = "contextMenuMusic";
            this.contextMenuMusic.Size = new System.Drawing.Size(149, 70);
            // 
            // itemUp
            // 
            this.itemUp.Name = "itemUp";
            this.itemUp.Size = new System.Drawing.Size(148, 22);
            this.itemUp.Text = "上移选中歌曲";
            // 
            // itemDown
            // 
            this.itemDown.Name = "itemDown";
            this.itemDown.Size = new System.Drawing.Size(148, 22);
            this.itemDown.Text = "下移选中歌曲";
            // 
            // itemDelMusic
            // 
            this.itemDelMusic.Name = "itemDelMusic";
            this.itemDelMusic.Size = new System.Drawing.Size(148, 22);
            this.itemDelMusic.Text = "移除选中歌曲";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winMdediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSound)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuLrc.ResumeLayout(false);
            this.notifyContextMenu.ResumeLayout(false);
            this.contextMenuPlayList.ResumeLayout(false);
            this.contextMenuMusic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.ListBox listBoxMusics;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.TrackBar trackBarSound;
        private System.Windows.Forms.PictureBox picRun;
        private System.Windows.Forms.Label lbPropree;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ltBxPlayList;
        private System.Windows.Forms.NotifyIcon notifyIconMusic;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemShow;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer winMdediaPlayer;
        private System.Windows.Forms.Label lbPlayListName;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.ComboBox comboBoxPlayModel;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.ContextMenuStrip contextMenuPlayList;
        private System.Windows.Forms.ToolStripMenuItem itemDelPlayList;
        private System.Windows.Forms.ToolStripMenuItem itemEditPlayList;
        private System.Windows.Forms.ContextMenuStrip contextMenuMusic;
        private System.Windows.Forms.ToolStripMenuItem itemDelMusic;
        private System.Windows.Forms.Label labelMusicName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemClear;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ListBox listBoxLrc;
        private System.Windows.Forms.ToolStripMenuItem itemUp;
        private System.Windows.Forms.ToolStripMenuItem itemDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuLrc;
        private System.Windows.Forms.ToolStripMenuItem itemShowLrc;
    }
}

