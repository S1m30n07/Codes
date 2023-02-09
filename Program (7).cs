using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧетноНечетно
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broi chisla: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Chislo: ");
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum = num + sum;
                }
                else if(i % 2 != 0)
                {
                    sum2 = num + sum2;
                }

            }
            if (sum == sum2)
            {
                
                Console.WriteLine("Yes. The sum is: " + sum);
            }
            else
            {
                Console.WriteLine("No. The difference is: " + Math.Abs(sum - sum2));
            }
        }
    }
}
