using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_generyczne
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(42);
            stack.Push(43);
            stack.Pop(1);
            stack.Wypisz();

            Console.ReadKey();
        }
    }
}
