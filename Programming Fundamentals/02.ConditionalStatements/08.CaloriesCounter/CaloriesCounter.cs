using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            double calories = 0;
            double n = int.Parse(Console.ReadLine());

            for(int i =1; i<=n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if(ingredient=="cheese")
                {
                    calories = calories + 500;
                }
                if(ingredient == "tomato sauce")
                {
                    calories = calories + 150;
                }
                if (ingredient == "salami")
                {
                    calories = calories + 600;
                }
                if (ingredient == "pepper")
                {
                    calories = calories + 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
