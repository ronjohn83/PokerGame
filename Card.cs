using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{

    public class Card
    {
        public enum Suit
        {
            Heart,
            Diamond,
            Spades,
            Club
        }

        public enum Value
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public Card()
        {
           
        }

        public Suit MySuit { get; set; }
        public Value MyValue { get; set; }
    }
}
