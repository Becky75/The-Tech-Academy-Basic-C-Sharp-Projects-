using System;
using System.Collections.Generic;


namespace game21
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //operator
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            // an other way to write it- Deck deck = new Deck() { Face = "king", Suit = "spades" }; - does the same as below code
            Deck deck = new Deck();


            // //this is an emptey list 
            deck.Shuffle(3);
            ////this is how to shuffle x amount of times


            // // this is to have a suit and face to cards 

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
        //this will shuffle the deck randomly
        //out varaible has to go before any other prarameters
        
        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //        deck = Shuffle(deck);
        //}
        //    return Deck;
            
    }
}
