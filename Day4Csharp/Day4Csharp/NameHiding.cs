using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class A1
    {
        public int i = 0;
        public void Method1 (string s)
        {
            Console.WriteLine("Message from A1 :{0}", s);
        }
    }
    class B1 : A1
    {
        new int i; //hiding variable from base class i.e diff value than base 

        public B1(int a , int b)
        {
            base.i = a;
            i = b;
        }
        new public void Method1 (string s) //hiding method from base class
        {
            Console.WriteLine("Message from A1 :{0}", base.i);
            Console.WriteLine("Message from B1 : {0} ", i);
        }
    }
    class NameHiding
    {
        static void Main()
        {
            B1 bobj = new B1(4, 15);
            //Console.WriteLine(bobj.i);
            bobj.Method1("Hello from B1");
            Console.ReadLine();
        }
    }
}
