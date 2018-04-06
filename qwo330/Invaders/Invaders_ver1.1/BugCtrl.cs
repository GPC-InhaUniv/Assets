﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    class BugCtrl : PictureBox
    {
        private Timer animationTimer = new Timer();
        
        public BugCtrl()
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
            switch(cell)
            {
                case 1: BackgroundImage = Properties.Resources.bug1; break;
                case 2: BackgroundImage = Properties.Resources.bug2; break;
                case 3: BackgroundImage = Properties.Resources.bug3; break;
                case 4: BackgroundImage = Properties.Resources.bug4; break;
                case 5: BackgroundImage = Properties.Resources.bug3; break;
                default: BackgroundImage = Properties.Resources.bug2;
                    cell = 0; break;
            }
        }
    }
}
