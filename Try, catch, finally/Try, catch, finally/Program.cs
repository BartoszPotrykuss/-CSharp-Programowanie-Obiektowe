using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try__catch__finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                WpiszImie();
            }
            catch (BezPolskichZnakow e)
            {
                Console.WriteLine("Kurka wodna! " + e.Message);
            }
            Console.ReadKey();
        }
        public static string WpiszImie()
        {
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            if (imie.Contains('ą'))
            {
                throw new BezPolskichZnakow("Ale z ciebie głąb...");
            }
            return imie;
        }
    }
    class BezPolskichZnakow : Exception
    {
        public BezPolskichZnakow()
        {
            Console.WriteLine("Nie pisz polskich znaków głąbie");
        }
        public BezPolskichZnakow(string message) : base(message)
        {
        }
    }
}
