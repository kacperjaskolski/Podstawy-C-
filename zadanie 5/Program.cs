using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        { //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka
            double r, h, l, V, PC;
            Console.WriteLine("podaj r=");
            r=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj h=");
            h=Convert.ToDouble(Console.ReadLine());
            l=Math.Sqrt(r*r+h*h);
            V = 1.0 / 0.3 * Math.PI * r * r * h;
            PC = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("V={0}", V);
            Console.WriteLine("PC={0}", PC); 
            Console.ReadKey(true);

        }
    }
}
