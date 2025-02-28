using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
//największej z tych liczb
namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        { double a, b, c;
            Console.WriteLine("podaj liczbę nr1:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr2:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę nr3:");
            c= Convert.ToDouble(Console.ReadLine());
            if ((a<=b) && (a<=c))
                  Console.WriteLine("liczba {0} jest najmniejsza", a);
           else  if ((b<=c) && (b<=a))
                    Console.WriteLine("liczba {0} jest najmniejsza " , b);
            else Console.WriteLine("liczba {0} jest najmniejsza ", c);
            if ((a>=b) && (a>=c))
                Console.WriteLine("liczba {0} jest największa", a);
            else if ((b>=a) && (b>=c))
                Console.WriteLine("liczba {0} jest największa", b);
            else 
              Console.WriteLine("liczba {0} jest największa", c);
            Console.ReadKey(true);

        }
    }
}
