using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_assignment_mod5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Call the superclass method SayName() on the Employee object.

            Employee ListNames = new Employee();  //instantiate
            ListNames.FirstName = new List<string>() { "Bob", "Joe", "Janet" };
            ListNames.ListNames();
            Console.ReadLine();
            //initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee employee = new Employee();




        }
    }
}
