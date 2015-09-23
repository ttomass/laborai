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
        static void Main(string[] args)
        {
            Console.WriteLine("Skaičiai nuo 5 iki 15 ir jų kvadratai:");
            for (int i = 5; i <= 15; i++)
                Console.WriteLine(" {0,3:d} {1,5:d} {2,7:d}", i, i * i, i*i*i);
        }
    }
}
//------------------------------------------------------------