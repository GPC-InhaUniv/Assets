using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Invader_Hwangyunu
{

    
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private List<Invader> invader = new List<Invader>();
        private List<Shot> shot = new List<Shot>();
        private Stars stars = new Stars();
        private bool gameOver = false;
        public event EventHandler GameOver;
        public int animationCell;

        List<Keys> keysPressed = new List<Keys>();

           


        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(0,0, 495, 440), random, invader, shot, stars);
            MessageBox.Show(game.Boudaries.Top.ToString());
            MessageBox.Show(game.playerShip.PlayerLocation.ToString());

            game.NewWave();
            GameTimer.Start();
            AnimationTimer.Start();


        }



        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            //별반짝이게하기
            //Twinkle()
            //별다시그리기
            Refresh();

            AnimateInvader();

        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {

            //Player.Location = game.PlayerLocation;

            game.Go();
            //Invalidate();


            foreach (Keys key in keysPressed)
            {
                if(key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if(key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
                else if (key == Keys.Space)
                {
                    game.FireShot();
                }
  
            }

       

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Q)
                Application.Exit();
           // if (gameOver)
                if (e.KeyCode == Keys.S)
                {
                    //게임을 초기화 하고 타이머를 재 시작하는 코드
                    return;
                }
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

                game.Draw(g, cell);


        }



        //애니메이션 효과//
        private int cell = 0;
        private int frame = 0;
        public void AnimateInvader()
        {
            frame++;
            if (frame >= 6)
            {
                frame = 0;
            }
            switch (frame)
            {
                case 0: cell = 0; break;
                case 1: cell = 1; break;
                case 2: cell = 2; break;
                case 3: cell = 3; break;
                case 4: cell = 2; break;
                case 5: cell = 1; break;
                default : cell = 0; break;
            }

        }


    }
    /*
    public class Enemy1 : PictureBox
    {
        private Timer animationTimer = new Timer();
        public Enemy1()
        {
            animationTimer.Tick += AnimationEnemy_Tick;
            animationTimer.Interval=200;
            animationTimer.Start();
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;

        }
        private int star = 0;
        public virtual void AnimationEnemy_Tick(object sender, EventArgs e)
        {
            star++;
            switch (star)
            {
                case 1: BackgroundImage = Properties.Resources.star1; break;
                case 2: BackgroundImage = Properties.Resources.star2; break;
                case 3: BackgroundImage = Properties.Resources.star3; break;
                case 4: BackgroundImage = Properties.Resources.star4; break;
                default:BackgroundImage = Properties.Resources.star3;
                    star = 0; break;
            }
        }

    }
    public class Enemy2 : Enemy1
    {

        int spaceship = 0;
        public override void AnimationEnemy_Tick(object sender, EventArgs e)
        {
            spaceship++;
            switch (spaceship)
            {
                case 1: BackgroundImage = Properties.Resources.spaceship1; break;
                case 2: BackgroundImage = Properties.Resources.spaceship2; break;
                case 3: BackgroundImage = Properties.Resources.spaceship3; break;
                case 4: BackgroundImage = Properties.Resources.spaceship4; break;
                default:BackgroundImage = Properties.Resources.spaceship3;
                    spaceship = 0; break;
            }
        }
    }
    public class Enemy3 : Enemy1
    {

        int flyingsaucer=0;
        public override void AnimationEnemy_Tick(object sender, EventArgs e)
        {
            flyingsaucer++;
            switch (flyingsaucer)
            {
                case 1: BackgroundImage = Properties.Resources.flyingsaucer1; break;
                case 2: BackgroundImage = Properties.Resources.flyingsaucer2; break;
                case 3: BackgroundImage = Properties.Resources.flyingsaucer3; break;
                case 4: BackgroundImage = Properties.Resources.flyingsaucer4; break;
                default:BackgroundImage = Properties.Resources.flyingsaucer3;
                    flyingsaucer = 0; break;
            }
        }
    }
    public class Enemy4 : Enemy1
    {

        int bug = 0;
        public override void AnimationEnemy_Tick(object sender, EventArgs e)
        {
            bug++;
            switch (bug)
            {
                case 1: BackgroundImage = Properties.Resources.bug1; break;
                case 2: BackgroundImage = Properties.Resources.bug2; break;
                case 3: BackgroundImage = Properties.Resources.bug3; break;
                case 4: BackgroundImage = Properties.Resources.bug4; break;
                default:
                    BackgroundImage = Properties.Resources.bug3;
                    bug = 0; break;
            }
        }
    }
    public class Enemy5 : Enemy1
    {

        int satellite = 0;
        public override void AnimationEnemy_Tick(object sender, EventArgs e)
        {
            satellite++;
            switch (satellite)
            {
                case 1: BackgroundImage = Properties.Resources.satellite1; break;
                case 2: BackgroundImage = Properties.Resources.satellite2; break;
                case 3: BackgroundImage = Properties.Resources.satellite3; break;
                case 4: BackgroundImage = Properties.Resources.satellite4; break;
                default:
                    BackgroundImage = Properties.Resources.satellite3;
                    satellite = 0; break;
            }
        }
    }
    */
}
