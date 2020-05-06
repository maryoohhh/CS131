using System;

namespace WarnLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input for desired water temperature
            Console.WriteLine("Enter the desired water temperature (F):");
            int temperature = Convert.ToInt32(Console.ReadLine());

            // Takes user input if they are sure or not
            // Assumes all users will only put true or false. Otherwise, code will break
            Console.WriteLine("Are you sure you want to continue? (true or false):");
            bool toContinue = Convert.ToBoolean(Console.ReadLine());

            // Calling method WaterTemp
            WaterTemp(temperature, toContinue);
        }

        // Initializing WaterTemp method
        public static void WaterTemp(int temperature, bool toContinue)
        {
            // Conditional statement for supercooled water
            if (temperature == -55 && toContinue == true)
            {
                Console.WriteLine("Warning: Water reached supercooled state!");
            }

            // Conditional statement for below freezing point
            else if (temperature < 32 && toContinue == true)
            {
                Console.WriteLine("Warning: Temperature is below freezng point of water!");
            }

            // Conditional statement for above boiling point
            else if (temperature > 212 && toContinue == true)
            {
                Console.WriteLine("Warning: Temperature is above boiling point of water!");
            }

            // Conditional statement if user does not want to continue
            else if (toContinue == false)
            {
                Console.WriteLine("Okay, bye bye!");
            }

            // Default message
            else
            {
                Console.WriteLine("No warning.");
            }
        }
    }
}
