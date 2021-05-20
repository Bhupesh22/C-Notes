using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class Flower
    {
        string name;
        string color;
        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Display()
        {
            Console.WriteLine(name + " " + color);
        }
    }
    class FlowerIndexer
    {
        Flower[] ob = new Flower[5];
        
        public Flower this[int x]
        {
            get
            {
                return ob[x];
            }
            set
            {
                ob[x] = value;
            }
        }
    }
    class FlowerMain
    {
        static void Main()
        {
            FlowerIndexer fv = new FlowerIndexer();
            fv[0] = new Flower("Rose", "Red");
            fv[1] = new Flower("lily", "white");
            fv[2] = new Flower("delia", "yellow");
            for(int i=0; i<3; i++)
            {
                fv[i].Display();
            }
            Console.Read();
        }
    }
}
