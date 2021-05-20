using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplicationProgram
{
    class TypeConv
    {
        static void Main()
        {
            //Implicit Conversion
            //No data loss and No exception 
            int i = 100;
            float f = i;
            double d = f;
            Console.WriteLine("Int converted to float :{0}",f);
            Console.WriteLine("Float to double :{0}", d);

            //Explicity Converion
            float F1 = 23456.56f;
            int I1 = Convert.ToInt32(F1);

            Console.WriteLine("Explicit Conversion");
            Console.WriteLine("Float to int : {0}", I1);
            
            float num1 = 10, num2 = 20;
            float result = num1 / num2;
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
