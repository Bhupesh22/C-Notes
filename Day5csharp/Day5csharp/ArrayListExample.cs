using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class ArrayListExample
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("Bhupesh");
            arr.Add(12.3f);

            foreach(var x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Length : {0}", arr.Count);
            Console.WriteLine("Capacity : {0}", arr.Capacity);

            arr.Insert(2, 10672);

            Console.WriteLine("Contains Bhupesh : {0}", arr.Contains("Bhupesh"));

            arr.Reverse();
            foreach(var x in arr){
                Console.Write(x + " ");
            }
            Console.WriteLine();

            arr.Remove("Bhupesh");
            arr.RemoveAt(1);
            
            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            ArrayList arr2 = new ArrayList() { 1, 2, 3, 4, 5 ,6, 7, 8};
            arr.InsertRange(arr.Count, arr2);

            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            arr2.Reverse();
            foreach (int x in arr2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Length : {0}", arr.Count);
            Console.WriteLine("Capacity : {0}", arr.Capacity);

            Console.ReadLine();
        }
    }
}
