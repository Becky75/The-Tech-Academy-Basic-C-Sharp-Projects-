using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment_mod4
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        //Create a method with output parameters.
        {
            Class1 Math = new Class1();// instantiates class.

            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Math.Add1(num1, out num2 );
            //Call the method in the class, specifying the parameters by name.
            Console.WriteLine(num2);
            Console.ReadLine();
            //Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

        }  
    }
}
