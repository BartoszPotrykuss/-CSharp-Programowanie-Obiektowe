using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaKonstruktor
{
    internal class Program
    {
        
        //zad.1
        class KontoBankowe
        {
            public double StanKonta, DopuszczalnyDebet;
            public string NumerKonta;

            public KontoBankowe()
            {
                StanKonta= 0;
            }
            public KontoBankowe(string NumerKonta,double StanKonta, double DopuszczalnyDebet)
            {
                this.NumerKonta = NumerKonta;
                this.StanKonta = StanKonta;
                this.DopuszczalnyDebet = DopuszczalnyDebet;

            }
            public KontoBankowe(string NumerKonta, double StanKonta)
            {
                this.NumerKonta = NumerKonta;
                this.StanKonta = StanKonta;
                this.DopuszczalnyDebet = 0;
            }
            public KontoBankowe(KontoBankowe kopia)
            {
                this.NumerKonta = kopia.NumerKonta;
                this.StanKonta = kopia.StanKonta;
                this.DopuszczalnyDebet = kopia.DopuszczalnyDebet;

            }
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
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Twój numer konta: {0}", NumerKonta);
                Console.WriteLine("Obecny stan konta: {0}", StanKonta);
                Console.WriteLine("Obecny dopuszczalny debet: {0}", DopuszczalnyDebet);
                Console.WriteLine();
            }
        }
        
        //zad.2
        class Rectangle
        {
            public double a, b;
            public Rectangle()
            {
                a = 1;
                b = 1;
            }
            public Rectangle(double a)
            {
                this.a = a;
                this.b = a;
            }
            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
            }
            public Rectangle (Rectangle kopia)
            {
                this.a = kopia.a;
                this.b = kopia.b;
            }
            public double Field()
            {
                return a * b;
            }
            public double Celebration()
            {
                return 2 * a + 2 * b;
            }
            public double DiagonalLength()
            {
                double c,c2;
                c2 = a*a + b*b;
                c = Math.Sqrt(c2);
                return c;
            }
            public void Wypiszwyniki()
            {
                Console.WriteLine("Dany jest prostokąt o wymiarach {0}x{1}", a, b);
                Console.WriteLine("Pole tego prostokąta jest równe {0}", Field());
                Console.WriteLine("Obwód tego prostokąta jest równe {0}", Celebration());
                Console.WriteLine("Długość przekątnej tego prostokąta jest równe {0}", DiagonalLength());
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            //zad.1
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("zad.1");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            KontoBankowe konto1 = new KontoBankowe();
            KontoBankowe konto2 = new KontoBankowe("PL01234567890123456789012345", 2000, 300);
            KontoBankowe konto3 = new KontoBankowe("PL01234567890123456789012345",6000);
            KontoBankowe konto4 = new KontoBankowe(konto2);
            konto1.NumerKonta = "PL01234567890123456789012345";
            konto1.DopuszczalnyDebet = -500;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Konto numer 1");
            Console.BackgroundColor = ConsoleColor.Black;
            konto1.PodajStanKonta();
            konto1.WykonajWplate();
            konto1.WykonajWyplate();
            konto1.PodajStanKonta();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Konto numer 2");
            Console.BackgroundColor = ConsoleColor.Black;
            konto2.PodajStanKonta();
            konto2.WykonajWplate();
            konto2.WykonajWyplate();
            konto2.PodajStanKonta();
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.Write("Konto numer 3");
            Console.BackgroundColor= ConsoleColor.Black;
            konto3.PodajStanKonta();
            konto3.WykonajWplate();
            konto3.WykonajWyplate();
            konto3.PodajStanKonta();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Konto numer 4 (kopia konta numer 2)");
            Console.BackgroundColor = ConsoleColor.Black;
            konto4.PodajStanKonta();
            konto4.WykonajWplate();
            konto4.WykonajWyplate();
            konto4.PodajStanKonta();
            Console.ReadKey();

            //zad.2
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("zad.2");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Rectangle rec1 = new Rectangle();
            Rectangle rec2 = new Rectangle(5);
            Rectangle rec3 = new Rectangle(3,4);
            Rectangle rec4 = new Rectangle(rec2);
            rec1.Wypiszwyniki();
            rec2.Wypiszwyniki();
            rec3.Wypiszwyniki();
            rec4.Wypiszwyniki();
            Console.ReadKey();
        }
    }
}
