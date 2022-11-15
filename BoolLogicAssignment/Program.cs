using System;

namespace BoolLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

         //these are the guessing to help decide the end result
            Console.WriteLine("Whats your age?");
            int age = Convert.ToInt32(Console.ReadLine());
           

            //this a trueOrFalse question.

            Console.WriteLine("Have you ever had a DUI?");
            bool dui =Convert.ToBoolean(Console.ReadLine());

            //this is a greater then comparision 'do they have over 3 tickets' 

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            //this is a bool "do they Qualifie?
            Console.WriteLine("Qualified!");
            bool Qualified = (ticket <= 3 && age > 15 && !dui);
           
            
        }
    }
}
