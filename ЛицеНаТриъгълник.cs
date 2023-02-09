using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashno2
{
    internal class ЛицеНаТриъгълник
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            var S = a * h / 2;
            Console.Write("S = ");
            Console.WriteLine(Math.Round(S, 2));
        }
    }
}
