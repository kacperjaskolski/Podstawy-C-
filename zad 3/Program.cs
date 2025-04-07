using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
//obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.

namespace zad_3
{
    class Program
    {
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        { 
            Console.WriteLine(  "dla  r=1,5 Pole={0}", pole_kola(1.5)); 
            Console.ReadKey(true);


        }
    }
}
