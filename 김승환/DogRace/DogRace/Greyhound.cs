using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    // 멍멍이들 클래스
    public class Greyhound
    {
        // 변수 필드
        public int startingPosition;
        public int racetrackLength;
        public PictureBox myPictureBox = null;
        public int location = 0;
        public Random randomizer;

        // 생성자 초기화
        public Greyhound(int startingPosition, int racetrackLength, PictureBox myPictureBox)
        {
            this.startingPosition = startingPosition;
            this.racetrackLength = racetrackLength;
            this.myPictureBox = myPictureBox;
        }

        // 댕댕이이가 경주하는 메소드 
        public bool Run()
        {
            randomizer = new Random();

            int distance = randomizer.Next(1, 50);

            Move(distance);

            location += distance;

            if (location >= (racetrackLength - startingPosition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 댕댕이가 움직이는 메소드
        public void Move(int distance)
        {
            Point p = myPictureBox.Location;
            p.X += distance;
            myPictureBox.Location = p;
        }

        // 댕댕이의 위치를 시작위치로 초기화
        public void TakeStartingPostion()
        {
            Move(-location);

            location = 0;
        }
    }
}
