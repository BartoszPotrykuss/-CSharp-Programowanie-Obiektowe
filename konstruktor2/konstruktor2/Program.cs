using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor2
{
    class Punkt
    {
        public int x;
        public int y;
       
        public Punkt(int x) : this(x, 0) { } 
        public Punkt(): this (0,0) { }
        public Punkt(int a, int b)
        {
            x = a;
            y = b;
        }
        public Punkt(Punkt A) 
        {
            this.x = A.x;
            this.y = A.y;
        }
        public void Wypisz()
        {
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(2, 3);
            // Punkt p2 = p1;
            Punkt p2 = new Punkt(p1);
            Console.WriteLine("p1: ");
            p1.Wypisz();
            Console.WriteLine("p2: ");
            p2.Wypisz();
            p1.x = 100;
            Console.WriteLine("Po zmianie\np1: ");
            p1.Wypisz();
            Console.WriteLine("p2: ");
            p2.Wypisz();
            Console.ReadKey();
        }
    }
}
