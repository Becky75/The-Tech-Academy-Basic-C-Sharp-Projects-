using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_method_Assignment
{
    class Main_method_Class


    // this is an integer, create a math operation for this integer(addition, subtraction, etc.), then return the answer as an integer.

    {
        public int Add1(int i)
        {
            return i + 2;
        }
        // a second method to the class with the same name that will take in a decimal,
        public int Subtract2(decimal j)
        {
            int k = Convert.ToInt32(j);
            return k - 2;
        }
          
    public int String3(string k)
        {
            int r = Convert.ToInt32(k);
        return r + 4; 
        }
     
    }
}
