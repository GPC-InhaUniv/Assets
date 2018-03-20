using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    public class GameView
    {
        private Player player;
        public List<Enemy> Enemies;
        public Item ItemInRoom;

        public Point PlayerLocation
        {
            get { return player.Location; }
        }
        
        public List<string> PlayerItems
        {
            get { return player.Items; }
        }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries
        {
            get { return boundaries; }
        }

        public GameView(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction, boundaries);
        }

        public void Use(Direction direction, Random random)
        {
            player.Use(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, boundaries.Top
                + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }
        
        public void NewLevel(Random random)
        {
            level++;

            switch (level)
            {/*
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    ItemInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    ItemInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    ItemInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                    
                case 4:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random))
                    };
                    if (equippedItem != Bow)
                        ItemInRoom = new Bow(this, GetRandomLocation(random));
                    else
                        ItemInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;       
                */
                default:
                    Application.Exit();
                    break;
            }
        }

    }
}
