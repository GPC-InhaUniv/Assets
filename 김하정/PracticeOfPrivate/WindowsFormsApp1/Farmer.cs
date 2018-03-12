using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiPlier; //매개변수
        public int FeedMultiPlier { get { return feedMultiPlier; } }   /*{ get; private set; }*/

        //생성자를 이용한 비공개 필드 초기화
        public Farmer(int numberOfCow, int feedMultiPlier)
        {
            this.feedMultiPlier = feedMultiPlier;
            NumberOfCows = numberOfCow;
        }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiPlier;
            }
                   
        }

        //string secretCode;
        //string name = "Dash Martin";
        //public string Name
        //{
        //    get { return name; }
        //}

        //public string Password
        //{
        //    set
        //    {
        //        if (value == secretCode)
        //        {
        //            name = "Herb Jones";
        //        }
        //    }
        //}



    }
}
