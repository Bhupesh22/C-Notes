using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BankName : person
    {
        internal BankName(string Name, int Age, string Gender) : base(Name, Age, Gender)
        {

        }
        
    }
    class PersonClient
    {
        static void Main()
        {
            BankName B = new BankName("Bhupesh", 22, "Male");
            B.DisplayAge();
        }
    }
}
