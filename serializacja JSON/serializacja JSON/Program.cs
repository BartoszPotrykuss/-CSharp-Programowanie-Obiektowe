using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace serializacja_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string g1Serialized = File.ReadAllText(@"E:\JSON\g1Serialized.json");
            Gracz g1 = JsonConvert.DeserializeObject<Gracz>(g1Serialized);

            while (true)
            {
                Console.WriteLine($"Aby wbić level wpisz kolejną liczbę. Poprzednia to {g1.level}");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba != g1.level + 1)
                {
                    Console.WriteLine("Błąd!");
                    break;
                }
                g1.level++;
            }

            g1Serialized = JsonConvert.SerializeObject(g1);

            File.WriteAllText(@"E:\JSON\g1Serialized.json", g1Serialized);

            Console.ReadKey();

        }
    }
}
