using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2
{
    public class Siena
    {
        private double ilgis, plotis, aukstis;

        public Siena(double ilgis, double plotis, double aukstis)
        {
            this.ilgis = ilgis;
            this.plotis = plotis;
            this.aukstis = aukstis;
        }

        public double GautiIlgiMilimetrais()
        {
            double ilgisMilimetrais = this.ilgis*1000;
            return ilgisMilimetrais;
        }

        public double GautiPlotiMilimetrais()
        {
            double plotisMilimetrais = this.plotis*1000;
            return plotisMilimetrais;
        }

        public double GautiAukstiMilimetrais()
        {
            double aukstisMilimetrais = this.aukstis*1000;
            return aukstisMilimetrais;
        }
    }
}
