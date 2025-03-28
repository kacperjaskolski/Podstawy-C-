using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
//liczby w odwrotnej kolejności na ekranie.
namespace zad_2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int n, i ;
            Console.WriteLine("podaj ilośc elementów tablicy n <=1000");
             n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Console.Write("elementy tablicy: ");
            for (i = 0; i < n; i--)
            {
                Console.Write("{0}, 0", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
