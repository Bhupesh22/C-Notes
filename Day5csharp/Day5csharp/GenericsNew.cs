using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    public class IPL<T>
    {
        private T data;
        //allowing access by properties
        public T Data 
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    class GenericsNew
    {
        static void Main()
        {
            IPL<string> ipl = new IPL<string>();
            ipl.Data = "Mumbai Indians";

            IPL<int> cric = new IPL<int>();
            cric.Data = 1234;

            Console.WriteLine(ipl.Data);
            Console.WriteLine(cric.Data);
            Console.Read();
        }
    }
}
