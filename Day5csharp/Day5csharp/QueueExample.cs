using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class QueueExample
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }
            queue.Dequeue();

            Console.WriteLine("After dequeue : ");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Count : {0}", queue.Count);

            foreach(object o in queue)
            {
                Console.WriteLine(o);
            }

            Console.Read();
        }
    }
}
