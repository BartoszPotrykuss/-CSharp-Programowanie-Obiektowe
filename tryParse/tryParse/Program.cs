using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tryParse (string napis)
            {
                try
                {
                    Convert.ToInt32 (napis);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            Console.WriteLine(tryParse("-12"));
            Console.ReadKey();
        }
    }
}
