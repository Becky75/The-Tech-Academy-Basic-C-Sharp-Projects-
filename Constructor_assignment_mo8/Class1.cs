using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_assignment_mo8
{
    public class Class1

    {
        // this is a parameter that inheits a previous constractor. it asignsthe 100 if there isnt an amount entered
        public Class1(string name) : this(name, 100)
        {

        }
        public Class1(string name, int beginningBalance)
        {

          
        }
    }
}