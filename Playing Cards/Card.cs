using System;
using System.Collections.Generic;
using System.Text;

namespace Playing_Cards
{
    class Card
    {
        //enum for 4 suits
        public enum SUIT
        {
            HEARTS,
            SPADES,
            DIAMONDS,
            CLUBS
        }

        //enum for face values of cards
        public enum VALUE
        {
            TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT,
            NINE, TEN, JACK, QUEEN, KING, ACE
        }

        //properties
        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}
