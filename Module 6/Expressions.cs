using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            
            // Asking for user input and storing it
            Console.Write("Enter a number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Int32.Parse(Console.ReadLine());

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
