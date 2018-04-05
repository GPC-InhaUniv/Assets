using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PracticeInvaders
{
    public partial class Form1 : Form
    {
        private bool gameover = true; //게임이 종료되어야만 true지만 임시로 true로 설정함
        //원래는 gameover이벤트가 true로 설정을 해줘야함
        
        private Game game;
        public int count;

        public Form1(int count)
        {
            this.count = count;
            InitializeComponent();
            game = new Game(ClientRectangle,count);
            
        }

        List<Keys> keysPressed = new List<Keys>();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (gameover)
                if (e.KeyCode == Keys.S)
                {
                    Application.Restart();
                    //게임을 초기화하고 타이머를 재시작하는 코드
                    return;
                }
            if (e.KeyCode == Keys.Space)
                game.FireShot();

            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        public void AnimationTimer_Tick(object sender, EventArgs e)
        {
            //0부터 3까지 센 후 다시 0으로 돌아가는 카운터 작성
            //침입자 애니메이션 각각을 갱신하는데 사용

            countNumber();
           
            game.Twinkle();
            Refresh();
        }

        public int countNumber()
        {
            for(int i =0; i < 4; i++)
            {
                count++;
                switch (count)
                {
                    case 0:
                        count = 0;
                        break;
                    case 1:
                        count = 1;
                        break;
                    case 2:
                        count = 2;
                        break;
                    case 3:
                        count = 3;
                        break;
                    case 4:
                        count = 2;
                        break;
                    case 5:
                        count = 1;
                        break;
                    case 6:
                        count = 0;
                        break;

                    default:
                        break;
                }

            }
            return count;
        
         
        }


        private void Form1_GameOver(object sender, EventArgs e)
        {
            //게임타이머(별들을 반짝, 침입자들을 움직이게하는)를 중단하고
            //gameover를 true로 설정(게임이 끝남)
            //폼의 invalidate() 메소드를 호출하는 game 객체의 gameover이벤트 핸들러를 추가
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();

            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g, count);
        }


    }

}
