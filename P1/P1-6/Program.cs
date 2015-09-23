using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            simbolis = (char)Console.Read();

            if (simbolis == '+') rezultatas = Sudetis(a, b);
            else if (simbolis == '-') rezultatas = Atimtis(a, b);
            else if (simbolis == '*') rezultatas = Daugyba(a, b);
            else if (simbolis == '/') rezultatas = Dalyba(a, b);
            else rezultatas = "ERROR";

            Console.WriteLine("{0} {1} {2} = {3}", a, simbolis, b, rezultatas);
        }

        static string Sudetis(double a, double b)
        {
            double rezultatas = a + b;
            return rezultatas.ToString();
        }

        static string Atimtis(double a, double b)
        {
            double rezultatas = a - b;
            return rezultatas.ToString();
        }

        static string Daugyba(double a, double b)
        {
            double rezultatas = a * b;
            return rezultatas.ToString();
        }

        static string Dalyba(double a, double b)
        {
            double rezultatas = a / b;
            return rezultatas.ToString();
        }
    }
}
