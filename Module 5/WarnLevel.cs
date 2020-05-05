using System;

namespace WarnLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for user to input a student's grade
            Console.WriteLine("Enter the student's percentage grade: ");
            int percentageGrade = Convert.ToInt32(Console.ReadLine());

            // Calling the method StudentGrade
            StudentGrade(percentageGrade);
        }

        // Initializing StudentGrade method that takes one integer input argument
        static void StudentGrade(int percentageGrade)
        {
            // Loop to keep iterating until user inputs an argument that satisfies a condition
            while (true)
            {
                // Loop to check if user input is within range
                if (0 <= percentageGrade && percentageGrade <= 100)
                {
                    // First warning: student is in excellent standing
                    if (90 <= percentageGrade && percentageGrade <= 100)
                    {
                        Console.WriteLine("Student passed the class in excellent standing.");
                        break;
                    }

                    // Second warning: student is in good standing
                    else if (78 <= percentageGrade && percentageGrade < 90)
                    {
                        Console.WriteLine("Student passed the class in good standing");
                        break;
                    }

                    // Third warning: student is borderline pass
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
