using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Invader2
{
    class CommandShip
    {
        private const int HorizontalInterval = 50;
        private Point location;
        public Point Location { get { return location; } }
        public Rectangle Area;
        private Game game;
        private int score;
        public int Score { get { return score; } }
        public CommandShip(Game game)
        {
            this.game = game;
            score = 250;
            location = new Point(0, 0);
            Area = new Rectangle(location, game.ImageStorage.BossImage(0).Size);
        }

        public void Draw(Graphics g, int animationCell)
        {
            g.DrawImage(game.ImageStorage.BossImage(animationCell), location);
        }

        public void Move()
        {
            this.location.X += HorizontalInterval;
            Area.Location = location;
        }
    }
}
