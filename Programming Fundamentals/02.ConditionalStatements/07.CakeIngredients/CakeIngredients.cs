using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int counter = -1;
            string ingredient="a";

            while (ingredient!="Bake!")
            {
                ingredient = Console.ReadLine();
                counter++;
                if (ingredient == "Bake!") break;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
