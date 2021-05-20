using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class GenericList
    {
        static void Main()
        {
            List<int> list = new List<int>();
            for(int i=0; i<10; i++)
            {
                list.Add(i);
            }
            for(int i=0; i<list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.Read();
        }
    }
}
