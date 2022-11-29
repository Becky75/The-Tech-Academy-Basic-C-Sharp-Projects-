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

           string [] dogs = { "Tonka ", "Rude Roo ", "Shooter ", "Beau ", "Sonresa " };
            //this is first loop
            Console.WriteLine("Please enter some txt?");
           
            string cat = Console.ReadLine();

            for (int i = 0; i < dogs.Length; i++)

            {

                dogs[i] = dogs[i] + cat;
                Console.WriteLine(dogs[i]);

            }
                Console.ReadLine();

            //part2 this is an infintity loop
             
            while (true)
            {
                // this will br printed
                Console.WriteLine("Got to love dogs");

            }
            }
        }
    }
