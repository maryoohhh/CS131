using System;

namespace TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
            // obtain user input for number of days spent weekly programming
            // stores input in daysProgramming
            Console.Write("Enter number of days spent weekly programming: ");
            int daysProgramming = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of hours spent weekly programming
            // stores input in hoursProgramming
            Console.Write("Enter number of hours spent weekly programming: ");
            int hoursProgramming = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of minutes spent weekly programming
            // stores input in minutesProgramming
            Console.Write("Enter number of minutes spent weekly programming: ");
            int minutesProgramming = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of seconds spent weekly programming
            // stores input in secondsProgramming
            Console.Write("Enter number of seconds spent weekly programming: ");
            int secondsProgramming = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of days spent weekly testing
            // stores input in daysTesting
            Console.Write("\nEnter number of days spent weekly testing: ");
            int daysTesting = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of hours spent weekly testing
            // stores input in hoursTesting
            Console.Write("Enter number of hours spent weekly testing: ");
            int hoursTesting = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of minutes spent weekly testing
            // stores input in minutesTesting
            Console.Write("Enter number of minutes spent weekly testing: ");
            int minutesTesting = Convert.ToInt32(Console.ReadLine());

            // obtain user input for number of seconds spent weekly testing
            // stores input in secondsTesting
            Console.Write("Enter number of seconds spent weekly testing: ");
            int secondsTesting = Convert.ToInt32(Console.ReadLine());

            // print out user input summary
            TimeSpan tsProgramming = new TimeSpan(daysProgramming, hoursProgramming, minutesProgramming, secondsProgramming);
            Console.WriteLine("\nTime spent weekly programming:");
            Console.WriteLine(tsProgramming.Days + " days " + tsProgramming.Hours + " hours " + tsProgramming.Minutes + " minutes " + tsProgramming.Seconds + " seconds ");

            // print out user input summary
            TimeSpan tsTesting = new TimeSpan(daysTesting, hoursTesting, minutesTesting, secondsTesting);
            Console.WriteLine("Time spent weekly testing:");
            Console.WriteLine(tsTesting.Days + " days " + tsTesting.Hours + " hours " + tsTesting.Minutes + " minutes " + tsTesting.Seconds + " seconds ");

            // adds time it took to program and test during the week
            // stores in TotalDevelopment
            TimeSpan TotalDevelopment = tsProgramming.Add(tsTesting);
            Console.WriteLine("\nTotal development time: " + TotalDevelopment.Days + " days " + TotalDevelopment.Hours + " hours " + TotalDevelopment.Minutes + " minutes ");

            // compares if programming or testing took more time during the week
            // returns either -1, 0, or 1
            int moreTime = tsProgramming.CompareTo(tsTesting);
            // -1 means programming took less time than testing
            if (moreTime == -1)
            {
                Console.WriteLine("Testing took more time during the week.");
            }
            // 0 means equal value
            else if (moreTime == 0)
            {
                Console.WriteLine("Programming and testing took the same amount of time during the week.");
            }
            // 1 programming took more time than testing
            else
            {
                Console.WriteLine("Programming took more time during the week.");
            }
        }
    }
}
