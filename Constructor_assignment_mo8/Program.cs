
                using System;
                using System.Collections.Generic;
                using System.IO;


namespace Constructor_assignment_mo8
    {
        class Program
        {
            static void Main(string[] args)
            {
                const string casino = "Tally Casino";
                //this is a player entered with only a name so will have a balance of a 100, by calling a  var constractor in program.cs
                var newClass1 = new Class1("Becky");

                //prints welcome comment and can enter the player name
                Console.WriteLine("welcome to the {0}. Lets start by telling me your name.");
                //reads player name, 
                string playerName = Console.ReadLine();
            }
            
        }
    }

