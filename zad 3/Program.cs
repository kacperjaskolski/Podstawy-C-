using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
//1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for
namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,  suma=0;
            Console.WriteLine("podaj liczbe całkowitą n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) 
            suma += i ;
            Console.WriteLine("1+...+{0}={1} ", n, suma);
            Console.ReadKey(true);
        }
    }
}
