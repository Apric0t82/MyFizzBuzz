using System;

namespace Algorithms
{
    public static class Program
    {
        public static void Main()
        {
            PrintFizzBuzz();
            PrintFizzBuzzFunctional();
        }

        static void PrintFizzBuzz()
        {
            Console.WriteLine("FizzBuzz using Imperative Programming");
            var fb = new FizzBuzzImperative();
            fb.SolveFizzBuzz(20);
            Console.WriteLine();
        }

        static void PrintFizzBuzzFunctional()
        {
            Console.WriteLine("FizzBuzz using Functional Programming");
            var fb = new FizzBuzzFunctional();
            fb.SolveFizzBuzz(100);
            Console.WriteLine();
        }
    }
}
