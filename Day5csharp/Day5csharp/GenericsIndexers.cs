using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class GenericsIndexers<T> where T : class //this will accept only reference type
    {
        private T[] data = new T[3];
        private T var;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public T Var
        {
            get { return var;  }
            set { var = value; }
        }

        public T this [int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        public T this[string index]
        {
            get { return data[int.Parse(index)]; }
            set { data[int.Parse(index)] = value; }
        }

    }
    class driver
    {
        static void Main()
        {
            /*GenericsIndexers<float> gf = new GenericsIndexers<float>();

            GenericsIndexers<string> gref = new GenericsIndexers<string>();
            gf["0"] = 7.65f;
            gf[1] = 5.5f;
            gf[2.2f] = 10.5f;
            gf.Name = "Bhupesh";
            gf.Var = 4.5f;
            Console.WriteLine($"At position 0 : {gf[0]}");
            Console.WriteLine($"At position 1 : {gf[1]}");
            Console.WriteLine($"At position 2 : {gf[2]}");
            Console.WriteLine(gf.Name);
            Console.WriteLine(gf.Var);*/

            GenericsIndexers<driver> gdriver = new GenericsIndexers<driver>();
            gdriver.Name = "Bhupesh"; //because this is reference type

            Console.ReadLine();

        }
        
    }
}
