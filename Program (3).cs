using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnaPechalba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("rabotni dni v meseca = ");
            var N = double.Parse(Console.ReadLine());
            Console.Write("izkarani pari na den = ");
            var M = double.Parse(Console.ReadLine());
            Console.Write("kurs na dolara = ");
            var K = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            var MZ = N * M;
            var GodDohod = MZ * 12 + MZ * 2.5;
            var Danuk = GodDohod * 25 / 100;
            var ChistGodDohod = (GodDohod - Danuk) * K;
            var SRPECHLBA = ChistGodDohod / 365;
            Console.WriteLine("Srednata pechalba na den e " + Math.Round(SRPECHLBA, 2));

        }
    }
}
