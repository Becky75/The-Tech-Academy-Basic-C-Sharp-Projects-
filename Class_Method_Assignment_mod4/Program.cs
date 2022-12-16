using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment_mod4
{
    class Program
    {
        static void num1(string []args)
        {
            Console.WriteLine("Pick a number.");
        }
        static void Main(string[] args)
        //Create a method with output parameters.
        {
            Class1 Math = new Class1();// instantiates class.

            Math.Add1( 2);
            //Call the method in the class, specifying the parameters by name.

            Console.ReadLine();
            //Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            //Overload method.
            num1(4);
            num1(6);
            num1(2);
            num1(5);
        }
                
            

           
        
    }
}
