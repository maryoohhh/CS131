using System;

namespace MailString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input and stores it in FirstName
            Console.WriteLine("First name: ");
            string FirstName = Console.ReadLine();
            // Takes user input and stores it in LastName
            Console.WriteLine("Last name: ");
            string LastName = Console.ReadLine();

            // Initializing string called Domain
            string Domain = "@abc.com";

            // Concatenate strings in an email format
            string email = string.Concat(char.ToLower(FirstName[0]), LastName.ToLower(), Domain);

            // Prints out string called email
            Console.WriteLine(email);
        }
    }
}
