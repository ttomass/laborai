using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1
{
    public class Plyta
    {
        private int ilgis, plotis, aukstis;

        public Plyta(int ilgis, int plotis, int aukstis)
        {
            this.ilgis = ilgis;
            this.plotis = plotis;
            this.aukstis = aukstis;
        }

        public int GautiIlgi()
        {
            return ilgis;
        }
        public int GautiPloti()
        {
            return plotis;
        }
        public int GautiAuksti()
        {
            return aukstis;
        }
    }
}
