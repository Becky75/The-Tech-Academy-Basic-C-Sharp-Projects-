using System;
using System.Collections.Generic;


namespace sixpartassignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is part 4,a unqigue values
            List<string> homes = new List<string>()
          { "Rancher","Farm","Condo","Appartment","Two story","Barn"};
            for(int i=0; i< homes.Length ;i++ )

            {
                Console.WriteLine(homes);
                    }
            
            Console.ReadLine();
        }
    }
}
