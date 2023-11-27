using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace konstruktor
{
    public class Punkt
    {
        public int x, y;
        public Punkt(int x, int y) 
        {
            this.x= x;
            this.y= y;
          
        }
        public Punkt(int z) 
        {
           x= z;
          
        }
        public Punkt()
        {
            y = 1;
        }
        ~Punkt()
        {
            Console.WriteLine("Destrukcja punktu ({0},{1})", x, y);
            Console.ReadKey();
        }
        public void Wypisz()
        {
            Console.WriteLine("Współrzędne punktu: ({0},{1})", x, y);
        }
        public void Wypisz(string nazwa)
        {
            Console.WriteLine("Współrzędne punktu {0}: ({1},{2})", nazwa, x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1= new Punkt(1,2);
            Punkt p2= new Punkt(5);
            Punkt p3= new Punkt();
            p1.Wypisz();
            p2.Wypisz();
            p3.Wypisz();
            p1.Wypisz("p1");
            p2.Wypisz("p2");
            p3.Wypisz("p3");
            Console.ReadKey();
        }
    }
}
