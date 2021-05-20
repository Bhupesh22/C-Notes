using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class DictionaryExample
    {
        static void Main()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] arr = { 1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1 };

            for(int i=0; i<arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] += 1;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }

            Console.WriteLine("Order by value");
            foreach(KeyValuePair<int, int> kvp in dict.OrderBy(d => d.Value))
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }

            Console.ReadLine();

        }
    }
}
