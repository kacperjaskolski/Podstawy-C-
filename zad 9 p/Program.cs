using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
// pętli while. Np.: Dla liczby = 1342 trzeba obliczyć sumę 1+3+4+2.
namespace zad_9_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, suma = 0;
            Console.WriteLine("podaj liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                suma += a % 10;  // Dodaj ostatnią cyfrę liczby do sumy
                a /= 10;          // Usuń ostatnią cyfrę z liczby
            }

            Console.WriteLine("Suma cyfr wynosi: " + suma);
            Console.ReadKey();
        }
    }
}