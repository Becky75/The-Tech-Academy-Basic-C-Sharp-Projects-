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
            Console.WriteLine("Pick a number?");
            string text = File.ReadAllText("@C:\Users\alpac\Documents\log.txt");
            File.WriteAllText("@C:\Users\alpac\Documents\log.txt");
            int i = Convert.ToInt32(Console.ReadLine());

        }
    }
}
