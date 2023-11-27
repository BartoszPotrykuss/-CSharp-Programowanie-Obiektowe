using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacja_JSON
{
    internal class Gracz
    {

        public Gracz(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public string name { get; set; }
        public int level { get; set; }
    }
}
