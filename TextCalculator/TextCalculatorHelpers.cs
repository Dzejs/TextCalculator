using System;
using System.Linq;

namespace TextCalculator
{
    public static class TextCalculatorHelpers
    {

        public static string Add(string userNumbers)
        {
            if (userNumbers == "")
                return "0";

            if (userNumbers.Last() == ',')
                throw new InvalidOperationException("Missing number in last position.");

            
            var negativeNumbers = userNumbers.Split(",")
                                             .Where(x => double.TryParse(x, out double number) && number < 0)
                                             .ToList();
            if (negativeNumbers.Count > 0)
                throw new Exception($"Negative not allowed {string.Join(',', negativeNumbers)}");

            var result = userNumbers.Split(",")
                         .Select(x =>
                         {
                             return double.TryParse(x, out double numberParsed) 
                                ? numberParsed 
                                : throw new Exception("There was a character in the string of numbers!");
                         })
                         .Sum();

            return result.ToString();
        }
    }
}
