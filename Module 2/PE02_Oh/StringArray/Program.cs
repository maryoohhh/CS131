using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing array containing pizza types
            string[] pizzaType = new string [] {
                "Hawaiian",
                "BBQ Meatlovers",
                "Bacon & Mushroom",
                "Pepperoni"
            };

            // Print output number of array elements
            Console.WriteLine(
                "There are " + pizzaType.Length + " types to choose from.");
            Console.ReadLine();

            // Print output sorted element values
            Array.Sort(pizzaType);
            Console.WriteLine(pizzaType[0] + ", "
                              + pizzaType[1] + ", "
                              + pizzaType[2] + ", "
                              + pizzaType[3]);
            Console.ReadLine();
        }
    }
}
