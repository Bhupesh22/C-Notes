using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Csharp
{
    interface ICustomer
    {
        void show(); //abstract , only declaration;
    }
    interface ISupplier
    {
        void show();
    }
    class InterfaceExamp : ICustomer, ISupplier
    {
        void ICustomer.show() //Explicit Implementation of Interface  / for defualt just public void show()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Customer Interface");
        }

        void ISupplier.show()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Supplier Interface");
        }
        static void Main()
        {
            /*ICustomer ic = new InterfaceExamp();
            ic.show();
            ISupplier isup = new InterfaceExamp();
            isup.show();*/
            
            InterfaceExamp ie = new InterfaceExamp();
            ((ICustomer)ie).show(); ;
            
            Console.Read();
        }
    }
}
