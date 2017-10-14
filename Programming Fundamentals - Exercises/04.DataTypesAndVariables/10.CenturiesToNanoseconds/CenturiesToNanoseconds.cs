using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days =(int)( years * 365.2422);
            int hours = (int)days * 24;
            int minutes =hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong)milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
