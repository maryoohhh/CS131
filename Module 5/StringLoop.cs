using System;

namespace StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chickenIngredients = new string[] {
                "chicken wings",
                "salt",
                "pepper",
                "potato starch",
                "oil",
                "soy sauce",
                "mirin",
                "sugar",
                "sake",
                "garlic"
            };

            Console.WriteLine("The ingredients are:");

            for (int i = 0; i < chickenIngredients.Length; i++)
            {
                Console.WriteLine(chickenIngredients[i]);
            }
        }
    }
}
