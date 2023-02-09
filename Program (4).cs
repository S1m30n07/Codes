using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Points = ");

            var Points = double.Parse(Console.ReadLine());
            double Bonus = 0;
            Console.Write("");

            if (Points > 1000)
            {
                Bonus = Points * 0.10;
            }
            else

            if (Points > 100)
            {
                Bonus = (Points) * 0.20;
            }

            if (Points <= 100)
            {
                Bonus = 5;
            }

            if (Points % 2 == 0)
            {
                Bonus = Bonus + 1;
            }
            else


            if (Points % 10 == 5)
            {
                Bonus = Bonus += 2;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BonusPoints = " + Bonus);
            Console.WriteLine("Obshto: " + (Points + Bonus));
            Console.ForegroundColor = ConsoleColor.White;













        }
    }
}