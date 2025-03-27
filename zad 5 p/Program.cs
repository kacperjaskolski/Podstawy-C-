using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
//zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
//ekranie. Użyj pętli do-while
namespace zad_5_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("podaj x: ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            while (x < 0);
            Console.WriteLine("wczytano liczbe  x = {0}", x);
            Console.ReadKey(true);
        }
    }
}