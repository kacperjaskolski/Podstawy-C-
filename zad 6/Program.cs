using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static void Main(string[] args, double a)
        { //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz
            double  x,b,suma,roznica,iloczyn,iloraz;
            Console.WriteLine("podaj a=");
            x=Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("podaj b=");
             b=Convert.ToDouble(Console.ReadLine());
            suma = x + b; 
            roznica= x-b;
            iloczyn = x * b;
            iloraz = x / b;
            Console.WriteLine("{0}+{1}={2}",x ,b,  suma);
            Console.WriteLine("{0}-{1}={2}",x , b, roznica);
            Console.WriteLine($"{x}*{b}={iloczyn}");
            Console.WriteLine($"{x}/{b}={iloraz}");
            Console.ReadKey(true);
            
 
        }
    }
}
