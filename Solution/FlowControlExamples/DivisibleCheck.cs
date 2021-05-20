using System;
using System.Collections.Generic;
using System.Text;

namespace FlowControlExamples
{
    class DivisibleCheck
    {
        static void Main()
        {
            float Num1, Num2, Quo, Rem;
            Console.WriteLine("Enter the Dividend ");
            Num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Divisor ");
            Num2 = Convert.ToSingle(Console.ReadLine());
            if (Num2 > Num1 || Num2 == 0)
            {
                Console.WriteLine("Cannot be divided");
            }
            else
            {
                Quo = Num1 / Num2;
                Rem = Num1 % Num2;
                Console.WriteLine("Quotient is : {0:f4}", Quo);
                Console.WriteLine("Remainder is :{0:f4}", Rem);
                
            }
            Console.ReadKey();
        }
    }
}
