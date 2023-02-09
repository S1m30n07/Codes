using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_from_rad.to_deg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("rad = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / 3.14;
            Console.WriteLine("deg = " + Math.Round(deg));

        }
    }
}
