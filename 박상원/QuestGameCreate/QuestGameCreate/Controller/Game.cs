using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Controller
{
    class Game
    {
        //-------------------------------Game 클래스의 기본 요소-----------------------------
        public List<Model.Enemy> Enemies; // 맵 상에 몬스터
        public Model.Weapon weaponInRoom; // 맵 상에 아이템

        private Model.Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHP { get { return player.HP; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries; // Rectangle 객체에는 Top,Bottom,Left,Right 필드가 있습니다.
        public Rectangle Boundaries { get { return boundaries; } }

        //-------------------------------Game 클래스의 기본 요소-----------------------------

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            // 던전에 대한 바운딩 박스를 매개변수로 받고 던전 내부에 있는 player 객체 생성
            player = new Model.Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Util.Mover.Direction direction,Random random)
        {
            player.Move(direction);
            foreach (Model.Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void PlayerDamege(int maxDamege,Random random)
        {
            player.PlayerDamege(maxDamege, random);
        }

        public void HealingPlayer(int health,Random random)
        {
            player.HealingPotion(health, random);
        }

        public void Attack(Model.Player.Direction direction,Random random)
        {
            player.Attack(direction, random);
            foreach (Model.Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random randomLocation)
        {
            return new Point(boundaries.Left + randomLocation.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, 
                boundaries.Top + randomLocation.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch(level)
            {
                case 1:
                    Enemies = new List<Model.Enemy>();
                    Enemies.Add(new Monster.Bat(this, GetRandomLocation(random)));
                    WeaponInRoom=new Weapon.Sword(this,GetRandomLocation(random));
                    break;
            } 
        }
    }
}
