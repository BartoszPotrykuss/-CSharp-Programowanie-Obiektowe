using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amfiteatr
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[][] tab = new int[][]
            {
                new int[13],
                new int[17],
                new int[21],
                new int[25],
            };
            Console.WriteLine("SPRZEDAŻ BILETÓW");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Rząd numer {0} : ", i+1);
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = j+1;
                    Console.Write(tab[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Rząd 1 - 100zł");
            Console.WriteLine("Rząd 2 - 60zł");
            Console.WriteLine("Rząd 3 - 35zł");
            Console.WriteLine("Rząd 4 - 20zł");
            int rzad, miejsce;
            Console.WriteLine("Podaj rząd, w którym chcesz kupić bilet: ");
            rzad = Convert.ToInt32(Console.ReadLine());
            if (rzad <= 4 && rzad >= 1)
            {
                Console.WriteLine("Podaj miejsce w rzędzie numer {0}, które chcesz zarezerwować:", rzad);
                miejsce = Convert.ToInt32(Console.ReadLine());
                switch (rzad)
                {
                    case 1:
                        if (miejsce >= 1 && miejsce <= 13)
                        {
                            Console.WriteLine("Zarezerwowano miejsce {0} w rzędzie numer {1}. \n Koszt: 100zł.", rzad, miejsce);
                        }
                        else Console.WriteLine("Błąd! Podaj liczbę w przedziale od 1 do 13");
                        break;
                    case 2:
                        if (miejsce >= 1 && miejsce <= 17)
                        {
                            Console.WriteLine("Zarezerwowano miejsce {0} w rzędzie numer {1}. \n Koszt: 60zł.", rzad, miejsce);
                        }
                        else Console.WriteLine("Błąd! Podaj liczbę w przedziale od 1 do 17");
                        break;
                    case 3:
                        if (miejsce >= 1 && miejsce <= 21)
                        {
                            Console.WriteLine("Zarezerwowano miejsce {0} w rzędzie numer {1}. \n Koszt: 35zł", rzad, miejsce);
                        }
                        else Console.WriteLine("Błąd! Podaj liczbę w przedziale od 1 do 21");
                        break;
                    case 4:
                        if (miejsce >= 1 && miejsce <= 25)
                        {
                            Console.WriteLine("Zarezerwowano miejsce {0} w rzędzie numer {1}. \n Koszt: 20zł", rzad, miejsce);
                        }
                        else Console.WriteLine("Błąd! Podaj liczbę w przedziale od 1 do 25.");
                        break;
                }
            }
            else Console.WriteLine("Błąd! Podaj liczbę w przedziale od 1 do 4");
            Console.ReadKey();
        }
    }
}
