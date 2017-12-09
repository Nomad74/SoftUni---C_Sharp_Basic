using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PokemonEvolution
{
    class Program
    {
        struct EvolutionType

        {

            public string type;

            public int level;

            public EvolutionType(string type, int level)

            {

                this.type = type;

                this.level = level;

            }

        }



        class PokemonEvolution

        {

            static void Main(string[] args)
        {
                Dictionary<string, List<EvolutionType>> pokeymons = new Dictionary<string, List<EvolutionType>>();

                char[] splitters = { ' ', '-', '>' };

                List<string> input = new List<string>();

                string current;

                while (true)

                {

                    current = Console.ReadLine();

                    if (current == "wubbalubbadubdub")

                    {

                        break;

                    }

                    input.Add(current);

                }



                foreach (string line in input)

                {

                    List<string> data = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToList();



                    if (data.Count == 1 && pokeymons.ContainsKey(data[0])) // Name entered

                    {

                        string key = data[0];

                        Console.WriteLine("# " + key);

                        var pokeymon = pokeymons[key];

                        pokeymon.ForEach(et => Console.WriteLine(et.type + " <-> " + et.level));

                    }

                    else if (pokeymons.ContainsKey(data[0])) // Existing key entered

                    {

                        pokeymons[data[0]].Add(new EvolutionType(data[1], int.Parse(data[2])));

                    }

                    else if (data.Count == 3) // New entry - all fields are entered

                    {

                        SortedDictionary<string, int> sd = new SortedDictionary<string, int>();

                        sd.Add(data[1], int.Parse(data[2]));

                        List<EvolutionType> et = new List<EvolutionType>();

                        et.Add(new EvolutionType(data[1], int.Parse(data[2])));

                        pokeymons.Add(data[0], et);

                    }

                }



                foreach (var pokeymon in pokeymons)

                {

                    Console.WriteLine("# " + pokeymon.Key);

                    pokeymons[pokeymon.Key].Sort((a, b) => b.level - a.level);

                    pokeymons[pokeymon.Key].ForEach(et => Console.WriteLine(et.type + " <-> " + et.level));

                }

            }
        }
    }
}
