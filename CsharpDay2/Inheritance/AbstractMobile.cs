using System;

namespace Inheritance
{
    abstract class ISOStandard
    {
        abstract public void Terms();
    }
    //Cannot create object for abstract class
    abstract class MobileStandard :ISOStandard
    {
        //Non abstract variable allowed
        public int EmployeeCount = 20;
        
        //Abstract method no implementation in abstract class
        public abstract void call();

        //Non abstract method allowed
        internal void MobileStandardEmpl()
        {
            Console.WriteLine("Mobile Standard Employee Count :{0}", EmployeeCount);
        }
    }

    //All abstract method should be implemented if it is deriving abstract class
    class Apple : MobileStandard
    {
        public override void Terms()
        {
            Console.WriteLine("Apple terms");
        }
        public override void call()
        {
            Console.WriteLine("Apple Call");
        }
    }

    class Samsumg : MobileStandard
    {
        public override void Terms()
        {
            Console.WriteLine("Samsung terms");
        }
        public override void call()
        {
            Console.WriteLine("Samsung Call");
        }
    }
    class AbstractMobile
    {
        static void Main()
        {
            /*
             One way to do is (Normal) 
           
            Apple app = new Apple();
            app.MobileStandardEmpl();
            app.call();

            Samsumg samsung = new Samsumg();
            samsung.MobileStandardEmpl();
            samsung.call();
            */

            //This is dynamic reference or runtime
            MobileStandard mobileStandard;
            
            mobileStandard = new Apple();
            mobileStandard.call();
            mobileStandard.Terms();
            
            mobileStandard = new Samsumg();
            mobileStandard.call();
            mobileStandard.Terms();

            Console.Read();
        }
    }
}
