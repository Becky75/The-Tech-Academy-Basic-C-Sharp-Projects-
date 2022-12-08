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
                int[] num1 = { 8, 4, 9 };

                foreach (int i= 0; i < num1.Length; i++)
                {
                Console.WriteLine("choose a numbers 8,4,9");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("now to divide the two....");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + " divide by " + num2 + " equals " + num3);
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
