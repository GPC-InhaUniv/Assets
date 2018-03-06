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
        public int Location = 0;
        public int distance=0;
        public bool finish = false; //check Dog Arrive FinishLine
        public bool cheatDog = false;  //check 

        public PictureBox MyPictureBox = null; //이미지 파일 저장 변수
        public Random Randomizer; //달리는 속도는랜덤

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
                finish = true;                      //if dog over finishline, finish variable change true;

            else if (go >= 400)         //go's range= 1~500 . if go is bigger than 400 , greyhound move
            {

                Point p = MyPictureBox.Location;
                if (cheatDog && p.X <= 500)                //this is cheating line
                {                                       //if cheat dog(most selected) run fast until goal line minus 120
                    distance += 2;
                }
                else if (cheatDog && p.X >= 580)             //slow down dog's speed Where in the vicinity(near goal line)
                {
                    distance = 1;                       //fixing speed  almost cheat dog lose the game
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
            Location = 31;  //reset dog's position variable
            Point p = new Point(0, MyPictureBox.Location.Y);  //reset dog picture
            MyPictureBox.Location = p;
            finish = false;     
            cheatDog = false;   
        }



    }
}
