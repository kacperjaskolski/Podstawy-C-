using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//. Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny
//czy też nie.
namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("podaj rok");
            rok = Convert.ToInt32(Console.ReadLine());
            if (rok % 4 == 0)
                Console.WriteLine("rok jest przystępny");
            else if (rok % 100 == 0)
                Console.WriteLine("rok jest przytstępny");
            else if (rok % 400 == 0) 
            Console.WriteLine("rok jest przytstępny");
            else Console.WriteLine("rok  nie jest przytstępny");
            Console.ReadKey(true);
            {
                 
            }

        }
    }
}
