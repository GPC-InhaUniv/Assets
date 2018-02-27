using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PuppyRace
{
    class GreyHound
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
            int nRand;
            nRand = Randomizer.Next(4) + 1;
            Point p = MyPictureBox.Location;
            p.X += nRand;
            MyPictureBox.Location = p;

            Location = p.X;

            // 시작 위치는 28, 트랙의 길이는 450
            // x의 위치가 478보다 같거나 커지면 true 반환
            if (Location >= (StartingPosition + RacetrackLength))
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            // 경주 시작 위치로 돌아갑니다.
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
