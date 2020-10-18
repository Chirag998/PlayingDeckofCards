using System;

namespace Playing_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.setUpDeck();
            Console.WriteLine("Choose card number between 0 to 51");
            string input = Console.ReadLine();
            int num = checkinput(input);
            if (num == -1)
            {
                Console.WriteLine("Wrong Input");
            }
            else
            {
                if (num >= 0 && num <= 51)
                {
                    Card drawCard = deck.DrawCard(num);
                    Console.WriteLine("You seclected card is: " + drawCard.MyValue + " of " + drawCard.MySuit);
                }
            }
            Console.ReadKey();
        }

        //for checking input entered by user, It should be integer for make a card choice
        static int checkinput(string input)
        {
            int num;
            if (!Int32.TryParse(input, out num))
            {
                num = -1;
            }
            return num;
        }
    
    }
}
