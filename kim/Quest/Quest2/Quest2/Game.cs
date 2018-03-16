using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Game
    {

        private Player Player;

        public List<Enemy> Enemies;


        public Point PlayerLocation { get { return Player.Location; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game (Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 10));
        }

        public void Move(Direction direction,Random random)
        {
           
            Player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
            
        }


        // --------- Level -------------

        private int level = 0;
        public int Level { get { return level; } }

        public void NewLevel()
        {
            level++;
            switch(level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, new Point(300, 76)));

                    break;
            }
        }

    }
}
