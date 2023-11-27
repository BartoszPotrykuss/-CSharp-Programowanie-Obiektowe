using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace wektor
{
    internal class Program
    {
        class Wektor
        {
            public int[] tab = new int[3];
            public int n = 3;


            public Wektor()
            {
                for (int i = 0; i < n; i++)
                {
                    tab[i] = 0;
                }
            }

            public Wektor(int x1, int x2, int x3)
            {
                tab[0] = x1;
                tab[1] = x2;
                tab[2] = x3;
            }

            public Wektor(Wektor wektor)
            {
                tab = wektor.tab;

            }


            public int[] Wczytaj(int x1, int x2, int x3)
            {
                tab[0] = x1;
                tab[1] = x2;
                tab[2] = x3;
                return tab;
            }

            public void Wyswietl()
            {
                Console.WriteLine("Współrzędne: [{0}, {1}, {2}]", tab[0], tab[1], tab[2]);
            }

            public void DlugoscWektora()
            {
                int dlugosc;
                dlugosc = tab[0] + tab[1] + tab[2];
                Console.WriteLine("Długość: {0}", dlugosc);
            }

            public Wektor SumaWektorow(Wektor pierwszy)
            {
                Wektor WektorSuma = new Wektor();
                WektorSuma.tab[0] = this.tab[0] + pierwszy.tab[0];
                WektorSuma.tab[1] = this.tab[1] + pierwszy.tab[1];
                WektorSuma.tab[2] = this.tab[2] + pierwszy.tab[2];
                return WektorSuma;
            }
    }
    static void Main(string[] args)
        {
            Wektor a = new Wektor(1, 2, 3);
            Wektor b = new Wektor(4, 5, 6);
            Wektor c = new Wektor();
            Wektor d = new Wektor();
            Wektor e = new Wektor();
            c = a.SumaWektorow(b);
            d = b.SumaWektorow(c);
            e = c.SumaWektorow(d);
            Console.WriteLine("Wektor a: ");
            a.DlugoscWektora();
            Console.WriteLine("Wektor b: ");
            b.DlugoscWektora();
            Console.WriteLine("Wektor c: ");
            c.DlugoscWektora();
            c.Wyswietl();
            Console.WriteLine("Wektor d: ");
            d.DlugoscWektora();
            d.Wyswietl();
            Console.WriteLine("Wektor e: ");
            e.DlugoscWektora();
            e.Wyswietl();
            Console.ReadKey();
        }
    }
}
