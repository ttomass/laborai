using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------
// Sudėtingas if sakinys
//------------------------------------------------------------
namespace sudetingas_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double fx;
            double x;
            Console.Write(" Įveskite x reikšmę: ");
            x = double.Parse(Console.ReadLine());
            Console.Clear(); // Išvalo langą
            Console.SetCursorPosition(5, 6); // Nustato pradinę žymeklio padėtį
            if (x >= -2 && x <= 0)
                fx = Math.Exp(-x);
            else
                if (x > 0 && x <= 2)
                    fx = 2 * Math.Pow(x, 2) + 1;
                else
                    fx = Math.Pow(x , -2);
            Console.WriteLine("Reikšmė x = {0,3:f2}, fx = {1,5:f3}", x, fx);
        }
    }
}
//------------------------------------------------------------