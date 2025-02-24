using System;

namespace Algorithms
{
    public class FizzBuzzImperative
    {
        public void SolveFizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
        }

        private static string FizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                return "fizz";
            }
            else if (i % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}
