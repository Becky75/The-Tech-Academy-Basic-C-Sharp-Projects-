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

            string[] Employee = { "bob", "billy", "Daryl" };
            //initialize an Employee object with a first name of “Sample” and a last name of “Student”.

            
            Employee<string>empObject = new Employee<string>();
            empObject.Things = new List<string>() { 
            
            "Bob",
            "Billy",
            "Daryl"};

           foreach (string Item in empObject.Things)
            {
                Console.WriteLine(Item);  
            }



            int[] array = { 3, 5, 6 };
            //initialize an Employee object with a first name of “Sample” and a last name of “Student”.


            Employee<int> empItem = new Employee<int>();
            empItem.Things = new List<int>() {

            3,
            5,
            6};

            foreach (int Item in empItem.Things)
            {
                Console.WriteLine(Item);
            }
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Employee empObject = new Employee();
            //        emp1.ID= ()i;
            //        emp1= ()j;
            //        Employee.Add();
            //    }

            Console.ReadLine();

        }
    }
}
