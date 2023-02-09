using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_from_USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            

            Console.WriteLine("BGN = " + Math.Round(BGN, 2));
        }
    }
}
