using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bank
    {
        public virtual string BankLoan()
        {
            return "9%";
        }
        public void Test()
        {
            Console.WriteLine("RBI");
        }
    }
    class SBI : Bank
    {
        public override string BankLoan()
        {
            return "10%";
        }
    }

    class Indian : Bank
    {
        public override string BankLoan()
        {
            return "15%";
        }
    }
    class VirtualExample
    {
        static void Main()
        {
            Bank bank = new Bank();
            Console.WriteLine("Bank:{0}", bank.BankLoan());
            bank.Test();

            SBI sbi = new SBI();
            Console.WriteLine("SBI :{0}", sbi.BankLoan());

            Indian ind = new Indian();
            Console.WriteLine("Indian :{0}", ind.BankLoan());
        }
        
    }
}
