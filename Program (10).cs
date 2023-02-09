using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age (Type 'Christmas' to stop): ");
            string Ages = Console.ReadLine();
            int adultcounter = 0;
            int kidcounter = 0;  
            while(Ages != "Christmas")
            {
                
                if (int.Parse(Ages) >= 0 && int.Parse(Ages) <= 16)
                {
                    kidcounter++;
                }
                else
                {
                    adultcounter++;
                }
                Console.Write("Enter Age (Type 'Christmas' to stop): ");
                Ages = Console.ReadLine();
            }
           
            Console.WriteLine();
            Console.WriteLine("Number of adults: " + adultcounter);
            Console.WriteLine("Number of kids: " + kidcounter);
            Console.WriteLine("Money for toys: " + (kidcounter * 5) + "lv");
            Console.WriteLine("Money for sweaters: " + (adultcounter * 15) + "lv");
        }
        
    }
}
