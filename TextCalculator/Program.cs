using System;

namespace TextCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a string of numbers:");
                string numbers = Console.ReadLine();

                Console.WriteLine(TextCalculatorHelpers.Add(numbers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
