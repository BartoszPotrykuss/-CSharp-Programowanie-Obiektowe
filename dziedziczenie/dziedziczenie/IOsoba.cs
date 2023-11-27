using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal interface IOsoba
    {
        string Nazwa { get; set; }
        void Opisz();
    }
}
