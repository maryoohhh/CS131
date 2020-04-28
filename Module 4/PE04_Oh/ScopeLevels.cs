using System;

namespace ScopeLevels
{
    class Program
    // Start of class level scope
    {
        static void Main(string[] args)
        {
            // Class level declaration
            double radius = 5.0d;

            // Calling SurfaceArea method
            double area = SurfaceArea(radius);

            Console.WriteLine("Calculating Surface Area of a Circle:");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Surface Area: " + area);
            Console.ReadLine();
        }

        // Initialize SurfaceArea method to calculate surface area of a circle
        static double SurfaceArea(double rad)
        {
            // Initializing PI value
            // Method level declaration
            const double PI = 3.14159d;

            // Assuming rad is always positive value
            const bool POSITIVE = true;

            if (POSITIVE)
            {
                // Initialize power
                // Block level declaration
                const double POWER = 2.0d;

                // Calculating for area
                double calculateSA = Math.Pow(rad, POWER) * PI;
                return calculateSA;
            }
        }
    }
}
