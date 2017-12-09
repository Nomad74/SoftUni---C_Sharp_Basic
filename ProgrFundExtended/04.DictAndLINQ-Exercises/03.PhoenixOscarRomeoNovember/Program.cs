using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();

            string line = Console.ReadLine();
            while (line != "Blaze it!")
            {
                var tokens = line.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string creatureName = tokens[0];
                string squadMateName = tokens[1];

                var squadMate = new SquadMate();
                squadMate.MateName = squadMateName;

                //Non-existing creatures
                if (!creatures.Any(x => x.CreatureName == creatureName))
                {
                    var creature = new Creature();
                    creature.CreatureName = creatureName;
                    creature.SquadMates = new List<SquadMate>();
                    creature.SquadMates.Add(squadMate);
                    creatures.Add(creature);

                    line = Console.ReadLine();
                    continue;
                }

                //Existing creatures
                if (creatures.Any(x => x.CreatureName == creatureName))
                {
                    var existingCreature = creatures.First(x => x.CreatureName == creatureName);
                    var existingSquadMates = existingCreature.SquadMates;

                    if (!existingSquadMates.Any(x => x.MateName == squadMateName))
                    {
                        existingSquadMates.Add(squadMate);
                    }

                    line = Console.ReadLine();
                    continue;
                }
            }

            foreach (var creature in creatures)
            {
                string name = creature.CreatureName;
                var squadMates = creature.SquadMates;
                foreach (var cr in creatures)
                {
                    string nextCreatureName = cr.CreatureName;
                    var nextSquadMates = cr.SquadMates;
                    if (squadMates.Any(x => x.MateName == nextCreatureName) && nextSquadMates.Any(x => x.MateName == name))
                    {
                        squadMates.RemoveAll(x => x.MateName == nextCreatureName);
                        nextSquadMates.RemoveAll(x => x.MateName == name);
                    }
                }
            }

            //Print
            foreach (var creature in creatures.OrderByDescending(x => x.SquadMates.Count))
            {
                string name = creature.CreatureName;
                int cnt = creature.SquadMates.Count;
                Console.WriteLine($"{name} : {cnt}");
            }
        }
    }

    public class Creature
    {
        public string CreatureName { get; set; }

        public List<SquadMate> SquadMates { get; set; }
    }

    public class SquadMate
    {
        public string MateName { get; set; }
    }
}
