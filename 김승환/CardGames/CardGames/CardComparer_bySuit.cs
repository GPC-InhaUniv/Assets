using System.Collections.Generic;

namespace CardGames
{
    internal class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if(x.value > y.value)
            {
                return 1;
            }
            else if(x.suit > y.suit)
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