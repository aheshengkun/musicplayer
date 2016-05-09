using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SetWF : Form
    {
        public SetWF()
        {
            InitializeComponent();
            InitLrcLevel();
            groupBoxLrc.Visible = true;
            groupBoxAbout.Visible = false;
            textBoxDir.Text = System.Windows.Forms.Application.StartupPath + "\\" + ConstantParams.lrcFilePath;
        }

        private void InitLrcLevel()
        {
            string fileName = ConstantParams.lrcLevel;
            string flag = StringHelper.readFileAllText(fileName);
            if(flag == "1")
            {
                radioCustomDir.Checked = true;
            }
            else
            {
                radioSysDir.Checked = true;
            }
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            this.itemAbout.BackColor = System.Drawing.SystemColors.Highlight;
            this.itemLrc.BackColor = System.Drawing.Color.DeepSkyBlue;
            groupBoxLrc.Visible = false;
            groupBoxAbout.Visible = true;
        }

        private void itemLrc_Click(object sender, EventArgs e)
        {
            this.itemAbout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.itemLrc.BackColor = System.Drawing.SystemColors.Highlight;
            groupBoxLrc.Visible = true;
            groupBoxAbout.Visible = false;
        }

        private void radioSysDir_CheckedChanged(object sender, EventArgs e)
        {
            StringHelper.Write(ConstantParams.lrcLevel, "0");
        }

        private void radioCustomDir_CheckedChanged(object sender, EventArgs e)
        {
            StringHelper.Write(ConstantParams.lrcLevel, "1");
        }
    }
}
