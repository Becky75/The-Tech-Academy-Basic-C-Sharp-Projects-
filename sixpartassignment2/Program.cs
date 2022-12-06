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

    //this is second part comparision <= loop operator
            for (int b=0; b<=10; b=b +2)
            {
                Console.WriteLine(b);
            }
            //part4 each item in the list is unque.
            
                List<string> animals= new List<string>{ "dog", "cat", "bird", "horse", "fish" };
            Console.WriteLine("Pick an animal?");
            string userinput = Console.ReadLine();
            
            for (int i = 0; i < animals.Count ; i++)
            {
                if (animals[i] == userinput)
                {
                    Console.WriteLine("You picked" + animals[i]);
                } 
                else if (animals[i] != userinput )
                        {
                    Console.WriteLine("please pick from list ");
                         }

                //part 5 of part 6 assignment list string adn have teo identical strings the same
                List<string> elements = new List<string> { "Fire", "Earth", "Wind", "Water", "Water" };
               foreach(string name in elements)
                {
                    Console.WriteLine(name);
                }

                    Console.WriteLine("pick an element?");
                string user = Console.ReadLine();
                Console.WriteLine(elements[j]);
                
                // this is a loop 

                for (int j = 0; j < elements.Count; j++)
                {
                    if (elements[j] == user)
                    {
                        Console.WriteLine("there are 2 water elements");
                    }
                    else if (elements[j] != user)
                    {
                        Console.WriteLine(" try from the list");
                    }
                    Console.ReadLine();
                }
            }       

        }
    }
}
