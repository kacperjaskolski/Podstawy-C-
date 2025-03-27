using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//h
namespace zad_10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba, wynik = 0;
            do
            {

                Console.WriteLine("podaj liczbę: ");
                liczba = Convert.ToInt32(Console.ReadLine());

                wynik = wynik + liczba;
            } while (liczba != 0);
            {
                Console.WriteLine("suma wynosi:", wynik);
            }


        }
    }
}
