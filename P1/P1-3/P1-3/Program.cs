using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------
// Funkcijos reikšmės skaičiavimas
//------------------------------------------------------------
namespace funkcijos_reiksmes
{
    class Program
    {
        static void Main(string[] args)
        {
            double fxy;
            int x, y;

            Console.Write("Įveskite x reikšmę: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Įveskite y reikšmę: ");
            y = int.Parse(Console.ReadLine());

            if ( Math.Pow(x, 3) - y != 0)
            {
                fxy = (Math.Pow(y, 2) - 2*y*x + Math.Pow(x, 2))/(Math.Pow(x, 3) - y); // Matematinių funkcijų klasė
                Console.WriteLine(" x = {0}, y = {1} f(x) = {2 ,8:f3}", x, y, fxy);
            }
            else
                Console.WriteLine(" x = {0}, y = {1} f-ja neegzistuoja", x, y);
        }
    }
}
//------------------------------------------------------------