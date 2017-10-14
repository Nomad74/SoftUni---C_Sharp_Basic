using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            var incomBGL   = double.Parse(Console.ReadLine());
            var avrSuccess = double.Parse(Console.ReadLine());
            var minSalary  = double.Parse(Console.ReadLine());

            double  socScholarship = 0;
            double  scholarship    = 0;

            if ((incomBGL < minSalary) & (avrSuccess > 4.50))
            {
                socScholarship = Math.Floor( minSalary * (35.00 / 100.00));
            }
            if (avrSuccess >= 5.50)
            {
                scholarship = Math.Floor ( avrSuccess * 25.00);
            }
            if ((scholarship==0)&&(socScholarship==0))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
                
            if (socScholarship>scholarship)
            { 
                Console.WriteLine($"You get a Social scholarship {socScholarship} BGN");
            }
            if ((scholarship >= socScholarship)&(scholarship!=0))
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
            }
        }
        
    }
}
