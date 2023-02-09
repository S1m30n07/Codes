using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kotki = ");
            var Cats = int.Parse(Console.ReadLine());
            var GRCounter1 = 0;
            var GRCounter2 = 0;
            var GRCounter3 = 0;
            double SumFood = 0;
            int food = 1;
            double PRICEPERDAY = 0;

            for(int i = 0; i < Cats; i++)
            {
                Console.Write("Hrana(gramove) = ");
                food = int.Parse(Console.ReadLine());
                SumFood = SumFood + food;
                if (food >= 100 && food < 200)
                {
                    GRCounter1++;
                }
                else if (food >= 200 && food < 300)
                {
                    GRCounter2++;
                }
                if (food >= 300 && food < 400)
                {
                    GRCounter3++;
                }
                
            }
            Console.WriteLine();
            PRICEPERDAY = SumFood / 1000 * 12.45;
            Console.WriteLine("Group 1:" + GRCounter1 + " cats");
            Console.WriteLine("Group 2:" + GRCounter2 + " cats");
            Console.WriteLine("Group 3:" + GRCounter3 + " cats");
            Console.WriteLine("Price for food per day: " + Math.Round(PRICEPERDAY, 2) + " lv");
        }
    }
}
