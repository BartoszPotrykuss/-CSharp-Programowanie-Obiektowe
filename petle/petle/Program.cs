using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz numer zadania, które chcesz zobaczyć:");
            byte num_zad;
            num_zad = Convert.ToByte(Console.ReadLine());
            switch (num_zad)
            {
                case 1:
                    int a1, b1;
                    Console.WriteLine("Podaj mniejszą liczbę:");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj większą liczbę:");
                    b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Liczby parzyste z zbioru od {0} do {1} to:", a1, b1);
                    for (int i = a1; i <= b1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 2:
                    int n;
                    float silnia;
                    silnia = 1;
                    Console.WriteLine("Podaj liczbę do silni:");
                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        silnia *= i;
                    }
                    Console.WriteLine("Silnia z {0} jest równa: {1}", n, silnia);
                    break;
                case 3:
                    byte suma, licznik;
                    licznik = 1;
                    suma = 0;
                    for (byte i = 1; suma<=100; i++ )
                    {
                        suma +=  i;
                        licznik = i;
                    }
                    Console.WriteLine("Należy dodać do siebie {0} kolejnych liczb całkowitych (rozpoczynając od wartości 1) należy dodać do siebie, aby suma przekroczyła wartość 100.", licznik);
                    break;
                case 4:
                    int a4 = 1, suma4 = 0;
                    while (a4 != 0)
                    {
                        Console.WriteLine("Wprowadź liczbę:");
                        a4 = Convert.ToInt32(Console.ReadLine());
                        suma4 += a4;
                    }
                    Console.WriteLine("Suma podanych liczb jest równa {0}", suma4);
                    break;
                default:
                    Console.WriteLine("Zły numer zadania. Podaj numer od 1 do 5");
                    break;
                case 5:
                    Console.WriteLine("Figura numer 1: ");
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Figura numer 2: ");
                    for (int i = 4; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Figura numer 3: ");
                    int x = 3;
                    for (int i = 1; i <= 7; i++)
                    {
                        if (i % 2 == 0)
                            continue;
                        int z = 0;
                        while (z< x)
                        {
                            z++;
                            Console.Write(" ");
                        }
                        x--;
                        for (int j = 1; j <= i; j++)
                        {
                                Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Figura numer 5: ");

                    int a = 4, b = 4;
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            if (i < a - 1 && i > 0 && j < b - 1 && j > 0)
                                Console.Write(" ");
                            else
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}

