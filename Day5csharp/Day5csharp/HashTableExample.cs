using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class HashTableExample
    {
        static void Main()
        {
            //Unordered, key can be of any type
            Hashtable hash = new Hashtable();
            hash.Add(1, "Bhupesh");
            hash.Add(3, "Akshay");
            hash.Add(2, "Rahul");
            hash.Add(4, "Rishabh");
            hash.Add(9, null);

            hash[2] = "Ram";

            //keys
            foreach(var i in hash.Keys)
            {
                Console.WriteLine(i + " : " + hash[i]);
            }
            //values
            for(int i=0; i<hash.Count; i++)
            {
                Console.Write(hash[i]+" ");
            }
            Console.WriteLine();

            //to get key and value
            foreach(DictionaryEntry de in hash)
            {
                Console.WriteLine(de.Key + " : " + de.Value);
            }
            Console.WriteLine();


            SortedList sl = new SortedList();
            sl.Add(2, 20);
            sl.Add(1, 40);


            foreach(var i in sl.Keys)
            {
                Console.WriteLine(i + " : " + sl[i]);
            }
            //can also use DictionaryEntry

            Console.Read();
            
        }
    }
}
