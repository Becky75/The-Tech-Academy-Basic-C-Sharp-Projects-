using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        //2 methods in this class constractors
        public FraudException ()
            : base(){ }
        public FraudException(string message)
            : base(message) { }
    }
}
