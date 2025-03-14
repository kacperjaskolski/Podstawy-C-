using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
//nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n=3 narysowany trójkąt
//powinien wyglądać:
namespace zad_6_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("podaj liczbę naturalna n>1: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++) Console.Write(" ");
                for (j = 1; j <= 2* i -1 ; j++) Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);





        }
    }
}
