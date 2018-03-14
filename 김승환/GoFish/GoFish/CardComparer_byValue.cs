using System.Collections.Generic;

namespace GoFish
{
    internal class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.value > y.value)
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