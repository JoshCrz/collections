using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            string filePath = "C:/projects/collections/pop.csv";
            CsvReader reader = new CsvReader(filePath);
            Country[] countries = reader.ReadFirstNCountries(10);            

            foreach(Country country in countries)
            {
                System.Console.WriteLine($"{country.Population}: {country.Name}");
            }

        }
    }
}
