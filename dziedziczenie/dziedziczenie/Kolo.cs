using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class Kolo : Figura
    {
        public double r;
        public double pi = Math.PI;

        public override double Pole { get { return Math.Round(pi * r * r, 2); } }

        public Kolo(int r)
        {
            this.r = r;
        }

        public override double Obwod()
        {
            double obwod;
            obwod = 2 * pi * r;
            obwod = Math.Round(obwod, 2);
            return obwod;
        }


    }
}
