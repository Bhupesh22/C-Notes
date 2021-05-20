using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjSecond
{
    class ArrayEx
    {
        static void Main()
        {
            //datatype[] array_name = new data_type[size];
            string[] Fruits = new string[5];

            Console.WriteLine("Enter 5 fruits name :");
            for(int i=0; i< Fruits.Length; i++)
            {
                Console.WriteLine("Enter value of Fruits at i {0}", i);
                Fruits[i] = Console.ReadLine();
            }

            for(int i=0; i<Fruits.Length; i++)
            {
                Console.WriteLine("Value at {0} is {1}", i, Fruits[i]);
            }
            
            
            Array.Sort(Fruits);
            Console.WriteLine("After sorting");
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine(Fruits[i]);
            }

            bool isPresent = Fruits.Contains("Apple");
            Console.WriteLine(isPresent);

            Console.Read();
        }
    }
}
