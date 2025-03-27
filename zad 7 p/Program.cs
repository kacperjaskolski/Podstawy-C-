using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, silnia = 1, i = 1;
            Console.WriteLine("podaj liczbe:");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                silnia = silnia * i;
                i++;
            }

            while (i <= a);
            Console.WriteLine("silnia jest równa " + silnia);
            Console.ReadKey(true);
        }

    }
}
