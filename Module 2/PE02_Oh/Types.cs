using System;

namespace Types
{
    class Types
    {
        static void Main(string[] args)
        {
            // Initializing variables
            int intNumber = 77;
            float floatNumber = 22.25f;
            string stringValue = "Value 100";

            // Casting float num2 to integer
            int floatNumberToInt = (int)floatNumber;

            // Printing outputs of each variable
            Console.WriteLine(intNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(stringValue);
            Console.WriteLine(floatNumberToInt);
        }
    }
}
