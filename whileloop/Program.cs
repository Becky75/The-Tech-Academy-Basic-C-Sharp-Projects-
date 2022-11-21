using System;
using System.Text;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("guess an age?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = number == 45;

            do
            {


                switch (number)
                {
                    case 43:
                        Console.WriteLine("you guessed 43.try again");
                        Console.WriteLine("next guess?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 35:
                        Console.WriteLine("you guessed 35 young.try again,just older.");
                        Console.WriteLine("so close guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("55 still wrong");
                        Console.WriteLine("try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 45:
                        Console.WriteLine("45 is correct!");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                        //            this is my name and a quote
                        //string name = "Becky";
                        //string quote="A friend said,\\I love my free time\",Becky.\n me to";

                        ////this changes everything to upper case
                        //name = name.ToUpper();


                        //StringBuilder sb = new StringBuilder();
                        //sb.Append("The day is cold but the sun is shining");

                        //Console.WriteLine(name);
                        //Console.WriteLine(quote);
                }
            }
            while (!guess);

                        Console.Read();
            
        }
    }
}

