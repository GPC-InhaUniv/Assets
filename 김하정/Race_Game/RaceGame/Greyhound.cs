using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RaceGame
{
    public  class Greyhound
    {
        public int StartingPosition;    //Greyhound의 시작위치
        public int RacetrackLength;     //경주 트랙길이
        public PictureBox MyPictureBox = null;  //개의 픽처박스 객체 
        public int Location = 0;    //경주트랙에서의 위치
        public Random Randomizer;   //랜덤 객체 인스턴스

        public bool Run()
        {
            Point pos = MyPictureBox.Location;

            //한칸 두칸 세칸 네 칸을 무작위적으로 전진합니다.
            int distance = Randomizer.Next(1,4);
            pos.X += distance;

            //폼에서 픽처박스의 위치를 갱신합니다.  
            MyPictureBox.Location = pos;

            //경주에서 우승한 경우에는 true를 반환합니다.
            //point는 struct이다.(x와y값으로 이루어져있음) 
            //때문에 비교연산자를 사용하려면 하나의 값만 가져와야한다.

            if (pos.X >= RacetrackLength)
            {
             return true;
            }

            else
            {
             return false;
            }


        }
        //경주 시작 위치로 돌아간다.
        public void TakeStartingPosition()
        {
            Point pos = MyPictureBox.Location;//현재위치 소환
            pos.X = StartingPosition;//x축 초기값으로 설정
            MyPictureBox.Location = pos;//위에서 초기화해준 값을 넣어줌
        }
        

    }
}
