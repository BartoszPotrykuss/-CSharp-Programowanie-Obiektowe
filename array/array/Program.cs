using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość elementów dla tablicy: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[x];
            Console.WriteLine("Podaj zawartość tablicy: ");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Czy tablica ma stały rozmiar?");
            Console.WriteLine(tab.IsFixedSize);
            Console.WriteLine("Czy tablica jest tylko do odczytu?");
            Console.WriteLine(tab.IsReadOnly);
            Console.WriteLine("Ilość elementów w tablicy: ");
            Console.WriteLine(tab.Length);
            Console.WriteLine("Liczba wymiarów tablicy");
            Console.WriteLine(tab.Rank);
            int[] tab2 = new int[x];
            Array.Copy(tab, 0, tab2, 0, tab.Length);
            Console.WriteLine("Kopia tablicy: ");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                    Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Dolna granica pierwszego wymiaru tablicy: ");
            Console.WriteLine(tab.GetLowerBound(0));
            Console.WriteLine("Typ bieżącej instancji: ");
            Console.WriteLine(tab.GetType());
            Console.WriteLine("Górna granica pierwszego wymiaru tablicy: ");
            Console.WriteLine(tab.GetUpperBound(0));
            Console.WriteLine("Wartość na pierwszej pozycji w jednowymiarowej tablicy: ");
            Console.WriteLine(tab.GetValue(0));
            Console.WriteLine("Sprawdza na której pozycji jest 1, jeśli nie ma to zwraca -1: ");
            Console.WriteLine(Array.IndexOf(tab , 1));
            tab.SetValue(0, 0);
            Console.WriteLine("Pierwszy element tablicy został zmieniony na 0");
            Console.WriteLine(tab[0]);
            Console.WriteLine("Odwrócona tablica: ");
            Array.Reverse(tab);
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine() ;
            Array.Sort(tab);
            Console.WriteLine("Posortowana tablica: ");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Wszystkie elementy ustawione na zero: ");
            Array.Clear(tab, 0, tab.Length);
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
