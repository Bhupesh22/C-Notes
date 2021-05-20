using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class StackExample
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(23);
            stack.Push(45);
            stack.Push(56);
            stack.Push(89);

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            stack.Pop();

            Console.WriteLine("After poping");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Peek : {0} ", stack.Peek());

            Console.Read();
        }
    }
}
