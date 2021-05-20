using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplicationProgram
{
    class NullableEx
    {
        static void Main()
        {
            //Null coalescing operator
            int? Age = null;
            Console.WriteLine("AGE IS:{0}", Age ?? 0);

            //String null example
            string Name = null;
            Console.WriteLine("Org {0}", Name ?? "No org Name");


            int Available , TotalTicket = 100;
            int? TicketOnSale = null;
            Available = TotalTicket - (TicketOnSale ?? 0);
            Console.WriteLine("Available:{0}", Available);

            Console.ReadKey();
        }
    }
}
