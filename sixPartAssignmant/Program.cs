using System;
using System.Collections.Generic;


namespace sixPartAssignmant
{
    class Program
    {
        static void Main(string[] args)
        {
            //this part1 in the six part assignment
            //one dimensional array of strings

            string[] dogs = new string[5] { "Tonka", "Rude Roo", "Shooter", "Beau", "Sonresa" };
            foreach(string name in dogs)
                dogs[0] = "Tonka";
                dogs[1] = "Rude Roo";
                dogs[2] = "Shooter";
                dogs[3] = "Beau";
                dogs[4] = "Sonresa";
                dogs[4] = "Sonresa";
            {
                Console.WriteLine(dogs);
            }
       
            Console.ReadLine();
        }
    }
}
