﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void guliana()
        {
            double prom = 0; double summa = 0;
            Console.WriteLine("Введите число до 10"); int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                prom = Math.Pow(x, i) / (x + i); summa += prom;
            }
            Console.WriteLine(summa);
        }
        static void Main(string[] args)
        {
           guliana();
            Console.ReadKey();
        }
    }
}