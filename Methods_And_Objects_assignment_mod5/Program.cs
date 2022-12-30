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

            Employee employee1 = new Employee() { ID = 2}; //add ID protpery. this Instantiate
            //add first name last name
            employee1.FirstName = "Billy";
            employee1.LastName = " Bob";
            
           

            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            Employee employee2 = new Employee();

     Console.WriteLine (employee1.ID == employee2.ID);

           

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Employee emp1 = new Employee();
                    emp1.ID= ()i;
                    emp1= ()j;
                    Employee.Add();
                }

                Console.ReadLine();

        }
    }
}
