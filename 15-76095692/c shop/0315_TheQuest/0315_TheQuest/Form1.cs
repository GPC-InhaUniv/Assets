using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0315_TheQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //System.Diagnostics.Debug.WriteLine("safd");//단발 디버깅용 using 써보자
        private Game game;
        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));//던전의 경계
            game.NewLevel(random);
            UpdateCharacters();
        }
        public void UpdateCharacters()
        {
            PlayerPictureBox.Location = game.PlayerLocation;
            PlayerHitPointLabel.Text = game.PlayerHitPoints.ToString();
            bool showBet = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            //기타 코드가 들어갈 자리
            bool showWeapons = false;

            //적의 위치와 히트포인트를 갱신한다.
            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bet)
                {
                    BetPictureBox.Location = enemy.Location;
                    BetHitPointLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints >0)
                    {
                        showBet = true;
                        BetPictureBox.Visible = showBet;
                        enemiesShown++;
                    }
                }
                if(enemy is Ghost)
                {
                    GhostPictureBox.Location = enemy.Location;
                    GhostHitPointLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        GhostPictureBox.Visible = showGhost;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    GhoulPictureBox.Location = enemy.Location;
                    GhoulHitPointLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        GhoulPictureBox.Visible = showGhoul;
                        enemiesShown++;
                    }
                }
            }
            //무기 pictureBoc를 갱신한다.
            //foreach(Weapon weapon in game.WeaponInRoom)
            if(game.WeaponInRoom is Sword)
            {
                showWeapons = true;
                SowrdPictureBox.Visible = showWeapons;
                //Sw
            }
            
            //물품목록아이콘 picturebox의 visible속성을 설정한다.

            //플레이어가 방에있는 무기를 집어들었는지 확인하고 화면에 표시할지 안할지 결정
            //플레이어가 죽었는지 확인
            //플레이어가 적을 전부 죽였는지 -> 다음레벨로 이동한다.

        }


        //이동버튼 4종
        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        //공격버튼 4종
        private void AttackUpButton_Click(object sender, EventArgs e)
        {
            int currentHP = game.PlayerHitPoints;
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackDownButton_Click(object sender, EventArgs e)
        {
            int currentHP = game.PlayerHitPoints;
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void AttackLeftButton_Click(object sender, EventArgs e)
        {
            int currentHP = game.PlayerHitPoints;
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void AttackRightButton_Click(object sender, EventArgs e)
        {
            int currentHP = game.PlayerHitPoints;
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
