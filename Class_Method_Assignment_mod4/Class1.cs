using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment_mod4
{
    class Class1
    {
        //create a void method that outputs an integer.Have the method divide the data passed to it by 2.
        public void Add1(int i, out int j)
        {
           //since int has already been declared,we just need to reference it as i 
           
           j= i / 2;
           
            
            Console.WriteLine(j);//since k has the value of i/2, we can just use k
        }

        public string Add1(out int k )
        {
            //this is anouther out put parameters
            k = 2 / 2;

           return ("one plus one equals two");
            
        }
        
    }
}
