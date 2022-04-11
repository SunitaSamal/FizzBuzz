using System;

/// <summary>
/// Write a C# console application that accepts an integer i, and prints an output based on the following:
/// i is divisible by 3	Print Fizz
/// i is divisible by 5 Print Buzz
/// i is divisible by both 3 and 5	Print FizzBuzz
/// i is not divisible by 3 or 5	Print the value of i
/// Write unit tests. i could take any legal integer value.
/// </summary>
namespace FizzBuzz
{
    public class FizzBuzzOuput
    {
        static void Main(string[] args)
        {
            string inputText = string.Empty;
            int inputNumber = 0;

            do
            {
                Console.WriteLine("Enter a valid number to continue : ");

                inputText = Console.ReadLine();

                if (int.TryParse(inputText, out inputNumber))
                {
                    Console.WriteLine(GetFizzBuzzOutput(inputNumber));
                }
                 
            } while (!string.IsNullOrWhiteSpace(inputText) && inputNumber > 0);
            
        }

        /// <summary>
        /// Based on input number i,
        /// Print Fizz if i is divisible by 3	
        /// Print Buzz if i is divisible by 5  
        /// Print FizzBuzz if i is divisible by both 3 and 5	 
        /// Print the value of i if i is not divisible by 3 or 5	
        /// </summary>
        /// <param name="number">The integer number to get output Fizz or Buzz or FizzBuzz or the number itself</param>
        /// <returns>Fizz or Buzz or FizzBuzz or the input number</returns>
        public static string GetFizzBuzzOutput(int number)
        {
            string output;

            if ((number % 3 == 0) && (number % 5 == 0))
            {
                output = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                output = "Fizz";
            }
            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }

            return output;
        }
    }
}
