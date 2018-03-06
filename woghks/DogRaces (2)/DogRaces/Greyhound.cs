using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DogRaces
{
    class Greyhound
    {
        public int StartingPosition;            // PictureBox 시작 위치
        public int RacetrackLength;             // 경주 트랙 길이
        public PictureBox MyPictureBox = null;  // 이 개의 PictureBox 객체
        public int Location = 0;                // 경주 트랙에서의 위치
        public Random Randomizer;               // Random 객체 인스턴스

        public bool Run()
        {
            // 한 칸, 두 칸, 세 칸, 네 칸을 무작위적으로 전진
            // 폼에서 PictureBox의 위치를 갱신
            // 경주에서 우승한 경우에는 true를 반환
            int randomDistance = Randomizer.Next(1, 4);
            Location += randomDistance;

            Point p = MyPictureBox.Location;   //개의 위치
            if (p.X > RacetrackLength)
            {
                return true;
            }
            else
            {
                p.X += randomDistance;
                MyPictureBox.Location = p;

                return false;
            }
        }

        public void TakeStartingPosition()
        {
            // 경주 시작 위치로 돌아갑니다.
            Location = StartingPosition;
            Point p = MyPictureBox.Location;
            p.X = Location;
            MyPictureBox.Location = p;
        }
    }
}