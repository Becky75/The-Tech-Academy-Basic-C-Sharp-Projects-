using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Assignmentmod7
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(2023, 5, 23, 8, 32 45);
            DateTime yearOfBirth = new DateTime(1975, 9, 6, 32, 45, 11);
            DateTime yearOfGraduation = new DateTime(2012, 6, 3, 34, 22, 11);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;  
        }
    }
}
