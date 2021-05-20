using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class BaseDervied
    {
        public int a;
        public BaseDervied(int a)
        {
            this.a = a;             //this - : refers to the current object
        }
    }
    class Derived : BaseDervied
    {
        public int b;

        public Derived( int y) : base(y)
        {
            b = y;
        }
        public Derived(int y, int z) : base(z)
        {
            b = y;
        }
    }
    class check
    {
        static void Main()
        {
            BaseDervied bd = new BaseDervied(5);
            BaseDervied bd1;
            Derived d = new Derived(10);
            Derived d1 = new Derived(4, 5);
            bd1 = bd; //possibel bcz both are of same data type
            Console.WriteLine("BD:{0}", bd.a);
            Console.WriteLine("BD1:{0}", bd1.a);
            Console.WriteLine("D:{0}", d.b);
            Console.WriteLine("D1: A {0}  B {1}", d1.a, d1.b);
            Console.Read();

        }
    }
}
