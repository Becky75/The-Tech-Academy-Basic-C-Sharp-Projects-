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

        //Create an Employee class with the following properties: ID,First name, Last name 
        // In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.

        var Employee = new List<Employee>() {
            new Employee (){ ID = 0, FirstName= "Joe", LastName = "Lee" },
            new Employee () { ID = 1,FirstName="Linda", LastName = "Lou" }
            new Employee () { ID = 2, FirstName = "Bob", LastName = "Brown" }
            new Employee () {ID = 3, FirstName = "Tom", LastName = "Lee" } 
            new Employee () {ID = 4, FirstName = "Kaitlyn", LastName = "Bonnet" }
            new Employee () {ID = 5, FirstName = "John", LastName = "Ease" }
            new Employee () {ID = 6, FirstName = "Danny", LastName = "Chow" }
            new Employee () {ID = 7, FirstName = "Daryl", LastName = "Larry" }
            new Employee () { ID = 8, FirstName = "Joan", LastName = "Arch" }
            new Employee () { ID = 9, FirstName = "Joe", LastName = "Blow" };

       
        //Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.

        foreach (List "Joe" in Employee )
            {
            Console.WriteLine("Joe");
            }
       // Perform the same action again, but this time with a lambda expression.
       Func<Employee, "Joe"> = x => x.FirstName == "Joe" 
        Using a lambda expression, make a list of all employees with an Id number greater than 5.

        Func<Employee, Bool> Employee = k => k.Id > 5
        
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


