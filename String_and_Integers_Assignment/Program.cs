using System;



namespace String_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> (new int[]{"6","7", "8","10"};
            Console.WriteLine(numbers);



            try
            {
                Console.WriteLine("pick a number?");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" pick a secound number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divded by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");
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
