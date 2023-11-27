using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_generyczne
{
    //PPP - Push Pop Peek
    public delegate void PPP<T>(T item);
    internal class Stack<T>
    {
       public static List<T> stack = new List<T>();

       public PPP<T> Push = stack.Add;
       public PPP<int> Pop = stack.RemoveAt;

        public void Wypisz()
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }    
        }

    }
}
