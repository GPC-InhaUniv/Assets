using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    public class Card
    {
        public static string Plural(Value value)
        {
            if(value == Value.six)
            {
                return "Sixes";
            }
            else
            {
                return value.ToString() + "s";
            }
        }

        public enum Suit
        {
            spade = 0,
            clover = 1,
            diamond = 2,
            heart = 3,
        }

        public enum Value
        {
            ace = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            jack = 11,
            queen = 12,
            twelve = 13
        }
        
        public string Name { get => suit.ToString() + " of " + value.ToString(); }

        public Suit suit;
        public Value value;

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }
        
    }
}
