using System;

namespace MailString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input and stores it in FirstName
            Console.Write("First name: ");
            string FirstName = Console.ReadLine();
            // Takes user input and stores it in LastName
            Console.Write("Last name: ");
            string LastName = Console.ReadLine();

            // Initializing string called Domain
            string Domain = "@abc.com";

            // Checks the length of last name
            // If LastName is longer than three characters
            if (LastName.Length >= 3)
            {
                // Assigns LastName as the first three characters of the string LastName
                LastName = LastName.Substring(0, 3);
            }

            // Concatenate strings in an email format
            string email = string.Concat(char.ToLower(FirstName[0]), LastName.ToLower(), Domain);

            // Prints out string called email
            Console.WriteLine(email);
        }
    }
}