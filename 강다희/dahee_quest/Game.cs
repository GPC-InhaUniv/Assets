using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dahee_quest
{
    public class Game
    {
        public List<Enemy> Enemies;

        private Player player;
        public Point PlayerLocation {  get { return player.Location; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void Move (Mover.Direction playerDirection)
        {
            player.Move(playerDirection);
        }
    }
}