using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeQuest
{
    class Game
    {
        public List<Enemy> Enemies;
            
        public Weapon WeaponInRoom; //웨폰이 필드에 있는가?

        private Player player; //플레이어 클래스로부터 받아와 이곳에서 관리
        public Point PlayerLocation { get { return player.Location; } } //플레이어의 현재 위치를 반환
        public int PlayerHitPoints { get { return player.HitPoints; } } //플레이어의 HP를 반환
        public List<string> PlayerWeapons { get { return player.Weapons; } } //플레이어가 가질 웨폰의 리스트

        private Point location;
        private int level = 0;

        public int Level { get { return level; } } // level객체는 읽기전용으로 game객체에서만 관리합니다.

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70)); //맵에서 플레이어를 생성합니다.
        }

        public void Move(Direction direction, Random random) //플레이어와 적의 이동함수
        {
            player.Move(direction); //enum 디렉션기반으로 지정한 위치 이동
            foreach (Enemy enemy in Enemies) // 루프문으로 적들 각각 하나씩 랜덤적으로 이동하게 함
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName); //웨폰 리시트에서 해당 매개변수가 포함됐는가?
        }

        public void HitPlayer(int MaxDamage, Random random)
        {
             player.Hit(MaxDamage, random); //플레이어는 최대 댐지안에서 랜덤값만큼 공격
             
        }

        public void IncreasePlayerHealth(int Health, Random random)
        {
            player.IncreaseHealth(Health, random); //플레이어의 체력회복 값은 랜덤으로...
        }

        public void Attack(Direction direction, Random random) // attak메소드는 플레이어와 적 모두 해당
        { // 플레이어가 공격을 하면 적 또한 움직입니다...
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random) //아이템과 적의 위치를 새로운 레벨마다 랜덤값으로 하여 생성하게 해줌
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            Bow bow = new Bow(this, this.location);
            Mace mace = new Mace(this, this.location);
            BluePotion blue = new BluePotion(this, this.location);
            RedPotion red = new RedPotion(this, this.location);

            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));

                    WeaponInRoom = new Sword(this, GetRandomLocation(random)); //무기 객체를 새로 할당
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (CheckPlayerInventory(bow.Name)==false)
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    if(CheckPlayerInventory(blue.Name)==false)
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;

                case 6:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    if (CheckPlayerInventory(mace.Name) == false)
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    if (CheckPlayerInventory(red.Name) == false)
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                default:
                    MessageBox.Show("게임이 종료됐습니다 \n 잘하셨어요.");
                    Application.Exit(); // Game Over
                    break;
            }
        }
    }
}
