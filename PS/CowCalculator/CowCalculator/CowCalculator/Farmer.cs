using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowCalculator
{
    class Farmer
    {
        public Farmer (int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int BagsOfFeed { get; private set; }

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }    // 읽기전용

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
    }
}
