using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class Shape
    {
        protected float R = 1.2f, L =5, B = 7; //protected can be accessed in derived class but not in non derived i.e Main

        public int testvar;
        
        internal int internalvar; //accessible in same solution
        public virtual float Area()
        {
            return 3.14f * R * R;
        }
        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }
    class Rectangle : Shape
    {
        public void getLB()
        {
            Console.WriteLine("Enter length : ");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());
            //Console.WriteLine(testvar); is visible

        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }
    class Circle : Shape
    {
        public void getRadius()
        {
            Console.WriteLine("Enter Radius : ");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return base.Area();
        }
        public override float Circumference()
        {
            return base.Circumference();
        }
    }
    class OverrideExample
    {
        static void Main()
        {
            
            Rectangle R = new Rectangle();
            R.getLB();
            Console.WriteLine("Area Rec : {0} ",R.Area());
            Console.WriteLine("Circumference  Rec :{0}",R.Circumference());

            Circle C = new Circle();
            C.getRadius();
            Console.WriteLine("Area Cir : {0} ", C.Area());
            Console.WriteLine("Circumference Cir : {0} ", C.Circumference());

            Shape S = new Rectangle();
            Console.WriteLine("Area Shape (Rec) : {0} ", S.Area());
            Console.WriteLine("Circumference Shape (Rec)  : {0} ", S.Circumference());

            Shape S1 = new Shape();
            //S1.testvar; is accessible cuz public 
            Console.Read();
        }
        
    }
}
