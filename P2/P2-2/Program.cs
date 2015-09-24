using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sienomsReiks, bokstamsReiks, visoReiks;

            Plyta plyta = new Plyta(250, 120, 88);
            Siena siena1 = new Siena(12, 0.25, 3);
            Siena siena2 = new Siena(14, 0.30, 4);
            Siena siena3 = new Siena(10, 0.27, 2);
            Siena siena4 = new Siena(13, 0.20, 5);
            Bokstas bokstas1 = new Bokstas(12, 0.27, 1);
            Bokstas bokstas2 = new Bokstas(13, 0.29, 1.1);
            Bokstas bokstas3 = new Bokstas(14, 0.30, 1.5);
            Bokstas bokstas4 = new Bokstas(15, 0.35, 2);

            sienomsReiks = sienaPlytomis(plyta, siena1) + sienaPlytomis(plyta, siena2) + sienaPlytomis(plyta, siena3) +
                           sienaPlytomis(plyta, siena4);
            bokstamsReiks = bokstasPlytomis(plyta, bokstas1) + bokstasPlytomis(plyta, bokstas2) +
                            bokstasPlytomis(plyta, bokstas3) + bokstasPlytomis(plyta, bokstas4);
            visoReiks = sienomsReiks + bokstamsReiks;
            Console.WriteLine("Iš viso reikės plytų: {0}", visoReiks);
        }

        private static int sienaPlytomis(Plyta plyta, Siena siena)
        {
            int plytosTuris, sienaPlytomis;
            double sienosTuris;
            sienosTuris = siena.GautiAukstiMilimetrais()*siena.GautiPlotiMilimetrais()*siena.GautiIlgiMilimetrais();
            plytosTuris = plyta.ilgis*plyta.plotis*plyta.aukstis;
            sienaPlytomis = (int) (sienosTuris/plytosTuris);
            return sienaPlytomis;
        }

        static int bokstasPlytomis(Plyta plyta, Bokstas bokstas)
        {
            int plytosTuris, bokstasPlytomis;
            double bokstoSienosTuris;
            bokstoSienosTuris = Math.PI * bokstas.GautiSkersmeniMilimetrais()*  bokstas.GautiAukstiMilimetrais() * bokstas.GautiStoriMilimetrais();
            plytosTuris = plyta.ilgis * plyta.plotis * plyta.aukstis;
            bokstasPlytomis = (int)(bokstoSienosTuris / plytosTuris);
            return bokstasPlytomis;
        }
    }
}
