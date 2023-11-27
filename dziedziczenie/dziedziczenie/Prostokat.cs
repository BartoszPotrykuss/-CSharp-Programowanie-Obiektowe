using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class Prostokat : Figura
    {
        public double a, b;

        public Prostokat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Pole => a * b;
        public override double Obwod()
        {
            double obwod;
            obwod = 2 * a + 2 * b;
            obwod = Math.Round(obwod, 2);
            return obwod;
        }
    }
}
