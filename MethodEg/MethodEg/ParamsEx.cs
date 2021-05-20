using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MethodEg
{
    //generally params is used if we don;t know the number of parameters
    //however params is the last parameter in the parameter list. 
    
    class ParamsEx
    {
        void Total(int id, params int[] marks)
        {
            int sum = 0;
            foreach(int i in marks)
            {
                sum += i;
            }
            Console.WriteLine("Sum is {0}", sum);
        }
        //when we don't know the number & mixed type of parameters use object parameter
        void ObjectParams(int id, params object[] student)
        {
            foreach(object o in student)
            {
                Console.WriteLine(o);
            }
        }
        static void Main()
        {
            ParamsEx pex = new ParamsEx();
            pex.Total(100, 89, 90, 92, 98);
            pex.ObjectParams(100, "Bhupesh", "Mumbai", 29);
            Console.Read();
        }
    }
}
