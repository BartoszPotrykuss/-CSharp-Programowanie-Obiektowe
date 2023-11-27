using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kolejki_i_stosy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean takNIE = true;
            while (takNIE)
            {
                Console.WriteLine("Chcesz sprzedać (wpisz 1) czy kupić (wpisz 2) czy wyjść (wpisz 3)?");
                byte chec = Convert.ToByte(Console.ReadLine());
                if (chec == 1)
                {
                    Console.WriteLine("sprzedaż");
                }
                else if (chec == 2)
                {
                    Console.WriteLine("kupno");
                }
                else if (chec == 3)
                {
                    takNIE = false;
                }
                else Console.WriteLine("Podano złą wartość");
            }


            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            Stack<int> stack0 = new Stack<int>();
            stack0.Push(1);
            stack0.Push(2);
            stack0.Push(3);

            Console.WriteLine("Before reversing:");
            foreach (int i in stack0.ToArray())
            {
                Console.WriteLine(i);
            }

            int[] array = stack0.ToArray();
            array.Reverse();
            stack0 = new Stack<int>(array);

            Console.WriteLine("After reversing:");
            foreach (int i in stack0.ToArray())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            
            Console.ReadKey();
        }
    }
}
