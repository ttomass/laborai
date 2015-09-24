using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plyta plyta1 = new Plyta(250, 120, 88);
            Plyta plyta2 = new Plyta(240, 115, 71);
            Plyta plyta3 = new Plyta(240, 115, 61);
            Siena siena = new Siena(12, 0.23, 3);
            Console.WriteLine("Į sieną pirmo tipo plytų telpa: {0}", SkaiciuotiPlytomis(plyta1, siena));
            Console.WriteLine("Į sieną antro tipo plytų telpa: {0}", SkaiciuotiPlytomis(plyta2, siena));
            Console.WriteLine("Į sieną trečio tipo plytų telpa: {0}", SkaiciuotiPlytomis(plyta3, siena));
        }

        static int SkaiciuotiPlytomis(Plyta plyta, Siena siena)
        {
            int plytosTuris, sienaPlytomis, viso;
            double sienosTuris;
            sienosTuris = siena.GautiAukstiMilimetrais()*siena.GautiIlgiMilimetrais()*siena.GautiPlotiMilimetrais();
            plytosTuris = plyta.GautiAuksti()*plyta.GautiIlgi()*plyta.GautiPloti();
            sienaPlytomis = (int) (sienosTuris/plytosTuris);
            viso = 4*sienaPlytomis;
            return viso;
        }
    }
}
