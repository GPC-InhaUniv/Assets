using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Dogracepractice
{
    class Greyhound
    {
        public int StartingPosition; //picturebox 시작위치
        public int RacetrackLength; // 경주트랙길이
        public PictureBox MyPictureBox=null; // 이 개의 picturebox 
        public int Location = 0;//경주트랙에서의 위치
        public Random Randomizer;//random인스턴스
        public bool Run() //dog가 달리는 메서드
        {
            int distance;

            Randomizer = new Random(); //랜덤 인스턴스
            distance = (Randomizer.Next(1, 5)/(Randomizer.Next(3,6))); //이동거리=>랜덤값(1~5 사이의 난수)

            MoveDog(distance);//dogpicture의 이동거리를 계산하는 메소드
            
            if (Location>RacetrackLength-StartingPosition) 
                // RaceTrackLength가 Location(dog가 이동한 총 거리)보다 작아지면 true를 반환한다. 
                // StartingPosition의 값을 빼주지 않으면 DogPicture가 Background(트랙)밖으로 나가야 결과가 나오게 된다.
            {
                return true;
            }
            else //나머지의 경우 false반환.
            {
                return false;
            }

           
           
            
        }

        public void TakeStartingPosition()
        {
            Point MoveHound = MyPictureBox.Location;
            MoveHound.X = StartingPosition; //X포지션(DogPictureBox에  StartingPosition를 적용.)
            MyPictureBox.Location = MoveHound; 

            //경주시작위치로돌아감
        }
        
        public void MoveDog(int distance) //dogpicture들의 이동거리를 계산하는 메소드
        {
            Point MoveHound = MyPictureBox.Location;
            MoveHound.X += distance;
            MyPictureBox.Location = MoveHound;
            Location = MoveHound.X;
        }

    }
}
