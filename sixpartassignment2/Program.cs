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

            for (int i = 0; i < horses.Length; i++)
            {
                Console.WriteLine(horses[i]);
            }

            //this is second part comparision <= loop operator
            for (int b = 0; b <= 10; b = b + 2)
            {
                Console.WriteLine(b);
            }
            //part4 each item in the list is unque.

            List<string> animals = new List<string> { "dog", "cat", "bird", "horse", "fish" };
            Console.WriteLine("Pick an animal?");
            string userinput = Console.ReadLine();

            foreach (string j in animals)
            {
                if (j == userinput)
                {
                    Console.WriteLine(userinput + " is found at index " + j);
                }

            }
            if (!animals.Contains(userinput))
            {
                Console.WriteLine(" try from the list");
            }

            Console.ReadLine();
        
    
            //part 5 of part 6 assignment list string adn have teo identical strings the same
            List<string> elements = new List<string>() { "Fire", "Earth", "Wind", "Water", "Water" };
            foreach (string name in elements)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("pick an element?");
            string user = Console.ReadLine();

            // this is a loop 

            foreach (string j in elements)
            {
                if (j == user)
                {
                    Console.WriteLine(user + " is found at index " + j);
                }
                  
            }
            if (!elements.Contains(user))
                {
                    Console.WriteLine(" try from the list");
                }
                    
            Console.ReadLine();

        


            //part 6 of 6 looking for duplicates
            List<string> letters = new List<string>() { "A", "B", "C", "D", "A" };
            List<string> template = new List<string>();
            foreach (string k in letters)
            {
                if (template.Contains(k))
                {
                     
                        Console.WriteLine("{0} this is a duplicate", k);                   
                }
                 else 
                {
                    Console.WriteLine(k + " this is unique");
                }
                template.Add(k);

            }

            Console.ReadLine();
        }
    }
}
