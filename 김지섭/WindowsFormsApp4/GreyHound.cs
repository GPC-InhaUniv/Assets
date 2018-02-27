using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class GreyHound
    {
        public int iStartingPosition; // 그림 박스에서 시작점
        public int iRaceTrackLength; // 트랙 길이
        public PictureBox UnitPictureBox = null; // 그림 박스 객체
        public Random Randomizor; // 랜덤 클래스의 인스턴스
        public int iDistance; // 이동 거리
        Point CurrentPoint; // 그림 상에서의 현재 위치


        public bool Run()
        {
            iDistance = Randomizor.Next(1,4);

            CurrentPoint = UnitPictureBox.Location;
            CurrentPoint.X += iDistance;

            UnitPictureBox.Location = CurrentPoint;

            if (CurrentPoint.X > iRaceTrackLength)
                return true;

            else
                return false;

        }

        public void TakeStartingPosition()
        {
            CurrentPoint.X = iStartingPosition;
            UnitPictureBox.Location = CurrentPoint;
            
        
        }

    }
}
