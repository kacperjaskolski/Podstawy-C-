using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i;
            int suma, n;
            Console.Write("podaj ilośc elementów tablicy <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i];
            Console.WriteLine("suma elementów tabilcy wynosi:{0}" , suma);
            Console.ReadKey(true);
        }
    }
}
