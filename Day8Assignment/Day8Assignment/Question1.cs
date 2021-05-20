using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment
{
    class Question1
    {
        static void Main()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] arr = { 1, 1, 3, 4, 5, 2, 5, 3, 1, 2, 5, 3, 8 };
            for(int i=0; i<arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] += 1;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }
            foreach(KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine($"Frequency of {kvp.Key} is {kvp.Value} ");
            }
            Console.WriteLine("--------------------------------");
            //using linq
            var freqList = arr.GroupBy(x => x).Select(x => new { x.Key, count = x.Count() });
            foreach(var x in freqList)
            {
                Console.WriteLine(x.Key + " : " +x.count);
            }
            Console.ReadLine();

            
        }
    }
}
