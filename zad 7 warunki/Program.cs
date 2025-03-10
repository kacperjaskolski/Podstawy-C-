using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
//odpowiednik rzymski.
namespace zad_7_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 3000) { a -= 3000; Console.Write("MMM"); }
             else if (a >= 2000) { a -= 2000; Console.WriteLine("MM"); }
           else  if (a >= 1000) { a -= 1000; Console.WriteLine("M");   }
            if (a >= 900) {  a -=900 ; Console.WriteLine("CM"); }
            else if (a >= 800) { a -= 800; Console.Write("DCCC"); }
            else if (a >= 700) { a -= 700; Console.Write("DCC"); }
            else if (a >= 600) { a -= 600; Console.Write("DC"); }
            else if (a >= 500) { a -= 500; Console.Write("D"); }
            else if (a >= 400) { a -= 400; Console.Write("CD"); }
            else if (a >= 300) { a -= 300; Console.Write("CCC"); }
            else if (a >= 200) { a -= 200; Console.Write("C"); }
            else if (a >= 100) { a -= 100; Console.Write("C"); }
            if (a >= 90) { a -= 90; Console.WriteLine("XC"); }
            else if (a >= 80) { a -= 80; Console.Write("LXXX"); }
            else if (a >= 70) { a -= 70; Console.Write("LXX"); }
            else if (a >= 60) { a -= 100; Console.Write("LX"); }
            else if (a >= 50) { a -= 50; Console.Write("L"); }
            else if (a >= 40) { a -= 40; Console.Write("XL"); }
            else if (a >= 30) { a -= 30; Console.Write("XXX"); }
            else if (a >= 20) { a -= 20; Console.Write("XX"); }
            else if (a >= 10) { a -= 10; Console.Write("X"); }
            switch (a)
            {
                case 1: Console.WriteLine("I"); break;
                case 2: Console.WriteLine("II"); break;
                case 3: Console.WriteLine("III"); break;
                case 4: Console.WriteLine("IV"); break;
                case 5: Console.WriteLine("V"); break;
                case 6: Console.WriteLine("VI"); break;
                case 7: Console.WriteLine("VII"); break;
                case 8: Console.WriteLine("VIII"); break;
                case 9: Console.WriteLine("IX"); break;
                default: Console.WriteLine(""); break;
            }
                    Console.ReadKey(true);






            }
    }
}
