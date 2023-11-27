using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacje_na_plikach_txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"plik.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik został utworzony");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Plik został otwarty");
            }
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZAWARTOŚĆ PLIKU");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();
            
            Console.ReadKey();
        }
    }
}
