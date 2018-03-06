using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacing
{
    class Greyhound
    {
        public int StartingPosition;        // Picture 시작 위치
        public int RacetrackLength;         // 경주 트랙 길이
        public PictureBox MyPictureBox = null;      // 이 개의 Picturebox 객체
        public int Location = 0;        // 경주 트랙에서의 위치
        public Random Randomizer;       // Random 객체 인스턴스

        public bool Run()
        {
            // 한 칸, 두 칸, 세 칸, 네 칸을 무작위로 전진합니다.
            // 폼에서 PictureBox의 위치를 갱신합니다.
            // 경주에서 우승한 경우에는 true를 반환합니다.
            int randomDistance = Randomizer.Next(1, 4);
            Location += randomDistance;
            Point dogPosition = MyPictureBox.Location;
            dogPosition.X += StartingPosition;
            if(dogPosition.X > RacetrackLength - StartingPosition)
            {
                return true;
            }
            else
            {
                dogPosition.X += randomDistance;
                MyPictureBox.Location = dogPosition;
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            // 경주 시작 위치로 돌아갑니다.
            Location = StartingPosition;
            Point dogPosition = MyPictureBox.Location;
            dogPosition.X = Location;
            MyPictureBox.Location = dogPosition;
            
        }
    }
}
