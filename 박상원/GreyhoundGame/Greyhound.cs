using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GreyhoundGame
{
    public class Greyhound
    {
        public int StartingPosition { get; set; } // 시작 위치
        public int RacetrackLength { get; set; } // 레이스 트랙 거리
        public PictureBox MyPictureBox {get; set; }
        public int Location { get; set; } // 위치
        public Random Randomizer { get; set;} // 랜덤값

        public bool Run()
        {
            int randomDistance = this.Randomizer.Next(1, 4); // 랜덤 최소값 및 최대값
            this.Location += randomDistance; // 랜덤값 위치에 저장

            Point p = this.MyPictureBox.Location;
            if (p.X > this.RacetrackLength)
            {
                return true;
            }
            else
            {
                p.X += randomDistance;
                this.MyPictureBox.Location = p;

                return false;
            }           
        }

        public void TakeStartingPosition() // 시작 위치로 초기화
        {
            this.Location = this.StartingPosition; // 현재 위치값에 시작위치 값을 덮어씌워 저장

            Point p = this.MyPictureBox.Location;
            p.X = Location;
            this.MyPictureBox.Location = p;
        }
    }
}
