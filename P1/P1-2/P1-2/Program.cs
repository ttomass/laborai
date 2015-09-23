using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------
// Sąlygos sakinys
// Simbolių paskirstymas į eilutes
//------------------------------------------------------------
namespace salygos_sakinys
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolis;
            int bendrasKiekis, kiekisEiluteje;
            Console.Write("Įveskite kiek iš viso bus simbolių: ");
            bendrasKiekis = int.Parse(Console.ReadLine());
            Console.Write("Įveskite kiek simbolių bus eilutėje: ");
            kiekisEiluteje = int.Parse(Console.ReadLine());
            Console.Write("Įveskite spausdinamą simbolį: ");
            simbolis = (char) Console.Read();
            for (int i = 1; i <= bendrasKiekis/kiekisEiluteje; i++)
            {
                for (int j = 1; j <= kiekisEiluteje; j++)
                {
                    Console.Write(simbolis);
                }
                Console.WriteLine();
            }
        }
    }
}
//------------------------------------------------------------
