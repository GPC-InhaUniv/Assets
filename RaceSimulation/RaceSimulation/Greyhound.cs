using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RaceSimulation
{
    class Greyhound
    {

        public int StartingPostion; //처음 시작
        public int RacetrackLength; //트랙의 길이
        public PictureBox MyPictureBox = null; //이미지 파일 저장 변수
        public int Location = 0;
        public Random Randomizer; //달리는 속도는랜덤
        public int distance;
        bool finish = false;
        public bool cheatDog = false;

        public Greyhound()
        {

            StartingPostion = 0;
            RacetrackLength = 621;

        }

        public bool Run()       //main func!
        {
            //MOVE FOWARD 1,2,3,4 SPACE AT RANDOM
            //UPDATE THE POSITION (PICTURE BOX)
            //RETURN TRUE IF WON THE RACE

            Randomizer = new Random();
            distance = Randomizer.Next(2, 15);      //set random number while racing
            int go = Randomizer.Next(1, 500);       //set run or not while racing  


            if (Location >= RacetrackLength)            //check finish line 
                finish = true;
            else if (go >= 400)         //go's range= 1~500 . if go is bigger than 400 , greyhound move
            {

                Point p = MyPictureBox.Location;
                if (cheatDog && p.X <= 500)                //this is cheating line
                {                                       //if cheat dog(most selected) run fast until goal line minus 120
                    distance += 2;
                }
                else if (cheatDog && p.X >= 580)             //slow down dog's speed Where in the vicinity(near goal line)
                {
                    distance = 1;                       //fixing speed
                }

                //move greyhound(picture) part
                p.X += distance;
                Location = p.X;
                MyPictureBox.Location = p;
                MyPictureBox.Update();

            }
            return finish;
        }

        public void takeStartingPosition()      //reset dog's position,cheating,finish
        {
            //RESET LOCATION TO THE START LINE
            Location = 31;
            Point p = new Point(0, MyPictureBox.Location.Y);
            MyPictureBox.Location = p;
            finish = false;
            cheatDog = false;
        }



    }
}
