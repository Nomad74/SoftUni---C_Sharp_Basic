using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Truck_Driver
{
    class TruckDriver
    {
        static void Main()
        {
            string season = Console.ReadLine();
            var kmForMonth = double.Parse(Console.ReadLine());

            double salary;

            if (kmForMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary =kmForMonth * 0.75;
                }
                else if (season == "Summer")
                {
                    salary = kmForMonth * 0.90;
                }
                else
                {
                    salary = kmForMonth * 1.05;
                }
            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kmForMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    salary = kmForMonth * 1.10;
                }
                else
                {
                    salary = kmForMonth * 1.25;
                }
            }
            else
            {
                salary = kmForMonth * 1.45;
            }

            double clearSalary = 4 * salary;
            clearSalary = clearSalary - (clearSalary * 0.1);
            Console.WriteLine($"{( clearSalary):f2}");
        }
    }
}
