using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class Indexers
    {
        private string[] words = new string[3];
        public string this[int x] //position for indexers
        {
            get
            {
                string temp = words[x]; //to identify positon
                return temp;
            }
            set
            {
                words[x] = value;
            }
        }

        public string this[float f] //position for indexers
        {
            get
            {
                string temp = words[Convert.ToInt32(f)]; //to identify positon
                return temp;
            }
            set
            {
                words[Convert.ToInt32(f)] = value;
            }
        }
        static void Main()
        {
            Indexers ie = new Indexers();
            ie[0] = "Hello";
            ie[1] = "Welcome";
            ie[2] = "C#";
            ie[1.1f] = "Java"; //this will be assigned to index 1 bcz of float type
            Console.WriteLine(ie[0] +" "+ ie[1] +" "+ ie[2] + ie[1.1f]);
            Console.Read();
        }

    }
}
