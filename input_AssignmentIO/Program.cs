﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is for  current date and time
            Console.WriteLine("Current Date and Time");
            DateTime now = DateTime.Now;
            //this will log text to a file and date and time it was entered
            Console.WriteLine("Pick a number?");
            string text = File.ReadAllText(@"C:\Users\alpac\Documents\log.txt");
            File.WriteAllText(@"C:\Users\alpac\Documents\log.txt", "event time");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(now);
            Console.ReadLine();
        }
    }
}
