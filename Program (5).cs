using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekolta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Loze na kvadraten meteur - ");
            int LOZK = int.Parse(Console.ReadLine());
            Console.Write("Grozde na 1 kvadraten metur - ");
            var GRK = double.Parse(Console.ReadLine());
            Console.Write("Nujni litra za vino - ");
            int LIT = int.Parse(Console.ReadLine());
            Console.Write("Rabotnici - ");
            int Workers = int.Parse(Console.ReadLine());
           
            var GROZDESUM = LOZK * GRK;
            var VINO = (GROZDESUM * 40 / 100) / 2.5;

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;

            if (VINO < LIT)
            {
                Console.WriteLine($"It will be a tough winter! {Math.Floor(LIT - VINO)} more liters wine needed");
            }
            else if(VINO > LIT)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(VINO)} liters. {Math.Ceiling(VINO - LIT)} left -> {Math.Ceiling((VINO - LIT) / Workers)} per person ");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
