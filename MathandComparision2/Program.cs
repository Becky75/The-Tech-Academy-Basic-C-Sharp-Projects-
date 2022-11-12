using System;

namespace Math_and_Comparision_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints title first

            string txt = "Anonymous Income Comparision Program";
            Console.WriteLine("Anonymous Income Comparision Program");


            //person1 , hourly rate and per hours/week
            // will print to screen "Annual salary of person1" and write the exact salary below it 

            Console.WriteLine  ("Please enter person1 hourly rate?");
            int HR1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine ("Hours worked?");
            int HW1 = Convert.ToInt32(Console.ReadLine());

            int total1 = (HR1 * HW1) * 52;

            Console.WriteLine("Annual salary of person1 " + total1);


            //person2 , hourly rate and per hours/week
            // will print to screen "Annual salary of person1" and write the exact salary below it 
            Console.WriteLine ("Please enter Person2 hourly rate?"); 
            int HR2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hourly Rate?");
            
            int HW2 = Convert.ToInt32(Console.ReadLine());

            int total2 =( HR2 * HW2) * 52;

           

            string annual2 = "Annual salary of person1" + total2;
            Console.WriteLine(annual2);
            Console.ReadLine();


            //then print "person1 makes more money than person2" true or false value

            Console.WriteLine("Does person1 make more then person2?");
            bool trueOrFalse = total1 > total2;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

        }

    }
}

