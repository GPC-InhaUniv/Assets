using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace HeadFirst_Invader
{
    public partial class MainForm : Form
    {
        Game game;
        GameOverEvent gameoverevent=new GameOverEvent();

        private SoundPlayer backgroundSound;
        private SoundPlayer shotSound;

        Dictionary<string, int> gameData;
        List<Keys> keyPressEvent;

        bool gameOver = false;
        bool gameStart = false;

        Point gamestarpos;
        Point halloffamepos;
        Point exitpos;

        Point moveWindowRight;
        Point moveWindowLeft;

        int shakeCount = 10;

        bool shakeDirection = false;

        Label[] invaderscroeLabel = new Label[5];
        int ShowScoreTick = 0;

        public MainForm()
        {
            InitializeComponent();

            keyPressEvent = new List<Keys>();

            gamestarpos = new Point(259, 307);
            halloffamepos = new Point(259, 358);
            exitpos = new Point(259, 411);

            gameData = new Dictionary<string, int>();
            game = new Game(this.ClientRectangle);

            leftrightlabel.Location = gamestarpos;
            MainImage.Load(@"images\mainimage.png");
            backgroundSound = new SoundPlayer();
            backgroundSound.SoundLocation = @"bgm\invaderBgm.wav";
            shotSound = new SoundPlayer();
            shotSound.SoundLocation = @"bgm\playerShot.wav";

          

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            backgroundSound.Play();
            backgroundSound.PlayLooping();
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);      //evnet handler 사용!
        }
     
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (keyPressEvent.Count() >= 1)
            {
                switch (keyPressEvent[0])
                {
                    case Keys.Left:
                        game.MovePlayer(Direction.Left);
                        break;
                    case Keys.Right:
                        game.MovePlayer(Direction.Right);
                        break;
                    default:
                        break;
                }

            }
            game.Go();


            game.InvadersArrivePlayer();


            scoreLabel.Text = game.Score.ToString();
            currentStageLabel.Text = "Stage: " + game.CurrentStage.ToString();

            if (game.KillAllInvdares())
            {
                game.ResetInvaderAndPlayerPosition();
                if (animationTimer.Interval - game.FramesSkipped > 0)
                    animationTimer.Interval -= game.FramesSkipped;
            }

            if (game.LiveLeft < 0 && gameOver == false && gameStart == true)
            {
                game.OccurGameoverEvent(new GameOverEvent());
            }

            this.Refresh();

        }


        private void ShakeWindow()
        {
            //게임 이펙트 설정
            if (game.ShockWave)
            {
                if (shakeCount >= 0)
                {
                    if (shakeDirection)
                    {
                        moveWindowRight = new Point(this.Location.X + 3, this.Location.Y + 3);
                        this.Location = moveWindowRight;
                        shakeDirection = !shakeDirection;
                    }
                    else
                    {
                        moveWindowLeft = new Point(this.Location.X - 3, this.Location.Y - 3);
                        this.Location = moveWindowLeft;
                        shakeDirection = !shakeDirection;
                    }

                    shakeCount--;
                    if (shakeCount <= 0)
                    {
                        game.ShockWave = false;
                        shakeCount = 10;
                    }
                }
            }
            //게임 이펙트 설정 끝
        }

        private void ShowKilledInvaderScore()
        {
            //각가의 점수를 표기하는 기간이 다르므로 invader 클래스 자체가 
            //이것에 대한 기능을 갖는것이 좋다고 생각!
            if (game.KillInvader)
            {
                for (int i = 0; i < game.InvaderScoreLabelList.Count; i++)
                {
                    invaderscroeLabel[0].Location = game.InvaderScoreLabelList[i].Location;
                    invaderscroeLabel[0].Text = game.InvaderScoreLabelList[i].Score.ToString();
                    invaderscroeLabel[0].Visible = true;
                    game.InvaderScoreLabelList.RemoveAt(i);
                }

                if (invaderscroeLabel[0].Visible)
                {
                    invaderscroeLabel[0].Location = new Point(invaderscroeLabel[0].Location.X,
                        invaderscroeLabel[0].Location.Y - 3);

                    ShowScoreTick += 1;
                    if (ShowScoreTick >= 10)
                    {
                        invaderscroeLabel[0].Location = new Point(-10, -10);
                        invaderscroeLabel[0].Visible = false;
                        game.KillInvader = false;
                        ShowScoreTick = 0;
                    }
                }
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (gameStart && !gameOver)
            {
                game.MoveNextImage();
                game.MoveInvaders();
                game.MoveItems();
                ShakeWindow();
                ShowKilledInvaderScore();
            }



            this.Refresh();
        }
        private void GameOverEvnet(object o, EventArgs e)
        {
            gameOver = true;
            string message = "Game Over...\n Your Total Score: " + scoreLabel.Text.ToString();

            MessageBox.Show(message);
            string line;
            string temp = "";

            List<int> loadScore = new List<int>();
            using (StreamReader textreader = new StreamReader(@"hallOfFame\hallOfFame.txt"))
            {

                while ((line = textreader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '#')
                        {
                            temp = line.Substring(i + 1, line.Length - (i + 1));
                            loadScore.Add(Convert.ToInt32(temp));
                        }
                    }
                }
            }

            loadScore.Add(game.Score);

            var sortingScore = from score in loadScore
                               orderby score descending
                               select score;

            using (StreamWriter streamwriter = new StreamWriter(@"hallOfFame\hallOfFame.txt"))
            {
                streamwriter.WriteLine("PlayerName		Score");
                for (int i = 0; i < 5; i++)
                {
                    streamwriter.WriteLine("UnKnown" + (i + 1) + "		#" + sortingScore.ElementAt(i).ToString());
                }

            }

            Application.Exit();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Space && gameStart)
            {

                game.PlayerShot(game.Player.Location);
                //shotSound.Play();

            }
            if (e.KeyCode == Keys.Down && !gameStart)
            {


                if (leftrightlabel.Location.Y == 307)
                {
                    leftrightlabel.Location = halloffamepos;

                }
                else if (leftrightlabel.Location.Y == 358)
                    leftrightlabel.Location = exitpos;
            }

            if (e.KeyCode == Keys.Up && !gameStart)
            {
                if (leftrightlabel.Location.Y == 358)
                {
                    leftrightlabel.Location = gamestarpos;

                }
                else if (leftrightlabel.Location.Y == 411)
                    leftrightlabel.Location = halloffamepos;

            }
            if (e.KeyCode == Keys.Enter && !gameStart)
            {
                if (!gameStart)
                {
                
                    if (leftrightlabel.Location.Y == 307)
                    {
                        game = null;
                        gameStart = true;
                        gameData.Add("Unknown", 0);
                        
                        game = new Game(this.ClientRectangle);
                        game.gameover += new EventHandler(GameOverEvnet);
                        for (int i = 0; i < 5; i++)
                        {
                            invaderscroeLabel[i] = new System.Windows.Forms.Label();
                            invaderscroeLabel[i].AutoSize = true;
                            invaderscroeLabel[i].Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            invaderscroeLabel[i].ForeColor = System.Drawing.Color.DeepPink;
                            invaderscroeLabel[i].Location = new System.Drawing.Point(0, 0);
                            invaderscroeLabel[i].Name = "label" + i.ToString();
                            invaderscroeLabel[i].Size = new System.Drawing.Size(22, 22);
                            invaderscroeLabel[i].TabIndex = i + 2;

                            this.Controls.Add(invaderscroeLabel[i]);

                            leftrightlabel.Visible = false;
                            scoreLabel.Visible = true;
                            currentStageLabel.Visible = true;
                            MainImage.Visible = false;
                            gameStartLabel.Visible = false;
                            HallOfFameLabel.Visible = false;
                            ExitLabel.Visible = false;

                        }
                        
                    }
                    else if (leftrightlabel.Location.Y == 358)
                    {
                        string line = "";
                        string[] strarr;
                        string temp = "";
                        using (StreamReader textreader = new StreamReader(@"hallOfFame\hallOfFame.txt"))
                        {
                            while ((line = textreader.ReadLine()) != null)
                            {
                                strarr = line.Split(' ');
                                temp += line + "\n";
                            }
                        }
                        MessageBox.Show(temp, "Hall Of Frame!!");

                        leftrightlabel.Location = gamestarpos;
                    }
                    else if (leftrightlabel.Location.Y == 411)
                    {
                        Application.Exit();
                    }

                }
            }

            if (e.KeyCode == Keys.T)
            {
                game.ResetInvaderAndPlayerPosition();
                if (animationTimer.Interval - game.FramesSkipped > 0)
                    animationTimer.Interval -= game.FramesSkipped;
                if (invaderShotTimer.Interval - game.FramesSkipped > 0)
                    invaderShotTimer.Interval -= game.FramesSkipped;

            }

            if (keyPressEvent.Contains(e.KeyCode))
            {
                keyPressEvent.Remove(e.KeyCode);
            }

            keyPressEvent.Add(e.KeyCode);
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (keyPressEvent.Contains(e.KeyCode))
            {
                keyPressEvent.Remove(e.KeyCode);
            }


        }

        private void twinkleTimer_Tick(object sender, EventArgs e)
        {
            game.Twinkle();

        }

        private void invaderShotTimer_Tick(object sender, EventArgs e)
        {
            if (gameStart && !gameOver)
                game.InvaderShot();
        }

    }
}
