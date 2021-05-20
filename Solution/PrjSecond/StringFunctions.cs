using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    class StringFunctions
    {
        static void Main()
        {
            //String - class, string - data type

            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("ToUpper() of Name: {0}", Name.ToUpper());
            Console.WriteLine("ToLower() of Name: {0}", Name.ToLower());
            Console.WriteLine("Length :{0}", Name.Length);

            // using .contains method (boolean return type)
            bool isContain = Name.Contains("Bh");
            Console.WriteLine("Value of isContain : {0}", isContain);

            //Subtring
            Console.WriteLine("Substring : {0}", Name.Substring(2, 5));

            //using trim
            Console.WriteLine("Using trim : {0}", Name.Trim());
            Console.WriteLine("Using left trim: {0}", Name.TrimStart());
            Console.WriteLine("Using right trim: {0}", Name.TrimEnd());
            Console.ReadKey();
        }
    }
}
