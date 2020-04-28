using System;

namespace MethodCalls
{
    class Program
    {
        static void Main()
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = "G. Treele";

            // Call CalculateAverage() to calculate the average grade
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);

            // Call ShowAverage() to display the student nae and overall average
            ShowAverage(STUDENT_NAME, average);
            Console.ReadLine();
        }

        // Initialize CalculateAverage to calculate average grade of student
        public static float CalculateAverage(float course1, float course2, float course3)
        {
            // Initialize total number of grades
            const float TOTAL_COURSES = 3.0f;

            // Calculating sum of all grades
            float sumOfGrades = course1 + course2 + course3; 
            return sumOfGrades / TOTAL_COURSES;
        }

        static void ShowAverage(string STUDENT_NAME, float average)
        {
            Console.WriteLine(STUDENT_NAME + " average: " + average);
        }
    }
}
