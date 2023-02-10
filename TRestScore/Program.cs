// See https://aka.ms/new-console-template for more information

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);


            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
