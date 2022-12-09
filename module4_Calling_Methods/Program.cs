using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is creating a data type object
            Class1 class1 = new Class1();
            //asking user for input
            Console.WriteLine("pick a number?");
            //save user input
            int user = Convert.ToInt32(Console.ReadLine());
            //this will show answer
            Console.WriteLine(class1.num1(user) + " , " + class1.num2(user) + " , " + class1.num3(user));
           
            Console.ReadLine();

        }
    }
}
