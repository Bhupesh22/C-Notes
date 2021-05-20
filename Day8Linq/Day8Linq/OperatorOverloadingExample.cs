using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Linq
{
    class Dist
    {
        public int dist;
        public int Dists
        {
            get { return dist; }
            set { dist = value; }
        }
        public static Dist operator + (Dist d1, Dist d2)
        {
            Dist temp = new Dist();
            temp.Dists = d1.Dists + d2.Dists;
            return temp;
        }
    }
    class OperatorOverloadingExample
    {
        static void Main()
        {
            Dist d1 = new Dist();
            Dist d2 = new Dist();
            d1.Dists = 10;
            d2.Dists = 20;
            Dist d3 = d1 + d2;
            Console.WriteLine("D3 : {0}", d3.Dists);
            Console.Read();
        }
    }
}
