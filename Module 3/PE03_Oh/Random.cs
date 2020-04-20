using System;

namespace Random
{
    class Random
    {
        static void Main(string[] args)
        {
            // initializing limits
            const int MIN = 1;
            const int MAX = 100;

            // initializing RNG
            System.Random rnd = new System.Random();
            int a = rnd.Next(MIN, MAX);
            int b = rnd.Next(MIN, MAX);

            // addition
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            // subtraction
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);

            // multiplication
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            // division
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            // remainder
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}
