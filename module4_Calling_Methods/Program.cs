using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is creating a data type object
            Dogs dogs = new Dogs();
            dogs.Dogs = new List<Dogs>();
            //this will add 1 dog to list

            dogs.Dogs.Add(dogOne);
            //this creates a new object, without values
            Dogs dogOne = new Dogs();
            dogOne.Dogs = "Heeler";
            dogOne.Many = "1";


            //this will asign some values
            dogOne.Many = "1";
            dogOne.Dogs = "Heeler";


            Console.WriteLine(dogOne.Many = " of " + dogOne.Dogs);
            Console.ReadLine();
            //methods of numbers shuffled


        }
    }
}
