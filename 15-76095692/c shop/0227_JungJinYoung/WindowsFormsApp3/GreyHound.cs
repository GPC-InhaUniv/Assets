using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class GreyHound
    {
        public int StartingPosition;//PictureBox 시작위치
        public int RacetrackLength;//경주트랙길이
        public PictureBox MyPictureBox = null; //이 개의 pictureBox 객체
        public int Location = 0;//경주 트랙에서의 위치
        public Random Randomizer;// random 객체 인스턴스
        public Point p;
        public int distance;


        public bool Run()
        {
            //한칸,두칸,세칸,네칸을 무작위적으로 전진한다
            //폼에서 picturebox의 위치를 갱신한다
            //경주에서 우승한경우는 ture를 반환한다
            Randomizer = new Random();
            distance = Randomizer.Next(1, 10);//.next(최소값,최대값) *주의 최대값의'미만'인 정수를 반환함

            p = MyPictureBox.Location;// 그림의 현재위치를 구한다
            p.X += distance;//x좌표에 움직일 거리를 더한다
            MyPictureBox.Location = p;//pictureBox 객체의 위치를 갱신한다

            Location += distance;

            if (Location >= (RacetrackLength - StartingPosition))//경기가 끝나면 true 아니면 false
            {
                return true;
            }
            return false;
        }

        public void TackeStartingPosition()
        {
            //경주 시작위치로 돌아갑니다.
            p.X -= Location;//x좌표에 움직일 거리를 더한다
            MyPictureBox.Location = p;//pictureBox 객체의 위치를 갱신한다
            Console.WriteLine("위치 : " +Location);
            Location = 0;
            Console.WriteLine("초기화 후 위치 : " + Location);


        }

       
    }
}
