using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2
{
    public class Bokstas
    {
        private double aukstis, storis, skersmuo;

        public Bokstas(double aukstis, double storis, double skersmuo)
        {
            this.aukstis = aukstis;
            this.storis = storis;
            this.skersmuo = skersmuo;
        }

        public double GautiAukstiMilimetrais()
        {
            double aukstisMilimetrais = this.aukstis*1000;
            return aukstisMilimetrais;
        }

        public double GautiStoriMilimetrais()
        {
            double storisMilimetrais = this.storis*1000;
            return storisMilimetrais;
        }

        public double GautiSkersmeniMilimetrais()
        {
            double skersmuoMilimetrais = this.skersmuo*1000;
            return skersmuoMilimetrais;
        }
    }
}
