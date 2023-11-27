using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Program
    {
        class produkt
        {
            public string nazwa;
            public int sztuki;
            public int kod;

            public produkt(string nazwa, int sztuki, int kod)
            {
                this.nazwa = nazwa;
                this.sztuki = sztuki;
                this.kod = kod;
            }

            public int zmienSztuki(int zmienSZ)
            {
                if (sztuki + zmienSZ > 0)
                {
                    sztuki += zmienSZ;
                }
                else Console.WriteLine("Za mało produktów");
                return sztuki;
            }
            public int zmienKod(int zmienK)
            {
                if (zmienK != 0)
                {
                    kod = zmienK;
                }
                return kod;
            }

            public void obecnyStan()
            {
                Console.WriteLine();
                Console.WriteLine("Nazwa: {0}", nazwa);
                Console.WriteLine("Liczba sztuk: {0}", sztuki);
                Console.WriteLine("Kod produktu: {0}", kod);
            }
        }
        static void Main(string[] args)
        {
            Boolean takNIE = true;
            while (takNIE)
            { 
                Console.WriteLine();
                Console.WriteLine("Czy chcesz dodać nowy produkt do magazynu (tak/nie)?");
                string dodanie = Console.ReadLine();
                if (dodanie == "tak") takNIE = true;
                else if (dodanie == "nie")
                {
                    takNIE = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Podano złą wartość");
                    continue;
                }
                string nazwa;
                int sztuki;
                int kod;
                Console.WriteLine("Dodaj produkt do magazynu");
                Console.WriteLine("Nazwa: ");
                nazwa = Console.ReadLine();
                Console.WriteLine("Sztuki: ");
                sztuki = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj kod produktu: ");
                kod = Convert.ToInt32(Console.ReadLine());
                produkt prod1 = new produkt(nazwa, sztuki, kod);
                prod1.obecnyStan();
                Console.WriteLine();
                Console.WriteLine("O ile chcesz zmienić ilość produktu w magazynie?");
                prod1.zmienSztuki(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Czy chcesz zmienić kod produktu (jeśli nie wpisz zero, jeśli tak wpisz nowy kod)?");
                prod1.zmienKod(Convert.ToInt32(Console.ReadLine()));
                prod1.obecnyStan();
                Console.ReadKey();
            }
        }
    }
}
