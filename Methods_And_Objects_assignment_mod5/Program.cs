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
         
            //initialize an Employee object with a first name of “Sample” and a last name of “Student”.

            Employee employee1 = new Employee();  //instantiate
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            IQuittable employee2 = new Employee();
            employee2.Quit();
            //Call the superclass method SayName() on the Employee object.
            employee1.SayName();
            Console.ReadLine();

        }
    }
}
