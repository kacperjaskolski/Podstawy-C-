using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
//całkowitymi.Napisz program wykorzystujący funkcję suma.
namespace zad_1
{
    class Program
    {
        static int suma(int a, int b)
        { return a + b; }
        
        static void Main(string[] args)
        { 
           Console.WriteLine("2+5={0}" , suma (2,5));
                Console.ReadKey(true);
           

        }
    }
}
