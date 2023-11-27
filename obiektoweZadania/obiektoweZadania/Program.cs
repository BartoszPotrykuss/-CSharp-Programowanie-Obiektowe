using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektoweZadania
{
    internal class Program
    {
        //zad.1
        class Prostokat
        {
            int dlugosc = 2;
            int szerokosc = 4;
            private int powierzchnia()
            {
                return dlugosc*szerokosc;
            }
            private int obwod()
            {
                return 2 * dlugosc + 2 * szerokosc;
            }
            public void Prezentuj()
            {
                Console.WriteLine("Powierzchnia prostokąta o wymiarach 2x4 jest równa {0}", powierzchnia());
                Console.WriteLine("Obwód prostokąta o wymiarach 2x4 jest równy {0}", obwod());
            }
        }
        //zad.2
        class Punkt
        {
            public int x, y, xPrzesun, yPrzesun;

            public void Przesun()
            {
                x += xPrzesun;
                y += yPrzesun;
            }
            public void Wyswietl()
            {
                Console.WriteLine("Aktualne współrzędne punktu: {0},{1}", x, y);
            }
        }
        //zad.3
        class EnergiaEl
        {
            public int poczatek, biezacy;
            public int zuzytaEnergia()
            {
                return biezacy - poczatek;
            }
            public void wyswietl()
            {
                Console.WriteLine("Początkowy stan licznika: {0} kWh", poczatek);
                Console.WriteLine("Bieżacy stan licznika: {0} kWh", biezacy);
                if (zuzytaEnergia() >= 0)
                    Console.WriteLine("Zużyta energia: {0} kWh", zuzytaEnergia());
                else Console.WriteLine("Zużyta energia: bieżący stan musi być większy od początkowego");
            }
        }
        //zad.4
        class KontoBankowe
        {
            public double NumerKonta,StanKonta, DopuszczalnyDebet, wplata, wyplata;

            public void WykonajWplate()
            {
                StanKonta += wplata;
                Console.WriteLine("Dokonano wpłaty");
            }
            public void WykonajWyplate()
            {
                if (StanKonta - wyplata > DopuszczalnyDebet)
                {
                    StanKonta -= wyplata;
                    Console.WriteLine("Dokonano wypłaty");
                }
                else Console.WriteLine("Nie dokonano wypłaty, ponieważ dopuszczalny debet jest zbyt mały");
            }

            public void PodajStanKonta()
            {
                Console.WriteLine("Obecny stan konta: {0}", StanKonta);
                Console.WriteLine("Obecny dopuszczalny debet: {0}", DopuszczalnyDebet);
            }
        }
        //zad.5
        class Sumator
        {
            public int[] Liczby = new int[10];

            public int Suma()
            {
                int suma = 0;
                for (int i = 0; i < Liczby.Length; i++)
                {
                    suma += Liczby[i];
                }
                return suma;
            }
            public int SumaPodziel3()
            {
                int suma = 0;
                for (int i = 0; i < Liczby.Length; i++)
                {
                    if (Liczby[i] % 3 == 0)
                    suma += Liczby[i];
                }
                return suma;
            }
        }
        static void Main(string[] args)
        {
            //zad.1
            Prostokat p1 = new Prostokat();
            p1.Prezentuj();
            Console.WriteLine();
            Console.WriteLine();

            //zad.2
            Punkt pun1 = new Punkt();
            Console.WriteLine("Podaj x: ");
            pun1.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj y");
            pun1.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ile chcesz zmienić współrzedną x:");
            pun1.xPrzesun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ile chcesz zmienić współrzedną y:");
            pun1.yPrzesun = Convert.ToInt32(Console.ReadLine());
            pun1.Przesun();
            pun1.Wyswietl();
            Console.WriteLine();
            Console.WriteLine();

            //zad.3
            EnergiaEl energiaEl = new EnergiaEl();
            Console.WriteLine("Podaj początkowy stan licznika: ");
            energiaEl.poczatek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj bieżący stan licznika: ");
            energiaEl.biezacy = Convert.ToInt32(Console.ReadLine());
            energiaEl.wyswietl();
            Console.WriteLine();
            Console.WriteLine();

            //zad.4
            KontoBankowe kontoBankowe = new KontoBankowe();
            Console.WriteLine("Podaj numer konta");
            kontoBankowe.NumerKonta = Convert.ToInt32(Console.ReadLine());
            kontoBankowe.StanKonta = 3000;
            kontoBankowe.DopuszczalnyDebet = -500;
            kontoBankowe.PodajStanKonta();
            Console.WriteLine("Ile chcesz wpłacić na konto?");
            kontoBankowe.wplata = Convert.ToInt32(Console.ReadLine());
            kontoBankowe.WykonajWplate();
            Console.WriteLine("Ile chcesz wypłacić z konta");
            kontoBankowe.wyplata = Convert.ToInt32(Console.ReadLine());
            kontoBankowe.WykonajWyplate();
            kontoBankowe.PodajStanKonta();
            Console.WriteLine();
            Console.WriteLine();

            //zad.5
            Sumator sumator = new Sumator();
            for (int i = 0; i < sumator.Liczby.Length; i++)
            {
               sumator.Liczby[i] = i;
            }
            Console.WriteLine("Suma liczb: {0}", sumator.Suma());
            Console.WriteLine("Suma liczb podzielnych przez 3: {0}", sumator.SumaPodziel3());
            Console.ReadKey(); 
        }
    }

}
