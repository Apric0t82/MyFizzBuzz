using System;
using System.Linq;

namespace Algorithms
{
    public class FizzBuzzFunctional
    {
        public void SolveFizzBuzz(int number)
        {
            string FizzBuzz(int x) =>
                (x % 3 == 0, x % 5 == 0) switch
                {
                    (true, true) => "fizzbuzz",
                    (true, _) => "fizz",
                    (_, true) => "buzz",
                    _ => x.ToString()
                };

            Enumerable.Range(1, number)
                .Select(FizzBuzz)
                .ToList()
                .ForEach(Console.WriteLine);
            
        }
    }
}
