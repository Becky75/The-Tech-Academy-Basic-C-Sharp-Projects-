using System;
using System.Collections.Generic;


namespace sixpartassignment2
{
    class Program
    {
        static void Main(string[] args)
            //this is part 3, comparision < loop operator
        {
            string[] horses = { "Arab", "Mustang", "Paint", "Gypsies" };
            for (int i = 0; i < horses.Length ; i++)
            {
                Console.WriteLine(horses[i]);
            }

            //this is second part comparision <=loop operator
            for (int b=0; b<=10; b=b +2)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
    }
}
