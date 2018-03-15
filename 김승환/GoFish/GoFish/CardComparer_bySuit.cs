using System.Collections.Generic;

namespace GoFish
{
    internal class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.suit > y.suit)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}