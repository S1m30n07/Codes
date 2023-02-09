using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number100to200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The number = ");
            var number = int.Parse(Console.ReadLine());

            if(number < 100)
            {
                Console.WriteLine("The number is smaller than 100");
            }
            else if (number == 100)
            {
                Console.WriteLine("The number is 100");
            }
            else if (number == 200)
            {
                Console.WriteLine("The number is 200");
            }
            else if(number <= 200)
            {
                Console.WriteLine("The number is between 100 and 200");
            }
            if (number > 200)
            {
                Console.WriteLine("The number is greater than 200");
            }

        }
    }
}
