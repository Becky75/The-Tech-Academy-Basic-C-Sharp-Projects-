using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assighnment_Mod4
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 Name = new Class1(); //instantiate
            //Call the method in the class, passing in two numbers.
            Name.Add1(3, 5);
            //Call the method in the class, specifying the parameters by name.
            Name.Add1(i: 3, j: 2);
            Console.ReadLine();//In the Main() method of the console app, instantiate the class.
        }       
        
    }
}
