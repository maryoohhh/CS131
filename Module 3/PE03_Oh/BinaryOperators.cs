using System;

namespace BinaryOperators
{
    class BinaryOperators
    {
        static void Main(string[] args)
        {
            // initializing values
            int a = 100;
            int b = 20;

            // compounding addition
            a += b;
            Console.WriteLine("The value of a is now: {0}", a);

            // compounding subtraction
            a -= b;
            Console.WriteLine("The value of a is now: {0}", a);

            // compounding multiplication
            a *= b;
            Console.WriteLine("The value of a is now: {0}", a);

            // compounding division
            a /= b;
            Console.WriteLine("The value of a is now: {0}", a);

            // compounding remainder
            a %= b;
            Console.WriteLine("The value of a is now: {0}", a);
        }
    }
}
