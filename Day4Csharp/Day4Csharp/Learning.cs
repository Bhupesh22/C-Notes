using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    class Learning
    {
        static void Main()
        {
            int x;
            float f = 123.45f;
            x = (int)f;
            string z = "100"; // 100g will give error
            Console.WriteLine(x);
            Console.WriteLine(int.Parse(z));

            //tryparse method returns boolean
            bool status = int.TryParse(z, out int a);
            Console.WriteLine(a);
            Console.WriteLine(status);
            Console.ReadLine();
        }
        
    }
}
