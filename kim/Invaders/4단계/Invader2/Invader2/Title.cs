using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Invader2
{
    class Title
    {
       public void Draw(Graphics g)
       {
            g.DrawImage(Properties.Resources.sie_logo, new Point(50, 0));
            using (Font Start = new Font("Arial", 20, FontStyle.Bold))
            {
                g.DrawString("Press 'Enter' to start the game", Start, Brushes.Ivory, 350, 500);
            }
        }
    }
}
