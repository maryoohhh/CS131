using System;

namespace TempConverter
{
    class Program
    {

        static double TempConverter(double temperature)
        {
            double c = (temperature - 32) * 5 / 9;
            return c;
        }

        static void ShowConvertedTemp(double fahrenheit, double celcius)
        {
            Console.WriteLine("{0}F = {1}C", fahrenheit, celcius);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Double.Parse(Console.ReadLine());

            double celcius = TempConverter(fahrenheit);
            ShowConvertedTemp(fahrenheit, celcius);
            Console.Read();
        }
    }
}
