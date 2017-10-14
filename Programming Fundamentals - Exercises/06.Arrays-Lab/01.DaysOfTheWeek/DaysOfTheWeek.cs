using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DaysOfTheWeek
{
    class DaysOfTheWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };

            int day = int.Parse(Console.ReadLine());

            if(day<=0 || day>7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[day-1]);
            }
        }
    }
}
