using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenchukovaBorsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cena na zelenchuci = ");



            var ZelCena = double.Parse(Console.ReadLine());
            Console.Write("Cena na plodove = ");
            var PlodCena = double.Parse(Console.ReadLine());
            Console.Write("Kilogrami na plodove = ");
            var PlodKG = double.Parse(Console.ReadLine());
            Console.Write("Kilogrami na zelenchuci = ");
            var ZelKG = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            var ZelSUM = ZelCena * ZelKG;
            var PlodSUM = PlodCena * PlodKG;


            var OBSHTO = ZelSUM + PlodSUM;
            Console.WriteLine("OBSHTO = " + OBSHTO);
            var OBSHTOEUR = OBSHTO / 1.94;
            Console.WriteLine("OBSHTO V EURO = " + Math.Round(OBSHTOEUR,2));


        }
    }
}
