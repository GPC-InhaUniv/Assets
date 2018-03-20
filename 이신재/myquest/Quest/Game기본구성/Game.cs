using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
//using System.Diagnostics.Debug.WriteLine("테스트값: " text); //디버그를 다 해주는 것이 좋다. 조사식도그렇고 ..... 

namespace Quest

{
   
    class Game
    {
        public List<Monster> Monsters;
        public Item ItemInRoom; //생성되는 아이템?
        
        private Player player;
       
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerItems { get { return player.Items; } }
        

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries; //경계선
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(enumDirection direction, Random random)
        {
            player.Move(direction);
           
        }

        public void Equip(string ItemName)
        {
            player.Equip(ItemName);
        }
        
        public bool CheckPlayerInventory(string ItemName)
        {
            return player.Items.Contains(ItemName);
        }

      


        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(enumDirection direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Monster monster in Monsters) //Monsters 에 Null걸림
            {
                if (!monster.Dead)
                monster.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left +
                random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top +
                random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch(level)
            {
                case 1:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Teemo(this, GetRandomLocation(random)));
                    ItemInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    
                    Monsters = new List<Monster>();
                    Monsters.Add(new Yasuo(this, GetRandomLocation(random)));
                    ItemInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Masterei(this, GetRandomLocation(random)));
                    Monsters.Add(new Yasuo(this, GetRandomLocation(random)));
                    ItemInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Teemo(this, GetRandomLocation(random)));
                    Monsters.Add(new Yasuo(this, GetRandomLocation(random)));
                    
                    ItemInRoom = new Bow(this, GetRandomLocation(random)); //bow이거나 blue potion이거나 ..... 수정
                    break;
                case 5:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Teemo(this, GetRandomLocation(random)));
                    Monsters.Add(new Masterei(this, GetRandomLocation(random)));
                    ItemInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Yasuo(this, GetRandomLocation(random)));
                    Monsters.Add(new Masterei(this, GetRandomLocation(random)));
                    ItemInRoom = new Axe(this, GetRandomLocation(random));
                    break;
                case 7:
                    Monsters = new List<Monster>();
                    Monsters.Add(new Teemo(this, GetRandomLocation(random)));
                    Monsters.Add(new Yasuo(this, GetRandomLocation(random)));
                    Monsters.Add(new Masterei(this, GetRandomLocation(random)));
                    ItemInRoom = new RedPotion(this, GetRandomLocation(random)); //메이스를 줍지 않은 경우
                    break;

                default:
                    Application.Exit();
                    break;
                    
            }
        }
    }
}
