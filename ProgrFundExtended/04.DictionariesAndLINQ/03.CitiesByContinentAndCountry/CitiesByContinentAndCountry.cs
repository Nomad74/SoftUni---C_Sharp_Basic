using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var cities = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                    if (!continentsData[continent].ContainsKey(country))
                    {
                        continentsData[continent][country]=new List<string>();
                        continentsData[continent][country].Add(cities);
                    }
                    else
                    {
                        continentsData[continent][country].Add(cities);
                    }
                }
                else
                {
                    if (!continentsData[continent].ContainsKey(country))
                    {
                        continentsData[continent][country] = new List<string>();
                        continentsData[continent][country].Add(cities);
                    }
                    else
                    {
                        continentsData[continent][country].Add(cities);
                    }
                }
            }
            foreach (var continentCountry in continentsData)
            {
                var continent = continentCountry.Key;
                var countries = continentCountry.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryCities in countries)
                {
                    var countrie = countryCities.Key;
                    var city = countryCities.Value;

                    Console.Write($"{countrie} -> ");
                    Console.WriteLine(string.Join(", ",city));
                }
            }
        }
    }
}
