using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Cake
    {
        static void Main()
        {
            var widthCake = double.Parse(Console.ReadLine());
            var lenghtCake = double.Parse(Console.ReadLine());

            double pieces = widthCake * lenghtCake;
            double takenPieces = 0;
            double defPieces = 0;
            double piecesLeft = 0;
            double counter = 0;


            while (takenPieces <= pieces)
            {
                string newPieces = Console.ReadLine();
                if (newPieces=="STOP")
                {
                    counter = 1;
                    break;
                }
                else
                {
                    double convPieces = Convert.ToDouble(newPieces);
                    takenPieces = takenPieces + convPieces;
                    piecesLeft = pieces - takenPieces;
                    defPieces = Math.Abs(pieces - takenPieces);
                }
            }
            if (counter==1)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {defPieces} pieces more.");
            }
        }
    }
}
