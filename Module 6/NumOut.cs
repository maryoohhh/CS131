using System;

namespace NumOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize double variable called num
            double num = 987654.321d;

            // Prints out the original value of num
            Console.WriteLine("Double: " + num);
            // Rounds off value of num to two decimal places
            Console.WriteLine("Truncate to two decimal: " + Math.Round(num, 2));
            // Converts double num to int
            Console.WriteLine("Integer: " + Convert.ToInt32(num));
            // Prints out double num to currency format
            Console.WriteLine("Currency: " + num.ToString("C"));
        }
    }
}
