using System;

namespace Fashion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Fashion fashionDepartment = new Fashion();
            fashionDepartment.DisplayPromotions();
            Console.ReadLine();
        }
    }

    // Stores sale event data
    class Promotion
    {
        public string Name { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Promotion(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
        }
    }

    // Base class declaration
    // Abstract class that stores and displays promotional information
    abstract class Deparment
    {
        // Abstract property called DepartmentName
        public abstract string DepartmentName { get; protected set; }

        protected Promotion[] sales;
        // Abstract method AssignPromotions
        protected abstract void AssignPromotions();


        // Method DisplayPromotions
        public virtual void DisplayPromotions()
        {
            Console.WriteLine("{0} Deparment Promotions: ", DepartmentName);

            foreach(Promotion sale in sales)
            {
                Console.WriteLine("Name: " + sale.Name);
                Console.WriteLine("Start: " + sale.Start.ToString("m"));
                Console.WriteLine("End: " + sale.End.ToString("m"));
            }
        }
    }

    // Child class Fashion derived from Department
    // Implementing class that sets department name and assigns promotions
    class Fashion : Deparment
    {
        // Overriding property DepartmentName
        public override string DepartmentName { get; protected set; }

        public Fashion()
        {
            DepartmentName = "Fashion";
            AssignPromotions();
        }

        // Overriding method AssignPromotions
        protected override void AssignPromotions()
        {
            DateTime start = new DateTime(2014, 9, 1);
            DateTime end = new DateTime(2014, 9, 15);
            Promotion promotion = new Promotion(start, end, "Fall Sale");

            sales = new Promotion[] { promotion };
        }
    }
}
