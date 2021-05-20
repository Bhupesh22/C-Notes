using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 10;
            var x = "Hello";
            x = "abc";
            Console.WriteLine(x);
            //x = 10; not possible x is fixed to be string
            dynamic d;
            d = 10;
            d = "Bhupesh"; // possible bcz dynamic
            Console.Read();
        }
    }
}
