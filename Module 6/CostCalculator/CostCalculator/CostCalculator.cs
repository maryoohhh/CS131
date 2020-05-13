using System;

namespace CostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX = 0.084;
            const double FEE = 899.99;
            string go = "";

            do
            {
                Console.Write("Enter the retail price of a car: $");
                double carRetail = double.Parse(Console.ReadLine());

                double tax = carRetail * TAX;
                double totalPrice = carRetail + tax + FEE;

                Console.WriteLine("Retail Price: {0}", carRetail.ToString("C"));
                Console.WriteLine("Tax: {0}", tax.ToString("C"));
                Console.WriteLine("Dealer Prep Fee: {0}", FEE.ToString("C"));
                Console.WriteLine("Total Price: {0}", totalPrice.ToString("C"));

                Console.WriteLine("\nEnter 1 to exit");
                go = Console.ReadLine();
            } while (go != "1");
        }
    }
}
