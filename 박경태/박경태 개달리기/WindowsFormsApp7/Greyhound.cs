using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp7
{
    class Greyhound
    {
        public int StartingPosition;            // 경주견의 시작점
        public int RaceTrackLength;             // 경주 트랙 길이
        public PictureBox MyPictureBox = null;  // PictureBox의 개수
        public PictureBox MyBackGround = null;  // 경기장
        public int Location = 0;                // 경주 트랙에서의 위치
        public Random Randomizer; 

        // 1~4부터 난수를 정해서 개를 움직여준다.
        public bool Run()
        {
            Point HoundPos = MyPictureBox.Location;     // Point p에 MyPictureBox.Location의 값을 넘겨줌
            HoundPos.X += Randomizer.Next(1, 4);        // X좌표에 난수를 더해준다.
            MyPictureBox.Location = HoundPos;

            Location = MyBackGround.Size.Width - 110;   // 경주장의 크기를 넣어준다.

            // 만약 경주장의 길이보다 개의 X좌표가 더 클 때 트루를 리턴, 아니면 펄스를 리턴
            if (MyPictureBox.Location.X >= Location)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 경기가 끝나면 개를 스타팅라인으로 옮긴다.
        public void TakeStartingPosition()
        {
            Point HoundPos = MyPictureBox.Location;
            HoundPos.X = StartingPosition;
            MyPictureBox.Location = HoundPos;
        }
    }
}
