using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulationrace
{
    public class Greyhound
    {
        public int StartingPosition;// pictureBox 시작 위치
        public int RacetrackLength; //경주트랙 길이
        public PictureBox MypictureBox = null;// 해당 개의 픽쳐박스 객체
        public int Location = 0; //경주 트랙에서의 위치
        public Random Randomizer; //Random 객체 인스턴스

        public bool Run()
        {
            int moveSpaces = Randomizer.Next(1, 4); //랜덤 변수, 객체를 생성함

            //한칸,두칸,세칸,네칸을 무작위 전진
            //폼에서 PictureBox의 위치를 갱신
            //경주에서 우승한 경우에는 true를 반환합니다.

            Point position = MypictureBox.Location; //픽쳐박스의 현재 위치의 x,y

            position.X += moveSpaces; //픽쳐박스의 현재 위치d의 x에 랜덤값을 플러스함

            MypictureBox.Location = position; // 픽쳐박스의 현재위치를 position함수와 같다고함

            if (position.X >= RacetrackLength) //개의 위치가 레이스트랙보다 커지거나 같으면
            {
                return true; // 우승하면 트루를 반환
            }
            else
            {
                return false; //false라면 while문은 계속 실행, 우승하는 개가 나올때까지
                
            }
        }
        public void TakeStartingPosition() //시작하는 포지션을 다시 정하는 함수
        {
            Point position = MypictureBox.Location; //픽쳐박스의 현재 위치

            position.X = StartingPosition;

            MypictureBox.Location = position;
        }

    } 
}
