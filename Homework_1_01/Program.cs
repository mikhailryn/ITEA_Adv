using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{

    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<Country, CountryInfo> countries = new Dictionary<Country, CountryInfo>();
            countries.Add(new Country("Ukraine"), new CountryInfo("Kyiv", 42, 603));
            countries.Add(new Country("Czech Republic"), new CountryInfo("Prague", 8, 78));
            countries.Add(new Country("France"), new CountryInfo("Paris", 67 , 644));

            foreach(KeyValuePair<Country, CountryInfo> thing in countries)
            {
                Console.WriteLine($"Country: {thing.Key.nameCountry}, capital: {thing.Value.Capital}, population: {thing.Value.Population} million, size: {thing.Value.Size} square km");
            }
            Console.ReadLine();

        }
            
         
    }

  
}
