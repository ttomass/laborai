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
            Siena siena1 = new Siena(12, 0.25, 3);
            Siena siena2 = new Siena(14, 0.25, 4);
            Siena siena3 = new Siena(10, 0.25, 2);
            Siena siena4 = new Siena(13, 0.25, 5);

            int pirmoTipoPlytos = SkaiciuotiPlytomis(plyta1, siena1) + SkaiciuotiPlytomis(plyta1, siena2) +
                                  SkaiciuotiPlytomis(plyta1, siena3) + SkaiciuotiPlytomis(plyta1, siena4);
            int antroTipoPlytos = SkaiciuotiPlytomis(plyta2, siena1) + SkaiciuotiPlytomis(plyta2, siena2) +
                      SkaiciuotiPlytomis(plyta2, siena3) + SkaiciuotiPlytomis(plyta2, siena4);
            Console.WriteLine("Iš viso pirmo tipo plytų reiks: {0}", pirmoTipoPlytos);
            Console.WriteLine("Iš viso antro tipo plytų reiks: {0}", antroTipoPlytos);
        }

        static int SkaiciuotiPlytomis(Plyta plyta, Siena siena)
        {
            int plytosTuris, sienaPlytomis;
            double sienosTuris;
            sienosTuris = siena.GautiAukstiMilimetrais()*siena.GautiIlgiMilimetrais();
            plytosTuris = plyta.GautiAuksti()*plyta.GautiIlgi();
            sienaPlytomis = (int) (sienosTuris/plytosTuris);
            return sienaPlytomis;
        }
    }
}
