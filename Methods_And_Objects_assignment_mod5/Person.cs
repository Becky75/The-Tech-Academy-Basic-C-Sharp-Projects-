﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_assignment_mod5
{
    public class Person 
    {
       //give it two properties, each of data type string. One called FirstName, the other LastName.
      public List<string> Names { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”.
        
        public void ListNames()
        {
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
