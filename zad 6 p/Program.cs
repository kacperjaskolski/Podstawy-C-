using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
//Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
//Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
//dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
//pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero).
namespace zad_6_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b, wynik;

            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("1 - oblicz pola prostokąta");
                Console.WriteLine("2 - oblicz pola kwadratu");
                Console.WriteLine("3 - oblicz pola trójkąta");
                Console.WriteLine("0 - koniec");
                Console.WriteLine("twoj wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());  // poprawiona konwersja
                        Console.WriteLine("podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());  // poprawiona konwersja
                        wynik = a * b;
                        Console.WriteLine("pole wynosi: " + wynik);
                        break;

                    case 2:
                        Console.WriteLine("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());  // poprawiona konwersja
                        wynik = a * a;
                        Console.WriteLine("pole wynosi: " + wynik);
                        break;

                    case 3:
                        Console.WriteLine("podaj a: ");
                        a = Convert.ToDouble(Console.ReadLine());  // poprawiona konwersja
                        Console.WriteLine("podaj b: ");
                        b = Convert.ToDouble(Console.ReadLine());  // poprawiona konwersja
                        wynik = (a * b) / 2;
                        Console.WriteLine("pole wynosi: " + wynik);
                        break;

                    default:
                        Console.WriteLine("nie wybrano właściwej liczby z menu");
                        break;
                }

            } while (wybor != 0);  // poprawne zamknięcie pętli

            Console.ReadKey(true);  // przeniesione poza switch, aby się wykonało
        }
    }
}
