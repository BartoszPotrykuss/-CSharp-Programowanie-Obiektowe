using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class Student : IOsoba, IComparable
    {
        public Student(string nazwa)
        {
            Nazwa = nazwa;
        }

        public string Nazwa { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Student otherStudent)
            {
                return Nazwa.CompareTo(otherStudent.Nazwa);
            }
            throw new ArgumentException("Obiekt nie jest typu Student");
        }

        public void Opisz()
        {
            Console.WriteLine($"Jestem studentem o imieniu {Nazwa}");
        }
    }
}
