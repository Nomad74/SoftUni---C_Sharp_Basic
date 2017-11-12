using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            var siteVisits = 0.0;  int token = 1;
            var siteCommercialPricePerVisit = 0.0;
            List<string> siteName = new List<string>();
            decimal siteLoss = 0.0m;
            decimal totalLoss = 0.0m;

            for (int i = 0; i < n; i++)
            {
              var input = Console.ReadLine().Split(' ').ToList();
              siteName.Add(input[0]);
              siteVisits =double.Parse(input[1]);
              siteCommercialPricePerVisit =double.Parse(input[2]);
              siteLoss = (decimal)siteVisits * (decimal)siteCommercialPricePerVisit;
              totalLoss += siteLoss;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{siteName[i]}");
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            for (int i = 0; i <n ; i++)
            {
                token *= securityKey;
            }
            Console.WriteLine($"Security Token: {token}");
        }
    }
}
