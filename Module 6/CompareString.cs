using System;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input and stores it in FirstWord
            Console.WriteLine("Enter a word: ");
            string FirstWord = Console.ReadLine();

            // Takes user input and stores it in SecondWord
            Console.WriteLine("Enter another word: ");
            string SecondWord = Console.ReadLine();

            // Returns and prints boolean if two words match
            // Compares and ignores case
            Console.WriteLine("Words match? {0}", string.Compare(FirstWord, SecondWord, true) == 0 ? "true" : "false");
        }
    }
}
