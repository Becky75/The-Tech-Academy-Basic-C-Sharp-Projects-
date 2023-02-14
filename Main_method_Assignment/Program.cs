using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1.Create a class. In that class, create a method that will take in an integer, create a math operation for this integer(addition, subtraction, etc.), then return the answer as an integer.

            Main_method_Class obj1= new Main_method_Class();
            int i = 2;


            //2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer.Display the result to the screen.
            //this will show answer
            Console.WriteLine(obj1.Add1(i));

            Console.ReadLine();


            // a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
            Main_method_Class obj2 = new Main_method_Class();
            decimal j = 4.5m;


            //4.In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine(obj2.Subtract2(j));

            Console.ReadLine();

            //5.Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.

            // this is creating a data type object
            Main_method_Class obj3 = new Main_method_Class();
            string k = "4";
            
           
            //this will show answer
            Console.WriteLine(obj3.String3(k));

            Console.ReadLine();
            //6.In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.


        }
    }
}
