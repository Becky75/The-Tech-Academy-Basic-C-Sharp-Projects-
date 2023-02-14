using System;


namespace Consoleassignment_module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(8, 16, 24);
            //Console.WriteLine(Convert.ToInt32)
            try
            {
                int[] numarray = { 8, 4, 9 };
                Console.WriteLine("choose a numbers..");
                int num1 = Convert.ToInt32(Console.ReadLine());

                foreach (int i in numarray)
                {
                    Console.WriteLine(i / num1);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
         

          
                
        }
    }
}
