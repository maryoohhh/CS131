using System;

namespace GoOrQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            // Loop will continue to run until user says no
            while (runProgram)
            {
                Menu();
                string option = Console.ReadLine();

                // Loop breaks if user says no
                if (option == "n")
                {
                    Console.WriteLine("Okay, bye bye!");
                    break;
                }

                // Call StudentGrade method if user says yes
                else if (option == "y")
                {
                    Console.WriteLine("Enter the student's percentage grade: ");
                    int percentageGrade = Convert.ToInt32(Console.ReadLine());

                    StudentGrade(percentageGrade);
                }

                // Asks user to re-enter input if response was not y or n
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        // Asks user input if they want to re/run the program
        public static void Menu()
        {
            Console.WriteLine("Do you want to run the program (y or n): ");
        }

        // Initializing method if user decides to run the program
        static void StudentGrade(int percentageGrade)
        {
            // Iterating loop until user inputs an argument that satisfies a condition
            while (true)
            {
                // Loop to check if user input is within range
                if (0 <= percentageGrade && percentageGrade <= 100)
                {
                    // Condition to check if student is in excellent standing
                    if (90 <= percentageGrade && percentageGrade <= 100)
                    {
                        Console.WriteLine("Student passed the class in excellent standing.");
                        break;
                    }

                    // Condition to check if student is in good standing
                    else if (78 <= percentageGrade && percentageGrade < 90)
                    {
                        Console.WriteLine("Student passed the class in good standing.");
                        break;
                    }

                    // Condition to check if student is borderline pass
                    else if (70 <= percentageGrade && percentageGrade < 78)
                    {
                        Console.WriteLine("Student passed the class, but needs to work harder next time.");
                        break;
                    }

                    // Default message when student's grade is below passing grade
                    else
                    {
                        Console.WriteLine("Student failed, must retake the class.");
                        break;
                    }
                }

                // Default message if user input is outside of 0-100 percent
                // Asks user to re-enter a valid input
                else
                {
                    Console.WriteLine("Please enter a valid student's percentage grade: ");
                    percentageGrade = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
