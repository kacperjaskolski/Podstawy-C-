using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
//największej z tych liczb
namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        { double a , b , c, d, e , min , max ;
            Console.WriteLine("podaj liczbę nr 1:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr 2:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr 3:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr 4:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr 5:");
            e = Convert.ToDouble(Console.ReadLine());
             min = a;
            if (b<min) min = b;
            if (c<min) min = c;
            if (d<min) min = d;
            if (e<min) min = e;
            Console.WriteLine("najmniejsza liczba to:{0}", min);
             max = a ;
            if (b>max) max = b;
            if (c>max) max = c;
            if (d>max) max = d;
            Console.WriteLine("największa liczba to:{0}", max);
            Console.ReadKey(true);

        }
    }
}
