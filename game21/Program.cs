using System;
using System.Collections.Generic;


namespace game21
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            int timeShuffled = 0;
            //this is an emptey list 
            deck = Shuffle(deck,out timeShuffled,3);
           //this is how to shuffle x amount of times
            //deck = Shuffle(deck:deck,times: 3);
           
            // this is to have a suit and face to cards 

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timeShuffled);
            Console.ReadLine();

        }
        //this will shuffle the deck randomly
        //out varaible has to go before any other prarameters
        public static Deck Shuffle(Deck deck,out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            //this will shuffle deck mulitpule times
            for (int i =0;i<times;i++)

            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }

                deck.Cards = TempList;

            }
          
            return deck;
        }
        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //        deck = Shuffle(deck);
        //}
        //    return Deck;
            
    }
}
