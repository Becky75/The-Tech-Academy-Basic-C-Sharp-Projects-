using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method of the console app, instantiate the class.


            //Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

            //Call the method in the class, passing in the one or two numbers entered.

            Class1 obj1 = new Class1();
            Console.WriteLine("pick two numbers, one at a time First number is?");
            int user = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("if you would like pick a second number");

            string user2 = Console.ReadLine();
            { 
                if(user2 == "")
                {
                    //call the method with only the users first number passed in
                    Console.WriteLine(obj1.mathOperation(user));
                }
                else
                    {
                    //convert the user'e second input to in integer
                    //call the method with both of the users numbers passed in.
                    int user3 = Convert.ToInt32(user2);
                    Console.WriteLine(obj1.mathOperation(user, user3));
                }
            }
            
           
            Console.ReadLine();

        }
       


        //Try various combinations of numbers on the code, including having no second number.


}
}
