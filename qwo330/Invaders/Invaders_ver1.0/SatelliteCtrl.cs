using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    class SatelliteCtrl : PictureBox
    {
        private Timer animationTimer = new Timer();

        public SatelliteCtrl()
        {
            animationTimer.Tick += new EventHandler(animationTimer_Tick);
            animationTimer.Interval = 150;
            animationTimer.Start();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private int cell = 0;
        void animationTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1: BackgroundImage = Properties.Resources.satellite1; break;
                case 2: BackgroundImage = Properties.Resources.satellite2; break;
                case 3: BackgroundImage = Properties.Resources.satellite3; break;
                case 4: BackgroundImage = Properties.Resources.satellite4; break;
                case 5: BackgroundImage = Properties.Resources.satellite3; break;
                default:
                    BackgroundImage = Properties.Resources.satellite2;
                    cell = 0; break;
            }
        }
    }
}
