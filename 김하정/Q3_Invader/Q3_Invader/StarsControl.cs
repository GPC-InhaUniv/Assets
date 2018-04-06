using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3_Invader
{
    class StarsControl : PictureBox
    {
        private Timer animationTimer = new Timer();
        public StarsControl()
        {
            animationTimer.Tick += new EventHandler(animationTimer_Tick);
            animationTimer.Interval = 33;
            animationTimer.Start();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        private int cell = 0;
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    {
                         
                        BackgroundImage = Properties.Resources.star1;

                    }
                    break;
                case 2:
                    {
                         
                        BackgroundImage = Properties.Resources.star2;

                    }
                    break;
                case 3:
                    {
                         
                        BackgroundImage = Properties.Resources.star3;
                    }
                    break;
                case 4:
                    {
                         
                        BackgroundImage = Properties.Resources.star4;
                    }
                    break;
                default:
                    {
                        
                        BackgroundImage = Properties.Resources.star1;

                    }
                    cell = 0; break;

            }
        }

    }
}
