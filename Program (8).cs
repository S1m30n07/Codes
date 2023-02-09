using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number = ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            do
            {
                Console.Write("Number = ");
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
                counter++;
            } while (sum <= k);

            if (sum > k)
            {
                Console.WriteLine("Sum is bigger than " + k + " and the sum is: " + sum);
            }
            else
            {
                Console.WriteLine("Not big enough");
            }
            
        }
    }
}
