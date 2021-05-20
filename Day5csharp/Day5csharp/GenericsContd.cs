using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class GenDay6
    {
        public void show<T>(string name, T val)
        {
            Console.WriteLine($"{name}   {val}");
        }
    }
    class GenericsContd
    {
        static void Main()
        {
            GenDay6 g6 = new GenDay6();
            
            g6.show<float>("Bhupesh",12.5f);   //Calling generic method
            g6.show<string>("Bhupesh", "Bhupesh");
            g6.show<int>("Bhupesh", 12);

            //g6.show<string>("Bhupesh", 125); this will give error 

            Console.ReadLine();
        }
    }
}
