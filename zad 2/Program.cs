using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
//zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.
namespace zad_2
{
    class Program
    {
        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {   Console.WriteLine("max z 3 i 5 to {0}", max(3 , 5 ));
            Console.WriteLine("max z 5 i 3 to {0}", max(5, 3));
            Console.WriteLine("max z 3 i 3 to {0}", max(3, 3));
            Console.ReadKey(true);
        }
    }
}
