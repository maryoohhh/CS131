using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing variables
            int num1 = 77;
            float num2 = 22.25f;
            string num3 = "Value 100";

            // Casting float num2 to integer
            int num2ToInt = (int)num2;

            // Printing outputs of each variable
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num2ToInt);
        }
    }
}
