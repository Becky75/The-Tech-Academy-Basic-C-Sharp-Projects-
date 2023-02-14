using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_mod6
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.

                List<Employee> EmpList = new List<Employee>() {
                    new Employee() { ID = 0, FirstName = "Joe", LastName = "Lee" },
                    new Employee() { ID = 1, FirstName = "Linda", LastName = "Lou" },
                    new Employee() { ID = 2, FirstName = "Bob", LastName = "Brown" },
                    new Employee() { ID = 3, FirstName = "Tom", LastName = "Lee" },
                    new Employee() { ID = 4, FirstName = "Kaitlyn", LastName = "Bonnet" },
                    new Employee() { ID = 5, FirstName = "John", LastName = "Ease" },
                    new Employee() { ID = 6, FirstName = "Danny", LastName = "Chow" },
                    new Employee() { ID = 7, FirstName = "Daryl", LastName = "Larry" },
                    new Employee() { ID = 8, FirstName = "Joan", LastName = "Arch" },
                    new Employee() { ID = 9, FirstName = "Joe", LastName = "Blow" } };


                //Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
                List<Employee> g = new List<Employee>();

                foreach (Employee emp in EmpList)
                {

                    if (emp.FirstName == "Joe")
                    {
                        g.Add(emp);
                        Console.WriteLine("this is Joe");
                    }
                }
                // Perform the same action again, but this time with a lambda expression.
                List<Employee> EmpList2 = EmpList.Where(x => x.FirstName == "Joe").ToList();
                // Using a lambda expression, make a list of all employees with an Id number greater than 5.

                List<Employee> EmpList3 = new List<Employee>();

                foreach (Employee emp in EmpList3)
                {

                    if (emp.ID > 5)
                    {
                        EmpList3.Add(emp);
                    }
                    Console.WriteLine();
                }
                List<Employee> empList3 = EmpList.Where(k => k.ID > 5).ToList();
            }
        }
    }
}
