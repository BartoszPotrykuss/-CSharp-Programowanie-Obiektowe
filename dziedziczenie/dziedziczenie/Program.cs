using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Kolo k1 = new Kolo(2);
            Console.WriteLine(k1.Obwod());
            Console.WriteLine(k1.Pole);

            Prostokat p1 = new Prostokat(2, 5);
            Console.WriteLine(p1.Obwod());
            Console.WriteLine(p1.Pole);

            Console.WriteLine();

            Student s1 = new Student("Zbychu");
            Student s2 = new Student("Jareczek");
            Student s3 = new Student("Donald");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(s1);
            arrayList.Add(s2);
            arrayList.Add(s3);
            arrayList.Sort();
            foreach (Student s in arrayList)
            {
                ((IOsoba)s).Opisz();
            }
            Console.ReadKey();
        }
    }
}
