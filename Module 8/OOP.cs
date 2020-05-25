using System;

namespace OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Creating an instance/object
            City phoenix = new City("Phoenix", 1703078, "US");
            City seattle = new City();

            // Calling public method to store data in object
            seattle.SetCity("Seattle", 3433000, "US");

            // Use object to access a public method for display
            phoenix.GetCity();
            // Display country value using Country property
            Console.WriteLine("Country: " + phoenix.Country);
            phoenix.GetPopulation();

            // Use object to access a public method for display
            seattle.GetCity();
            // Display country value using Country property
            Console.WriteLine("Country: " + seattle.Country);
            seattle.GetPopulation();

            // Calling static method called Version without creating an object
            City.Version();
        }
    }

    // Creating a class called City
    class City
    {
        // Private members
        private string name;
        private int population;
        private string country;

        // Public property named Country to access the private field
        public string Country
        {
            // Property is read only
            get
            {
                return country;
            }
        }

        // Default constructor
        public City()
        {

        }

        // Overloaded constructor
        public City(string name, int population, string country)
        {
            this.name = name;
            this.population = population;
            this.country = country;
        }

        // Publicly accessible methods
        // Storing data
        public void SetCity(string name, int population, string country)
        {
            this.name = name;
            this.population = population;
            this.country = country;
        }

        // Returns name value
        public void GetCity()
        {
            Console.WriteLine("City: " + name);
        }

        // returns population value
        public void GetPopulation()
        {
            Console.WriteLine("Population: " + population);
        }

        public static void Version()
        {
            Console.WriteLine("\nCity Info Version 1.0");
        }
    }
}
