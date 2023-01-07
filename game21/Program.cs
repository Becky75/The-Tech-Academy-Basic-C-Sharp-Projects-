using System;
using System.Collections.Generic;


namespace game21
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints welcome comment and can enter the player name
            Console.WriteLine("welcome to the Grand Hotel and Casino. Lets start by telling me your name.");
            //reads player name, 
            string playerName = Console.ReadLine(); 
            
            // asks and enters amount of money           
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());            
           
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            //this allows for different answers 
            string answer = Console.ReadLine().ToLower();
           
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //this is a constructor
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                //adds player
                game += player;
                player.isActivelyPlaying = true;
                //this keeps player playing as long as playing amd has a balance greater then zero
                while (player.isActivelyPlaying && player.Balance >0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino, Bye for now");

            Console.ReadLine();

            
            
            
            
            
            
            
            //operator
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            //// an other way to write it- Deck deck = new Deck() { Face = "king", Suit = "spades" }; - does the same as below code
            //Deck deck = new Deck();


            //// //this is an emptey list 
            //deck.Shuffle(3);
            //////this is how to shuffle x amount of times


            //// // this is to have a suit and face to cards 

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

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
