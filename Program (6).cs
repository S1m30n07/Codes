using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puteshestvie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Budget: ");
            
            var budget = double.Parse(Console.ReadLine());
            Console.Write("Season: ");
            string season = Console.ReadLine();
            double Sum = 0.0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "winter" && budget <= 100)
                {
                    Sum = budget * 70 / 100;
                    Console.WriteLine("You will rest in a hotel and the sum is: " + Sum);
                }
                if (season == "summer" && budget <= 100)
                {
                    Sum = budget * 30 / 100;
                    Console.WriteLine("You will rest in a camp and the sum is: " + Sum);
                }
            }
            if (budget <= 1000 && budget > 100)
            {
                Console.WriteLine("Somewhere in The Balkans");
                if (season == "winter" && budget <= 1000)
                {
                    Sum = budget * 80 / 100;
                    Console.WriteLine("You will rest in a hotel and the sum is: " + Sum);
                }
                if (season == "summer" && budget <= 1000)
                {
                    Sum = budget * 40 / 100;
                    Console.WriteLine("You will rest in a camp and the sum is: " + Sum);
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Sum = budget * 90 / 100;
                    
                Console.WriteLine("You will rest in a hotel and the sum is: " + Sum);


            }
        }
    }
}
