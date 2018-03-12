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

        private int racetrackLength; //트랙의 길이
        private int location = 0;
        private bool finish = false; //check Dog Arrive FinishLine

        public bool bcheatDog = false;  //check 

        public PictureBox MyPictureBox = null; //이미지 파일 저장 변수


        public Greyhound()
        {
            racetrackLength = 621;
        }

        public bool Run(int randomspeed)       //main func!
        {
            //MOVE FOWARD 1,2,3,4 SPACE AT RANDOM
            //UPDATE THE POSITION (PICTURE BOX)
            //RETURN TRUE IF WON THE RACE

            if (location >= racetrackLength)            //check finish line 
                finish = true;                      //if dog over finishline, finish variable change true;

            else if (randomspeed % 2 == 0)         //50% 확률로 달릴지 말지가 결정되어짐.
            {

                Point p = MyPictureBox.Location;
                if (bcheatDog && p.X <= 400)                //this is cheating line
                {                                       //if cheat dog(most selected) run fast until goal line minus 200
                    randomspeed += 1;
                }
                else if (bcheatDog && p.X >= 410)             //slow down dog's speed Where in the vicinity(near goal line)
                {
                    randomspeed -= 1;
                    if (randomspeed <= 0) randomspeed = 1;                      //fixing speed  almost cheat dog lose the game
                }

                //move greyhound(picture) part
                p.X += randomspeed;
                location = p.X;
                MyPictureBox.Location = p;
                MyPictureBox.Update();

            }
            return finish;
        }

        public void TakeStartingPosition()      //reset dog's position,cheating,finish
        {
            //RESET LOCATION TO THE START LINE
            location = 31;  //reset dog's position variable
            Point p = new Point(0, MyPictureBox.Location.Y);  //reset dog picture
            MyPictureBox.Location = p;
            finish = false;
            bcheatDog = false;
        }



    }
}
