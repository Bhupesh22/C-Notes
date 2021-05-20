using System;
using System.Collections.Generic;
using System.Text;

namespace FlowControlExamples
{
    class ForEach
    {
        static void Main()
        {
            string[] Gender = { "Male", "Male", "Female", "Female", "Male" };
            int Male = 0, Female = 0;
            foreach( string g in Gender)
            {
                if(g.ToUpper() == "MALE")
                {
                    Male++;
                }else if( g.ToUpper() == "FEMALE")
                {
                    Female++;
                }
            }
            Console.WriteLine("Male:{0} ", Male);
            Console.WriteLine("Female:{0}", Female);
            Console.Read();
        }
    }
}
