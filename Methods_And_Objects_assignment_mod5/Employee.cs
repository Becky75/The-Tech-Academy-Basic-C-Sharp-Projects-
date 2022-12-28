using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_assignment_mod5
{
    //Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
    // interface file added to the inherated class  
    public class Employee : IQuittable
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Bool comparison operator overload 
        //static method

        //this is an equals operator,with if and else statment 
        static public bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.ID==emp2.ID)
            {
               
                Console.WriteLine();
                return true;
            }
            else
            {
                
                Console.WriteLine();
                return false;
            }

        }
        //this is an not equal operator, with an if and esle statment
        static public bool operator!= (Employee emp1, Employee emp2)
        {
            if (emp1.ID!=emp2.ID)
            {
               
                Console.WriteLine();
                return true;
            }
            else
            {
               
                Console.WriteLine("false");
                return false;
            }

        }

        void IQuittable.Quit() { Console.WriteLine("i quit"); }
    }

     
  
}


