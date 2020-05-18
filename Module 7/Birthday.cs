using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize my birthday
            const int YR = 1992, MTH = 12, DAY = 30;

            // calling ShowDateTime
            DateTime birthday = new DateTime(YR, MTH, DAY);
            ShowDateTime(birthday);
        }

        // initialize ShowDateTime()
        public static void ShowDateTime(DateTime dt)
        {
            // format output to show different values
            Console.Write("Year: " + dt.Year);
            Console.Write(" Month: " + dt.Month);
            Console.WriteLine(" Day: " + dt.Day);
            Console.Write("Day of Week: " + dt.DayOfWeek);
            Console.WriteLine(" Day of Year: " + dt.DayOfYear);

            // format ouput in long date format
            Console.WriteLine("\n" + dt.ToString("D"));
        }
    }
}
