using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class AllGenerics<T>
    {
        private T genericmember;

        public T GenericMember { get; set; }

        public AllGenerics(T val)
        {
            genericmember = val;    
        }

        
        public T genericmethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type {0} , Value {1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return Type {0} , Value {1}", typeof(T).ToString(), genericmember);
            return genericmember;

        }

    }
    class test 
    {
        static void Main()
        {
            AllGenerics<int> alg = new AllGenerics<int>(45);
            int x = alg.genericmethod(45);

            AllGenerics<string> algstr = new AllGenerics<string>("Bhupesh");
            string zz = algstr.genericmethod("Bhupesh");

            Console.ReadLine();
        } 
        
    }

}
