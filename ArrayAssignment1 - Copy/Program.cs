using System;
using System.Collections.Generic;


namespace ArrayAssignment1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Array list
            string txt = "pick a number?, 35,40,12,11,10,20";
            Console.WriteLine(txt);
            string num1 = Console.ReadLine();

            int[] numArray = new int[6];
            numArray[0] = 35;
            numArray[1] = 40; 
            numArray[2] = 12;
            numArray[3] = 11;
            numArray[4] = 10;
            numArray[5] = 20;

            
            Console.WriteLine();
            Console.ReadLine();

            //this is a string list

            List<string> intList = new List<string>();
            intList.Add("What a great number");
            intList.Add("that number isnt in the list,try again!");

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            //int yournum = Console.ReadLine();
        }
    }
}
