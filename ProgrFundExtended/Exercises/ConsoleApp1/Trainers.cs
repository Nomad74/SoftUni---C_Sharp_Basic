using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    class Trainers
    {
        static void Main()
        {
            ; double participantEarnedMoney = 0;
          var trainers = new Dictionary<string, double>();
            var n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++) 
            {
                var distanceMiles = double.Parse(Console.ReadLine());
                var cargoTons = double.Parse(Console.ReadLine());
                var team = Console.ReadLine();

                var fuelExpenses = ((distanceMiles * 1600.0) * 0.7) * 2.5;
                var cargoWorth = (cargoTons * 1000.0) * 1.5;
                participantEarnedMoney = cargoWorth - fuelExpenses;

                if (!trainers.ContainsKey(team))
                {
                    trainers[team]=participantEarnedMoney;
                }
                else
                {
                    trainers[team]= trainers[team]+(participantEarnedMoney);
                }
            }
            var teamMostEarnedMoney = trainers.OrderByDescending(x=>x.Value).First();
            double totalEarnedTeamMoney = teamMostEarnedMoney.Value;
            string teamName = teamMostEarnedMoney.Key;

            Console.WriteLine($"The {teamName} Trainers win with ${totalEarnedTeamMoney:f3}.");
        }
    }
}
