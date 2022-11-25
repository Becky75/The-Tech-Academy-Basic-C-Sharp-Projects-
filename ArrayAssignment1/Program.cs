using System;
using System.Collections.Generic;


namespace ArrayAssignment1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Array list
            string txt = "pick a number?, between 0 and 5";
            Console.WriteLine(txt);
            int num1 = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[6];
            numArray[0] = 35;
            numArray[1] = 40; 
            numArray[2] = 12;
            numArray[3] = 11;
            numArray[4] = 10;
            numArray[5] = 20;

            if (num1 < 0 || num1 > 5)
            {
                Console.WriteLine("you didnt pick the right number");

            }
            else
            {
                Console.WriteLine("what a great number " + numArray[num1]);
            }
             string[]array = { "hi", "e", "d", "p", "m" };
            Console.WriteLine("I pick from 0 to 4");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < 0 || num2 > 4)
            {
                Console.WriteLine("you didnt pick the right letter");

            }
            else
            {
                Console.WriteLine("what a great number" + array[num2]);
            }


            Console.WriteLine();
            Console.ReadLine();

            //this is a string list

            List<string> intList = new List<string>();

            intList.Add("What a great day");
            intList.Add("Try again");
            intList.Add("Start over");

            // add varibale to ask for user in put,if index is less then zero or if index is greater then length minus 1
            int Length = intList.Count;
            Console.WriteLine("pick a number from 0 -2");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 < 0 || num3 > Length-1)
            {
                Console.WriteLine("you didnt pick the right number");

            }
            else
            {
                Console.WriteLine("what a great number" + intList[num3]);
            }

            Console.ReadLine();

            

            //int yournum = Console.ReadLine();
        }
    }
}
