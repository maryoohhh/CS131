using System;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // obtain user input for number of days
            // stores input in days
            Console.WriteLine("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of hours
            // stores input in hours
            Console.WriteLine("Enter number of hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of minutes
            // stores input in minutes
            Console.WriteLine("Enter number of minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of seconds
            // stores input in seconds
            Console.WriteLine("Enter number of seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // print out user input
            TimeSpan ts = new TimeSpan(days, hours, minutes, seconds);
            Console.WriteLine(ts.Days + " days " + ts.Hours + " hours " + ts.Minutes + " minutes " + ts.Seconds + " seconds ");

            // print out timespans in days, hours, minutes, and seconds
            Console.WriteLine("Timespan in days: " + ts.TotalDays.ToString("N2"));
            Console.WriteLine("Timespan in hours: " + ts.TotalHours.ToString("N2"));
            Console.WriteLine("Timespan in minutes: " + ts.TotalMinutes.ToString("N2"));
            Console.WriteLine("Timespan in seconds: " + ts.TotalSeconds);
        }
    }
}
