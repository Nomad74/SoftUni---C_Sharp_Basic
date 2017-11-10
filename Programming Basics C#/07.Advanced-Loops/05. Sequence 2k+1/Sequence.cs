using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Sequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sequence = 1;

            while (sequence <= n)
            {
                Console.WriteLine(sequence);

                sequence = sequence * 2 + 1;
            }
        }
    }
}
