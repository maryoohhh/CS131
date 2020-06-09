using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ColorList
{
    class MainClass
    {
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static void Main(string[] args)
        {
            // Initialize List called Colors
            List<string> Colors = new List<string>();

            // Adding elements on list Colors
            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Orange");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Indigo");
            Colors.Add("Violet");
            Colors.Add("Black");

            // Printing original list using foreach
            Console.WriteLine("Original list:");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }

            // Using Count() method, saving, and printing the return
            int counter = Colors.Count();
            Console.WriteLine("The Colors list has {0} items", counter);

            // Sorting the list
            Colors.Sort();

            // Printing sorted list using foreach
            Console.WriteLine("Sorted list:");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }

            // Obtaining index of Violet
            int index = Colors.IndexOf("Violet");
            // Removing the element at index
            Colors.RemoveAt(index);
            // Inserting string Purple in the second to the last location
            Colors.Insert(counter - 2, "Purple");

            // Printing list after inserting Purple
            Console.WriteLine("List with inserted Purple:");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }

            // Sorting the list after inserting Purple
            Colors.Sort();

            // Printing sorted list after inserting Purple
            Console.WriteLine("Sorted list with inserted Purple:");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }

            // Conditional statement to check if Magenta is in the list
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list");
            }

            // Adding Magenta on the list
            Colors.Add("Magenta");

            // Conditional statement to check if Magenta is in the list
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list");
            }

            // Printing list after adding Magenta
            // Expected to show Magenta at the end of list
            // Add() adds the element at the end of the list
            // Insert() allows specification on where exactly to insert the new element
            Console.WriteLine("List after adding Magenta:");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
