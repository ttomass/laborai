//------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------------------
// Ciklas for
//------------------------------------------------------------
namespace ciklas
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a;
            int b;
            int kartai = 0;
            Console.Write("Įveskite sveikąją a reikšmę: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Įveskite sveikąją b reikšmę: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Skaičiai nuo {0} iki {1} ir jų kvadratai:", a, b);
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(" {0,3:d} {1,5:d} {2,7:d}", i, i*i, i*i*i);
                kartai++;
            }
            Console.WriteLine("Programa vyko {0} kartų", kartai);
        }
    }
}
//------------------------------------------------------------