using System;
using System.Collections.Generic;
using System.Text;

namespace MethodEg
{
    //Call by value & call by reference
    class Call_V_R_ex
    {
        void byvalue(int Num)
        {
            Num = 210;
            Console.WriteLine("Value in byvalue function :{0}", Num);

        }
        void byreference(ref int Num)
        {
            Num = 220;
            Console.WriteLine("Value in byvalue function :{0}", Num);
        }
        void Calculation(int Num1,int Num2, out int add, out int prod, out float div)
        {
            add = Num1 + Num2;
            prod = Num1 * Num2;
            if( Num1 > Num2 &&  Num2 != 0)
            {
                div = (float)Num1 / Num2;
            }
            else
            {
                div = 0.0f;
                Console.WriteLine("Not possible");
            }
        }
        static void Main()
        {
            int Num = 100;
            Call_V_R_ex Call = new Call_V_R_ex(); //or new Call_V_R_ex().byvalue(100);
            
            //call by value
            Call.byvalue(100);
            Console.WriteLine(Num);
            
            //call by reference
            Call.byreference(ref Num);
            Console.WriteLine(Num);

            int Value1 = 101;
            int Value2 = 202, sum , product ;
            float div = 0.0f;
            Call.Calculation(Value1, Value2, out sum, out product, out div);
            if( sum >0 && product > 0)
            {
                Console.WriteLine("Sum :{0}  and Product: {1}", sum, product);
            }
            else
            {
                Console.WriteLine("Values are not greater than zero");
            }
            Console.Read();
        }
    }
}
