using System;

namespace Account
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

            // Create and use Savings object
            Savings savings = new Savings(OPENING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            // Create and use Checking object
            Checking checking = new Checking(OPENING_BALANCE);
            checking.DeductServiceCharge();
            checking.ShowBalance();

            // Create and use JointSavings object
            JointSavings jointSavings = new JointSavings("George", "Jane", OPENING_BALANCE);
            jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
            jointSavings.ShowBalance();
            Console.ReadLine();
        }
    }

    // Base class called Account
    // Parent class
    class Account
    {
        protected decimal BankBalance
        {
            set;
            get;
        }

        protected string FirstNameA
        {
            set;
            get;
        }

        protected string FirstNameB
        {
            set;
            get;
        }

        protected Account()
        {
            Console.WriteLine();
            Console.WriteLine("Inside the Account constructor.");
        }

        public void ShowBalance()
        {
            Console.WriteLine("The balance is " + BankBalance.ToString("C"));
        }
    }

    // Derived class - Savings
    // Child class Savings of parent class Account
    class Savings : Account
    {
        // Default constructor
        public Savings()
        {
            Console.WriteLine("Inside the default Savings constructor.");
        }

        // Overloading Savings constructor
        public Savings(decimal balance)
        {
            Console.WriteLine("Inside the Savings constructor.");
            BankBalance = balance;
        }

        // Custom child method
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }
    }

    // Derived class - Checking
    // Child class Checking of parent class Account
    class Checking : Account
    {
        public Checking(decimal balance)
        {
            Console.WriteLine("Inside the Checking constructor.");
            BankBalance = balance;
        }

        // Custom child method
        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }

    // Derived class JointSavings inherited from Savings
    class JointSavings : Savings
    {
        public JointSavings(string firstNameA, string firstNameB, decimal balance)
        {
            Console.WriteLine("Inside the Joint Savings constructor.");
            BankBalance = balance;
            FirstNameA = firstNameA;
            FirstNameB = firstNameB;
        }
    }
}
