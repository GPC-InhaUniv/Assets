using System;
using System.Drawing;
using System.Windows.Forms;

namespace DogRunnig
{
    public class Dog
    {
        public Point StartPosition; //개의 시작지점
        public int RaceTrackLength; //달려야 할 총 길이
        public PictureBox PictureBox; //개의 그림 객체
        public int Position = 0; //개의 위치
        public Random Random; //랜덤 객체

        //개가 달린드아아아아아ㅏㅏㅏ
        public bool Run()
        {
            //랜덤값만큼 현재 위치좌표에 더함
            Point p = PictureBox.Location;
            p.X += Random.Next(2,8);
            PictureBox.Location = p;

            //결승선 통과 여부 체크
            if (PictureBox.Location.X + PictureBox.Size.Width >= RaceTrackLength)
            {
                return true;
            }
            else return false;
        }

        //원래 위치로 되돌림
        public void SetStartPosition()
        {
            PictureBox.Location = StartPosition;
        }
    }
}
