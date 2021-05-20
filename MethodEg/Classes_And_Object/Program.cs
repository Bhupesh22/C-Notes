using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Object
{
    class Program
    {
        string Name;
        int id;
        void details()
        {
            Console.WriteLine(Name + ' ' + id);
        }

        static void Main(string[] args)
        {
            Program pobj = new Program();
            pobj.id = 100;
            pobj.Name = "Bhupesh";
            pobj.details();
            Program pobj2 = new Program();
            pobj2.Name = "Akshay";
            //pobj2.id = 5;
            pobj2.details();
            Console.Read();
        }
    }
}
