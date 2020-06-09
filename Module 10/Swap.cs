using System;

namespace Swap
{
    class MainClass
    {
        // Static generic method called swap
        // Takes two reference parameters called 'a' and 'b'
        static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

            // Output the values
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Main(string[] args)
        {
            // Initialize 4 variables - two int and two strings
            int num1 = 10;
            int num2 = 15;
            string string1 = "hello";
            string string2 = "bye";

            // Calling swap method to pass the 2 int var
            swap<int>(ref num1, ref num2);
            // Calling swap method to pass the 2 string var
            swap<string>(ref string1, ref string2);
        }
    }
}
