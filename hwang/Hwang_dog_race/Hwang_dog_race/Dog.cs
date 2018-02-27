using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hwang_dog_race
{
    public class Dog
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;


        public bool Run()
        {
            //한칸 , 두칸 , 세칸 ,네칸을 무작위로 전진
            //폼에서 PictureBox의 위치를 갱신한다.
            Randomizer = new Random();

            int[] distance = { 1, 2, 3, 4 };

            Point picturePoint = MyPictureBox.Location;

            picturePoint.X = picturePoint.X + distance[Randomizer.Next(1,4)];
            MyPictureBox.Location = picturePoint;


            //우승하면 트루 반환
            if (picturePoint.X >= 510)
            { 
                return true;
            }

            return false;




        }

        public void TakeStartingPosition()
        {
            Point picturePoint = MyPictureBox.Location;
            picturePoint.X = 55;
            MyPictureBox.Location = picturePoint;

            //경주 시작 위치로 돌아갑니다.
        }

   

    }
}
