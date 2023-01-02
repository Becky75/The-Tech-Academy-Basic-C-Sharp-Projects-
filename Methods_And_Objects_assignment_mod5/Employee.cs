using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_assignment_mod5
{
    //Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
    // interface file added to the inherated class  
    
    //Employee class with a generic type parameter. 

    public class Employee<T> //: IQuittable
    {
       
        //Add a property called “things” and have its data type be a generic list matching the generic type of the class
        public List<T> Things { get; set;}
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
 
    //Bool comparison operator overload 
    //static method
    //public bool Employee { get; set; }

    //public bool operator ==(Employee emp1, Employee emp2)
    //{
    //    if (emp1==emp2)
    //    {
    //        return emp1;
    //        Console.WriteLine();    
    //    }
    //    else
    //    {
    //        Console.WriteLine("true");
    //    }

    //}

    //public bool operator != (Employee emp1, Employee emp2)
    //{
    //    if (emp1!=emp2)
    //    {
    //        return emp2;
    //        Console.WriteLine();
    //    }
    //    else
    //    {
    //        Console.WriteLine("false");
    //    }

}

        //void IQuittable.Quit() { Console.WriteLine("i quit"); }
    //}

     
  
}


