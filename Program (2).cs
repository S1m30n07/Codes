﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakticheskoZadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.WriteLine("BGN = " + Math.Round(BGN,2));
        }
    }
}
