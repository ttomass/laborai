using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string rezultatas;
            char simbolis;
            Console.Write("Įveskite pirmą skaičių: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Įveskite operacijos simbolį: ");
            simbolis = (char) Console.Read();

            if (simbolis == '+') rezultatas = (a + b).ToString();
            else if (simbolis == '-') rezultatas = (a - b).ToString();
            else if (simbolis == '*') rezultatas = (a*b).ToString();
            else if (simbolis == '/') rezultatas = (a/b).ToString();
            else rezultatas = "ERROR";

            Console.WriteLine("{0} {1} {2} = {3}", a, simbolis, b, rezultatas);
        }
    }
}
