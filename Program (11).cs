using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    internal class Program
    {

        static void PrintLine(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }

        static void TrianglePrint(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
                
            }
            
            

            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

            Console.WriteLine("                               :D");

        }
        static void Main(string[] args)
        {
            Console.Write("Mashtab na triugulnik: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            TrianglePrint(n);
            Console.WriteLine("That is " + n + " rows triangles");
            Console.WriteLine();
        }
    }
}
