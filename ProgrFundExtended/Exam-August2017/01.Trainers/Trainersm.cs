using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Trainersm
    {
        static void Main()
        {
            var input = new string[3];
            var teams = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    input[l] = Console.ReadLine();
                }
                var team = input[2];
                var distance = double.Parse(input[0]);
                var cargo = double.Parse(input[1]);

                var cargoIncome = cargo * 1000 * 1.5;
                var fuelExpenses = 0.7 * distance * 1600 * 2.5;
                var participantEarnedMoney = cargoIncome-fuelExpenses;

                if (!teams.ContainsKey(team))
                {
                    teams[team] = new List<double>();
                    teams[team].Add(participantEarnedMoney);
                }
                else
                {
                    teams[team].Add(participantEarnedMoney);
                }
            }
            foreach (var participiantTeam in teams)
            {

            }
        }
    }
}
