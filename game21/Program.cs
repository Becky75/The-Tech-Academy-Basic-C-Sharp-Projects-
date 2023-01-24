using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;


namespace game21
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Tally Casino";




            //this is a player entered with only a name so will have a balance of a 100, by calling a  var constractor in program.cs
            //var newPlayer = new Player("Becky");

            //prints welcome comment and can enter the player name
            Console.WriteLine("welcome to the {0}. Lets start by telling me your name.");
            //reads player name, 
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin") ;
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + "|");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("please enter digits only, no decimals");
            }
            // asks and enters amount of money           
            // Console.WriteLine("And how much money did you bring today?");
            // int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            //this allows for different answers 
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //this is a constructor
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                using (StreamWriter file = new StreamWriter(@"C:\users\alpac\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                //adds player
                game += player;
                player.isActivelyPlaying = true;
                //this keeps player playing as long as playing amd has a balance greater then zero
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdatedDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured,contact the administrator");
                        UpdatedDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino, Bye for now");

            Console.ReadLine();
        }
        private static void UpdatedDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"INSERT INTO EXCEPTIONS(@ExceptionType,@ExceptionMessage, @TimeStamp) VALUES
                                 (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage,TimeStamp From Exceptions";
            
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);

                }
                connection.Close();
                
            }
            return Exceptions;
        }

    }
}











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


        

        //this will shuffle the deck randomly
        //out varaible has to go before any other prarameters
        
        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //        deck = Shuffle(deck);
        //}
        //    return Deck;
            
    

