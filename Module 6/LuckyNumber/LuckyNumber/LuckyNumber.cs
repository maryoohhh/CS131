using System;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessNumber;

            do
            {
                Console.WriteLine("Guess the number between 1 and 10: ");
                guessNumber = Int32.Parse(Console.ReadLine());
            } while (guessNumber < 1 && guessNumber > 10);

            int LUCKY_NUM1 = 4;
            int LUCKY_NUM2 = 6;

            do
            {
                if (guessNumber == 4 || guessNumber == 6)
                {
                    Console.WriteLine("You guessed it right!");
                    break;
                }

                else if (guessNumber < 4)
                {
                    Console.WriteLine("Too low!");
                    Console.WriteLine("\nGuess the number between 1 and 10: ");
                    guessNumber = Int32.Parse(Console.ReadLine());
                }

                else if (guessNumber > 4 && guessNumber < 6)
                {
                    Console.WriteLine("Close!");
                    Console.WriteLine("\nGuess the number between 1 and 10: ");
                    guessNumber = Int32.Parse(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("Too high!");
                    Console.WriteLine("\nGuess the number between 1 and 10: ");
                    guessNumber = Int32.Parse(Console.ReadLine());
                } 
            } while(guessNumber != LUCKY_NUM1 || guessNumber != LUCKY_NUM2) ;
        }
    }
}
