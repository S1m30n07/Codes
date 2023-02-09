using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicaNaFiguri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type of geometric figure: ");
            var TypeOfFigure = Console.ReadLine();

            if(TypeOfFigure == "square")
            {
                Console.Write("a = ");               
                var a = double.Parse(Console.ReadLine());
                var S = a * a;
                Console.WriteLine("S = " + Math.Round(S, 3));
            }
            else if (TypeOfFigure == "rectangle")
            {
                Console.Write("a = ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                var b = double.Parse(Console.ReadLine());
                var S = a * b;
                Console.WriteLine("S = " + Math.Round(S, 3));
            }
            else if (TypeOfFigure == "circle")
            {
                Console.Write("r = ");
                var r = double.Parse(Console.ReadLine());
                var S = r * r * Math.PI;
                Console.WriteLine("S = " + Math.Round(S, 3));
            }
            else if (TypeOfFigure == "triangle")
            {
                Console.Write("a = ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("h = ");
                var h = double.Parse(Console.ReadLine());
                var S = (a * h) / 2;
                Console.WriteLine("S = " + Math.Round(S,3));
            }
        }
    }
}
