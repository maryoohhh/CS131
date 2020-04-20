using System;

namespace Expressions
{
    class Expressions
    {
        static void Main(string[] args)
        {
            // initializing values
            int a = 100;
            int b = 20;

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
