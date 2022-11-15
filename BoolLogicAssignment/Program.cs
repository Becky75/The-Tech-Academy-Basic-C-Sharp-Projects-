using System;

namespace BoolLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

         //these are the guessing to help decide the end result
            Console.WriteLine("Whats your age?");
            int age = 16;
            bool oldEnough = (age > 15);

            //this a trueOrFalse question.

            Console.WriteLine("Have you ever had a DUI?");
            bool dui=(true==false);

            //this is a greater then comparision 'do they have over 3 tickets' 

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = 3;

            //this is a bool "do they Qualifie?
            Console.WriteLine("Qualified?");
            bool Qualified = (ticket > 3 && age > 15);
            Console.WriteLine("You Qualify!");
            
        }
    }
}
