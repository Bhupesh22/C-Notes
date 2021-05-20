using System;
using System.ComponentModel.DataAnnotations;

namespace MethodEg
{
    class MethodParameters
    {
        /*
         * <accessspecifier> <return type> function_name(parameters){
         *      body
         *      return statement
         * }
        */

        string Name;
        int Age;
        void get_details()
        {
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age :");
            Age = Convert.ToInt32(Console.ReadLine());

        }
        void display()
        {
            Console.WriteLine("Username : {0} and Age : {1}", Name, Age);
        }
        static void Main()
        {
            //to call non - static method
            MethodParameters methodParameters = new MethodParameters();
            methodParameters.get_details();
            methodParameters.display();
            Console.ReadLine();
        }
    }
}
