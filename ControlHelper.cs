using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    class ControlHelper
    {
        public static void ShowTip(Control control, string caption)
        {
            ToolTip ttpSettings = new ToolTip();
            ttpSettings.InitialDelay = 500;
            ttpSettings.AutoPopDelay = 5 * 1000;
            ttpSettings.ReshowDelay = 200;
            ttpSettings.ShowAlways = true;
            ttpSettings.IsBalloon = true;
            ttpSettings.SetToolTip(control, caption);
        }
    }
}
