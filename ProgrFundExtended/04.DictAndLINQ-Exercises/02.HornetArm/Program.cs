using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetArm
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictLegion = new Dictionary<string, Legion>();
            long n = long.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                CalculateLegions(dictLegion);
            }
            Output(dictLegion);
        }

        private static void CalculateLegions(Dictionary<string, Legion> dictLegion)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { "=", "->", ":", " " }, StringSplitOptions.RemoveEmptyEntries);


            long legionActivity = long.Parse(input[0]);
            string legionName = input[1];
            string soldierTipe = input[2];
            long soldierCount = long.Parse(input[3]);

            Legion newLegion = new Legion();
            newLegion.LastActivity = legionActivity;
            newLegion.SoldierTipeSoldieName = new Dictionary<string, long>();
            newLegion.SoldierTipeSoldieName.Add(soldierTipe, soldierCount);

            if (!dictLegion.ContainsKey(legionName))
            {
                dictLegion.Add(legionName, newLegion);
            }
            else if (!dictLegion[legionName].SoldierTipeSoldieName.ContainsKey(soldierTipe))
            {
                dictLegion[legionName].SoldierTipeSoldieName.Add(soldierTipe, soldierCount);
                if (dictLegion[legionName].LastActivity < legionActivity)
                {
                    dictLegion[legionName].LastActivity = legionActivity;
                }
            }
            else
            {
                dictLegion[legionName].SoldierTipeSoldieName[soldierTipe] += soldierCount;
                if (dictLegion[legionName].LastActivity < legionActivity)
                {
                    dictLegion[legionName].LastActivity = legionActivity;
                }
            }
        }

        private static void Output(Dictionary<string, Legion> dictLegion)
        {
            string[] readCommand = Console.ReadLine().Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            if (readCommand.Length > 1)
            {
                long activity = long.Parse(readCommand[0]);
                string soldierTipe = readCommand[1];
                PrintLastActivitySoldierType(dictLegion, activity, soldierTipe);
            }
            else
            {
                string soldierTipe = readCommand[0];
                SoldierTipe(dictLegion, soldierTipe);
            }
        }

        private static void SoldierTipe(Dictionary<string, Legion> dictLegion, string soldierTipe)
        {
            foreach (var item in dictLegion.OrderByDescending(x => x.Value.LastActivity))
            {
                Console.WriteLine("{0} : {1}", item.Value.LastActivity, item.Key);
            }
        }

        private static void PrintLastActivitySoldierType(Dictionary<string, Legion> dictLegion, long activity, string soldierTipe)
        {
            foreach (var item in dictLegion
                .Where(x => x.Value.SoldierTipeSoldieName.ContainsKey(soldierTipe))
                .Where(x => x.Value.LastActivity < activity)
                .OrderByDescending(x => x.Value.SoldierTipeSoldieName[soldierTipe]))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.SoldierTipeSoldieName[soldierTipe]);
            }
        }
    }

    class Legion
    {
        public long LastActivity { get; set; }
        public Dictionary<string, long> SoldierTipeSoldieName { get; set; }
    }
}
