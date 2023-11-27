using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania_klasy
{
    internal class Program
    {
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
                Przesun();
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
            public double StanKonta, DopuszczalnyDebet;
            public string NumerKonta;

            public void WykonajWplate()
            {
                double wplata;
                Console.WriteLine("Ile chcesz wpłacić na konto?");
                wplata = Convert.ToDouble(Console.ReadLine());
                StanKonta += wplata;
                Console.WriteLine("Dokonano wpłaty");
                
            }
            public void WykonajWyplate()
            {
                double wyplata;
                Console.WriteLine("Ile chcesz wypłacić z konta");
                wyplata = Convert.ToDouble(Console.ReadLine());
                if (StanKonta - wyplata > DopuszczalnyDebet)
                {
                    StanKonta -= wyplata;
                    Console.WriteLine("Dokonano wypłaty");
                }
                else Console.WriteLine("Nie dokonano wypłaty, ponieważ dopuszczalny debet jest zbyt mały");
            }

            public void PodajStanKonta()
            {
                Console.WriteLine("Twój numer konta: {0}", NumerKonta);
                Console.WriteLine("Obecny stan konta: {0}", StanKonta);
                Console.WriteLine("Obecny dopuszczalny debet: {0}", DopuszczalnyDebet);
            }
        }
        //zad.5
        class Sumator
        {
            public static int rozmiar()
            {
                Console.WriteLine("Podaj ilość elementów w tablicy:");
                int dlugosc = Convert.ToInt16(Console.ReadLine());
                return dlugosc;
            }
                  
            public int[] Liczby = new int[rozmiar()];

            public void podajLiczbyDoTablicy()
            {
                for (int i = 0; i < Liczby.Length; i++)
                {
                    Console.WriteLine("Podaj {0} element tablicy:", i+1);
                    Liczby[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Twoja tablica: ");
                for (int i = 0; i < Liczby.Length; i++)
                {
                    Console.Write(Liczby[i] + ", ");
                }
            }
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
            /*
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
            kontoBankowe.NumerKonta = "PL01234567890123456789012345";
            kontoBankowe.StanKonta = 3000;
            kontoBankowe.DopuszczalnyDebet = -500;
            kontoBankowe.PodajStanKonta();
            kontoBankowe.WykonajWplate();
            kontoBankowe.WykonajWyplate();
            kontoBankowe.PodajStanKonta();
            Console.WriteLine();
            Console.WriteLine();
            */
            //zad.5
            Sumator sumator = new Sumator();
            
            Console.WriteLine("Liczby: ");
            sumator.podajLiczbyDoTablicy();
            Console.WriteLine();
            Console.WriteLine("Suma tych liczb: {0}", sumator.Suma());
            Console.WriteLine("Suma tych liczb podzielnych przez 3: {0}", sumator.SumaPodziel3());
            Console.ReadKey();
        }
    }
}
