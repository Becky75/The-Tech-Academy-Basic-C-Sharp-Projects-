using System;

namespace Math_and_Comparision_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
         //prints title first

            string txt = "Anonymous Income Comparision Program";
            Console.WriteLine(txt);


            //person1 , hourly rate and per hours/week
            // will print to screen "Annual salary of person1" and write the exact salary below it 

            string person1 = "Person1";
            
            string hourlyRate1 = "Hourly Rate?";

            int HR1 = Convert.ToInt32(Console.ReadLine());
            int HW1 = Convert.ToInt32(Console.ReadLine());

            int total1 = HR1 + HW1;

            Console.WriteLine(total1);

            string annual = "Annual salary of person1" + total1;


         //person2 , hourly rate and per hours/week
         // will print to screen "Annual salary of person1" and write the exact salary below it 
            string person2 = "Person2";

            string hourlyRate2 = "Hourly Rate?";

            int HR2 = Convert.ToInt32(Console.ReadLine());
            int HW2 = Convert.ToInt32(Console.ReadLine());

            int total2 = HR2 + HW2;

            Console.WriteLine(total2);

            string annual2 = "Annual salary of person1" + total2;
            Console.ReadLine();


            //then print "person1 makes more money than person2" true or false value

            bool trueOrFalse = addition1 > addition2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();


        }
    }
