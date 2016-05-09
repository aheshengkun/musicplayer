namespace MusicPlayer
{
    partial class SetWF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemLrc = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLrc = new System.Windows.Forms.GroupBox();
            this.radioCustomDir = new System.Windows.Forms.RadioButton();
            this.radioSysDir = new System.Windows.Forms.RadioButton();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAbout = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxLrc.SuspendLayout();
            this.groupBoxAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLrc,
            this.itemAbout});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(-5, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(106, 83);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemLrc
            // 
            this.itemLrc.BackColor = System.Drawing.SystemColors.Highlight;
            this.itemLrc.Checked = true;
            this.itemLrc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemLrc.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemLrc.ForeColor = System.Drawing.SystemColors.Info;
            this.itemLrc.Name = "itemLrc";
            this.itemLrc.Size = new System.Drawing.Size(99, 29);
            this.itemLrc.Text = "歌词路径";
            this.itemLrc.Click += new System.EventHandler(this.itemLrc_Click);
            // 
            // itemAbout
            // 
            this.itemAbout.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemAbout.ForeColor = System.Drawing.SystemColors.Info;
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(99, 29);
            this.itemAbout.Text = "关于";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // groupBoxLrc
            // 
            this.groupBoxLrc.Controls.Add(this.radioCustomDir);
            this.groupBoxLrc.Controls.Add(this.radioSysDir);
            this.groupBoxLrc.Controls.Add(this.textBoxDir);
            this.groupBoxLrc.Controls.Add(this.label1);
            this.groupBoxLrc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxLrc.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxLrc.Location = new System.Drawing.Point(119, 21);
            this.groupBoxLrc.Name = "groupBoxLrc";
            this.groupBoxLrc.Size = new System.Drawing.Size(330, 229);
            this.groupBoxLrc.TabIndex = 1;
            this.groupBoxLrc.TabStop = false;
            this.groupBoxLrc.Text = "路径设置";
            // 
            // radioCustomDir
            // 
            this.radioCustomDir.AutoSize = true;
            this.radioCustomDir.Location = new System.Drawing.Point(16, 166);
            this.radioCustomDir.Name = "radioCustomDir";
            this.radioCustomDir.Size = new System.Drawing.Size(186, 20);
            this.radioCustomDir.TabIndex = 6;
            this.radioCustomDir.TabStop = true;
            this.radioCustomDir.Text = "优先使用用户歌词路径";
            this.radioCustomDir.UseVisualStyleBackColor = true;
            this.radioCustomDir.CheckedChanged += new System.EventHandler(this.radioCustomDir_CheckedChanged);
            // 
            // radioSysDir
            // 
            this.radioSysDir.AutoSize = true;
            this.radioSysDir.Location = new System.Drawing.Point(16, 124);
            this.radioSysDir.Name = "radioSysDir";
            this.radioSysDir.Size = new System.Drawing.Size(186, 20);
            this.radioSysDir.TabIndex = 5;
            this.radioSysDir.TabStop = true;
            this.radioSysDir.Text = "优先使用系统歌词路径";
            this.radioSysDir.UseVisualStyleBackColor = true;
            this.radioSysDir.CheckedChanged += new System.EventHandler(this.radioSysDir_CheckedChanged);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(10, 65);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.ReadOnly = true;
            this.textBoxDir.Size = new System.Drawing.Size(305, 26);
            this.textBoxDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统歌词路径";
            // 
            // groupBoxAbout
            // 
            this.groupBoxAbout.Controls.Add(this.label3);
            this.groupBoxAbout.Controls.Add(this.textBox2);
            this.groupBoxAbout.Controls.Add(this.label2);
            this.groupBoxAbout.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxAbout.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxAbout.Location = new System.Drawing.Point(119, 21);
            this.groupBoxAbout.Name = "groupBoxAbout";
            this.groupBoxAbout.Size = new System.Drawing.Size(330, 229);
            this.groupBoxAbout.TabIndex = 2;
            this.groupBoxAbout.TabStop = false;
            this.groupBoxAbout.Text = "音乐播放器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "QQ：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(87, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "642973281";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "作者：何胜坤";
            // 
            // SetWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxLrc);
            this.Controls.Add(this.groupBoxAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxLrc.ResumeLayout(false);
            this.groupBoxLrc.PerformLayout();
            this.groupBoxAbout.ResumeLayout(false);
            this.groupBoxAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemLrc;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.GroupBox groupBoxLrc;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCustomDir;
        private System.Windows.Forms.RadioButton radioSysDir;
        private System.Windows.Forms.GroupBox groupBoxAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}