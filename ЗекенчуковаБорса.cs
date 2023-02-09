using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗекенчуковаБорса
{
    internal class ЗекенчуковаБорса
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vegetibles = ");
            var Vegetibles = double.Parse(Console.ReadLine());
            Console.Write("Kg = ");
            var VegKg = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fruits = ");
            var Fruits = double.Parse(Console.ReadLine());
            Console.Write("Kg2 = ");
            var FruKG = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            var SumVeg = Vegetibles * VegKg;
            Console.WriteLine("The vegetibles cost: " + Vegetibles + " * " + VegKg + " kg" + " = " + SumVeg + "lv");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            var SumFruits = Fruits * FruKG;
            Console.WriteLine("The fruits cost: " + Fruits + " * " + FruKG + " kg" + " = " + SumFruits + "lv");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            var ObshtaSuma = (SumVeg + SumFruits);
            var Euro = (SumVeg + SumFruits) / 1.94;
            Console.WriteLine("All of them cost: " + ObshtaSuma + "lv = " + Math.Round(Euro, 2) + " Euro" );
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
