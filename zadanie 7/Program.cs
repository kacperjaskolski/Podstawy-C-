﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
                   int a, b;
            Console.Write("podaj a=");
         a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2}r{3}", a, b, a / b, a % b);
            Console.ReadKey(true);
        }
    }
}

