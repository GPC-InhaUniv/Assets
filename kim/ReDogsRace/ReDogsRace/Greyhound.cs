using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReDogsRace
{
    class Greyhound
    {
        public Point StartingPosition;
        public int RaceTrackLength = 580;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer;

        //Bonus : Random의 최소값이며 패배횟수에 따라 일정값 증가.
        public int Bonus = 0;
        private int loseStack = 0;
        private int defaultMoveLen = 10;

        //생성자 - 각 객체에 개 이미지 연결
        public Greyhound(PictureBox Picture)
        {
            MyPictureBox = Picture;
            StartingPosition = MyPictureBox.Location;
        }

        //Call Starting Race
        public bool Run()
        {
            Randomizer = new Random();

            // Point는 X값과 Y값을 가지고 있다.
            Point CurrentPos = MyPictureBox.Location;
            //이동거리 = Bonus ~ defaultMoveLen 사이의 랜덤값
            int Distance = Randomizer.Next(Bonus,defaultMoveLen);
            CurrentPos.X += Distance;
            MyPictureBox.Location = CurrentPos;
            
            //Touch Finishline
            if (MyPictureBox.Location.X >= RaceTrackLength)
                return true;
            else
                return false;
        }
       
        //Call End Race
        public void TakeStartingPosition()
        {
            MyPictureBox.Location = StartingPosition;

        }

        //------------------------------------------------------------


        //패배시 패배 스택 1증가
        public void LoseDog()
        {
            loseStack++;
            BonusSpeed();
        }


        /*승리시 패배 스택 감소
         * 0보다 작아지지는 않는다.
         * 패배 스택이 8 보다 클때 승리시 현재 패배스택의 절반을 잃는다.
         * 
         */
        public void WinDog()
        {
            if (loseStack > 0)
                loseStack--;
            else if (loseStack > 8)
                loseStack = loseStack / 2;
            BonusSpeed();
        }

        /* loseStack에 따른 Random메소드의 최소 수치
         * 스택이 2보다 작을때 보너스 0
         * 스택이 2보다 크고 3보다 작을때 보너스 1
         * 스택이 3보다 크고 5보다 작을때 보너스 2
         * 스택이 5보다 크고 8 보다 작을때 보너스 3
         * 그외 보너스 4        
         * */
        public void BonusSpeed()
        {
            if (loseStack < 2)
                Bonus = 0;
            else if (loseStack < 3)
                Bonus = 1;
            else if (loseStack < 5)
                Bonus = 2;
            else if (loseStack < 8)
                Bonus = 3;
            else
                Bonus = 4;

        }




    }
}
