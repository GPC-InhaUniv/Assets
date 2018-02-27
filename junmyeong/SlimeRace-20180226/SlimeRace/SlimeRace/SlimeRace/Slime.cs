using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SlimeRace
{
    class Slime
    {
        public string slimeName;
        public int startingPosition;   //PictureBox 시작 위치
        public int racetrackLength;    //경주 트랙 길이
        public PictureBox MyPictureBox = null; //이 슬라임의 PictureBox 객체
        public int location = 0;       //경주 트랙에서의 위치
        public Random Randomizer;      //랜덤 객체 인스턴스

        public Slime(int startingposition, int racetracklength, PictureBox mypicturebox, string slimeName)    
            //객체 생성을 위한 생성자
        {
            this.startingPosition = startingposition;
            this.racetrackLength = racetracklength;
            this.MyPictureBox = mypicturebox;
            this.slimeName = slimeName;
        }
        public bool Run()                        //레이스 시작시 움직임을 처리하는 부분.
        {
            SlimeMove(slimeName);                //슬라임들의 움직임을 처리하는 메소드.
            if (location >= racetrackLength - startingPosition)    
                //경주에서 우승한 경우에는 true를 반환합니다.
            {
                return true;
            }
            else
                return false;

        }

        public void TakeStartingPosition()       //끝난 후 경주 시작위치로 돌아갑니다.
        {
            Point point = MyPictureBox.Location; //이미지를 움직이기 위한 Point 변수를 해당 이미지 위치로 받음.
            point.X = startingPosition;          //X좌표를 시작위치로 선언
            MyPictureBox.Location = point;       //해당 이미지의 위치를 시작위치로 옮김.
            location = 0;                        //경주 트랙에서의 위치 0으로 초기화.
        }


        public void PictureMove(int distance)    //슬라임 이미지들을 이동 시키는 메서드
        {
            Point point = MyPictureBox.Location;
            point.X += distance;                 //시작 좌표 대신 이동거리로 함
            MyPictureBox.Location = point;       //폼에서 PictureBox의 위치를 갱신합니다.
            location += distance;                //경주 트랙 위치 이동거리에 따라 변함.

        }
        public void SlimeMove(string name)        //슬라임 별 거리이동 값 메서드
        {
            Randomizer = new Random();            //조건을 위한 객체 선언.
            int distance = 0;                     //이동거리 변수
            if (slimeName == "핑크슬라임")        //핑크슬라임 패턴
            {
                distance = 20;                    //항상 20만큼 이동합니다.
            }
            else if (slimeName == "태비슬라임")   //태비슬라임 패턴
            {
                int p​robability = Randomizer.Next(0, 15);  // 0 부터 15까지 수를 무작위로 선택
                if (p​robability < 2)             //선택된 값이 2보다 작을때(약 13%)
                    distance = 100;
                else                              //2보다 클때
                    distance = 5;
            }
            else if(slimeName == "헌터슬라임")    //헌터슬라임 패턴
            {
                distance = Randomizer.Next(10, 32); // 10부터 32까지 랜덤 이동
            }
            else                                  //붐슬라임 패턴
            {
                int p​robability = Randomizer.Next(1, 100); //1부터 100까지 수를 무작위로 선택
                if (probability == 1)             //선택된 값이 1 일경우(약1%)
                    distance = 820;               //한방에 끝.
            }
            PictureMove(distance);
        }

    }
}
