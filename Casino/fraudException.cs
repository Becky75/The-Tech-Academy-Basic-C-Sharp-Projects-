using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class fraudException : Exception
    {
        //2 methods in this class constractors
        public fraudException ()
            : base(){ }
        public fraudException(string message)
            : base(message) { }
    }
}
