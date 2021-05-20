using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEx
{
    class ExceptionEx
    {
        internal int Value1 = 20;
        string[] BookArray = { "Java", "C#", "DBMS", "Python" };

         public void Calculate()
        {
            try
            {
                //Value1 = Value1 / 0;
                Console.WriteLine("Array :{0}", BookArray[5]);
            }
            //if you do not have catch error will occur and finally will also not get executed
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Finally !!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionEx exceptionEx = new ExceptionEx();
            exceptionEx.Calculate();
            Console.ReadLine();
        }
    }
}
