using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day6CSharp
{
    public delegate int delcal(int x); 
    class Sample
    {
        static int p;

        public int square(int a)
        {
            p = a * a;
            Console.WriteLine($"Square : {p}");
            return p;
        }
        public int cube(int a)
        {
            p = a * a * a;
            Console.WriteLine($"Cube : {p}");
            return p;
        }
    }
    class MulticaseExample
    {
        static void Main()
        {
            Sample s = new Sample();
            
            delcal del1 = new delcal(s.square);
            delcal del2 = new delcal(s.cube);
            delcal del = del1 + del2;
            //del -= del2; will remove cube and only give square
            int f = del(5); //this will give the most recent delegate 
            Console.WriteLine($"After returning {f}");
            Console.ReadLine();

        }
    }
}
