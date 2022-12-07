using System;


namespace Consoleassignment_module3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {

                Console.WriteLine("choose a numbers 8,4,9");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("pick anouther number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("now to divide the two....");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + " divide by " + num2 + " equals ");
                Console.ReadLine();
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
