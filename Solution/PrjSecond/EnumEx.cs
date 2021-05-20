using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    //Enumeration - special set of named values 
    //can be float , integer, byte, doube
    //value starts with zero
    //syntax -enum enum_name {enum_list}
    class EnumEx
    {
        //Default starts with zero , if explicit value then specify value like eg. poor=1
        enum FeedBack { Poor = 1, Fair, Good, VeryGood, Excellent }

        static void Main()
        {
            int x = (int)FeedBack.Poor;
            Console.WriteLine("Excellent : {0} ", (int)FeedBack.Excellent);
            
            Console.WriteLine("Integer value of poor : {0}",x);
            
            Console.WriteLine("Good :{0}", Convert.ToInt32(FeedBack.Good));
            
            Console.ReadKey();
        }
    }
}
