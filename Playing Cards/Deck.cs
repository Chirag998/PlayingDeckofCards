using System;
using System.Collections.Generic;
using System.Text;

namespace Playing_Cards
{
    class Deck : Card //inheriting from card class
    {
        const int NUM_OF_CARDS = 52; // number of all cards
        private Card[] deck;  //array of all playing cards

        public Deck()
        {
            deck = new Card[NUM_OF_CARDS];
        }

        //function to return an array of cards
        public Card[] getDeck()
        {
            return deck;
        }

        //create deck of 52 cards: 13 values each with 4 suits
        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }

        //function for shuffling cards
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;
            //run the shuffle 1000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }

        //draw a card from a deck entered by User
        public Card DrawCard(int t)
        {
            //t-> index value of a card from a deck
            Card[] temp = getDeck();
            Card newCard = new Card();
            newCard = temp[t];
            return newCard;
        }


    }
}
