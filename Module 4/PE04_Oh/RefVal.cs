using System;

namespace RefVal
{
    class Program
    {
        static void Main(string[] args)
        {
            float hoursPerWeek = 40.0f;
            float hourlyWage = 22.0f;

            // Explicitly passing variables by reference
            GrossWage(ref hoursPerWeek, ref hourlyWage);
            Console.WriteLine("Weekly Gross Wage After Overtime");
            Console.WriteLine("Total Hours Worked: " + hoursPerWeek);
            Console.WriteLine("Gross Income: " + hourlyWage);
            Console.ReadLine();
        }

        // Receives arguments explicitly by reference
        static void GrossWage(ref float hours, ref float income)
        {
            // Initialize time & half pay for overtime work
            const float TIME_AND_HALF = 1.5f;

            // Initialize overtime hours worked
            float overtimeHours = 8.0f;

            // Calculating gross income
            income = (income * hours) + (income * overtimeHours * TIME_AND_HALF);
            hours += overtimeHours;
        }
    }
}
