using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_from_C_to_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celcius = ");
            var Celcius = double.Parse(Console.ReadLine());
            var Farenheit = Celcius * 1.8 + 32;

            Console.Write("Farenheit = ");
            Console.WriteLine(Farenheit);
        }
    }
}
