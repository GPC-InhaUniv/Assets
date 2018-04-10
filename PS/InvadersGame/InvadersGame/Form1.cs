using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvadersGame
{
    public partial class Form1 : Form
    {
        List<Keys> keysPressed = new List<Keys>();      // Keys형으로 keysPressed 리스트 생성

        private Game game;      // 게임 클래스 선언
        private bool gameOver;      // 게임오버 변수 선언

        public Rectangle Boundaries { get { return this.ClientRectangle; } }        // Rectangle 구조체 선언 (사각형의 위치와 크기를 나타내는 네 정수의 집합 저장)
                                                                                    // ClientRectangle :컨트롤의 클라이언트 영역을 나타내는 Rectangle
        Random random = new Random();       // Random 클래스 random 객체 선언. 난수 생성기

        public Form1()      // 폼 생성자
        {
            InitializeComponent();      // 구성요소의 컴파일된 페이지를 로드함. 초기화
            game = new Game(random, Boundaries);        // game 객체 생성. 랜덤과 바운더리를 매개변수로 함.
            gameOver = false;
            game.GameOver += new EventHandler(game_GameOver);       // 게임오버 이벤트핸들러 생성
            timerAnimation.Start();         // 애니메이션타이머 시작
        }

        private void Form1_Paint(object sender, PaintEventArgs e)       // Paint 이벤트. 컨트롤을 다시 그리면 발생
        {
            Graphics g = e.Graphics;        // 그래픽스 클래스 g 객체 선언
            game.Draw(g, gameOver);         // 게임 객체를 그림
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)       // KeyDown 이벤트. 컨트롤에 포커스가 있을 때 키를 누르면 발생
        {
            if (e.KeyCode == Keys.Q)        // KeyCode 속성이 Q키로 눌렸는지 확인
                Application.Exit();       // 프로그램 종료

            if (gameOver)
                if(e.KeyCode == Keys.S)        // KeyCode 속성이 S키로 눌렸는지 확인
                {
                    gameOver = false;
                    game = new Game(random, Boundaries);
                    game.GameOver += new EventHandler(game_GameOver);
                    timerGame.Start();      // 게임타이머 시작
                    return;
                }

            if (e.KeyCode == Keys.Space)        // KeyCode 속성이 Space키로 눌렸는지 확인
                game.FireShot();        // 게임 클래스의 FireShot 메소드 호출
            if (keysPressed.Contains(e.KeyCode))        // 눌린 키가 있는지 확인
                keysPressed.Remove(e.KeyCode);        // 눌린 키 삭제
            keysPressed.Add(e.KeyCode);         // 키 추가
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {            
        }

        private void timerGame_Tick(object sender, EventArgs e)         // 게임타이머 이벤트
        {
            //game.Go();        // 게임 클래스의 Go메소드 호출
            foreach (Keys key in keysPressed)       // 눌린 키 마다
            {
                if(key == Keys.Left)        // 왼쪽방향키면
                {
                    game.MovePlayer(Direction.Left, gameOver);      // MovePlayer 메소드 호출. 게임오버가 아닐 경우 왼쪽방향으로 움직인다.
                    return;
                }
                else if(key == Keys.Right)        // 오른쪽방향키면
                {
                    game.MovePlayer(Direction.Right, gameOver);        // MovePlayer 메소드 호출. 게임오버가 아닐 경우 오른쪽방향으로 움직인다.
                    return;
                }
            }

            Invalidate();       // 컨트롤의 전체 화면을 무효화하고 컨트롤을 다시 그림. 초기화
        }

        private void game_GameOver(object sender, EventArgs e)         // 게임오버 이벤트
        {
            timerGame.Stop();       // 게임타이머 멈춤
            gameOver = true;
            Invalidate();
        }
    }
}
