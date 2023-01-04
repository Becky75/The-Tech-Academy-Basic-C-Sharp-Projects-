using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_assignment_mod6
{
    class Program
    {
        static void Main(string[] args)

        {
            //this is a try/catch
            try
            {
                //this is a enum for the days of the week
                DaysOfTheWeek Day = DaysOfTheWeek.Monday;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Please enter an actual day of the week.");
           
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wensday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
       DaysOfTheWeek Day=(DaysOfTheWeek) Enum.Parse(typeof(DaysOfTheWeek), Day);
        Console.WriteLine("You entered" + Day + " and that is a great day of the week!");
       Console.ReadLine();
    }
     
 }

