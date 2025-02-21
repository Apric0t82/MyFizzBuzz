using System;
using System.Linq;

namespace Algorithms
{
    public class FizzBuzzFunctional
    {
        public void SolveFizzBuzz(int number)
        {
            var results = Enumerable.Range(1, number)
                .Select(i => (i % 3 == 0 && i % 5 == 0) ? "fizzbuzz" :
                             (i % 3 == 0) ? "fizz" :
                             (i % 5 == 0) ? "buzz" :
                             i.ToString());

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
