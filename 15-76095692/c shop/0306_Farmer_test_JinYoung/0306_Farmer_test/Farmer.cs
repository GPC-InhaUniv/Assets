using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306_Farmer_test
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier = 30;
        public int FeedMultiplier { get { return feedMultiplier; } }

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
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
        public Farmer(int numberOfCows,int feedMultiplier)
        {
            this.feedMultiplier = FeedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
