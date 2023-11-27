using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy__equals__compare
{
    internal class Program
    {
        class Dane : IComparable
        {
            public string imie, nazwisko;
            public int wiek;
            public Dane(string imie, string nazwisko, int wiek)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.wiek = wiek;
            }

            public bool Equals (Dane osoba)
            {
                return this.imie == osoba.imie && this.nazwisko == osoba.nazwisko;
            }

            public int CompareTo(object obj)
            {
                var arg = (Dane) obj;
                if (wiek < arg.wiek)
                    return -1;
                else if (wiek == arg.wiek)
                    return 0;
                return 1;
            }

            
        }
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Console.WriteLine(lista.Contains(1));

            Dane osoba1 = new Dane("Wojciech", "Kowal", 41);
            Dane osoba2 = new Dane("Wojciech", "Kowal", 19);
            Console.WriteLine(osoba1.Equals(osoba2));
            
            List<Dane> listaOsob = new List<Dane> {osoba1, osoba2};
            foreach (Dane item in listaOsob)
            {
                Console.WriteLine(item.wiek);
            }
            Console.WriteLine();
            Console.WriteLine();
            listaOsob.Sort();
            foreach (Dane item in listaOsob)
            {
                Console.WriteLine(item.wiek);
            }
            Console.ReadKey();
        }
    }
}
