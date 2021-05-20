using System;

namespace Assignment1
{
    class StudentDetails
    {
        static void Main()
        {
            //Accepting values 

            Console.WriteLine("Enter Student ID :");
            int StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name :");
            string StudentName = Console.ReadLine();

            Console.WriteLine("Enter Student age :");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student gender (M/F):");
            char Gender = Console.ReadLine()[0];
            //can also use  Console.ReadKey().KeyChar;;

            Console.WriteLine("Enter Student's city");
            string City = Console.ReadLine();


            //Displaying Values
            Console.WriteLine("\n\n\n");
            Console.WriteLine("-------------------------Values----------------------------");
            Console.WriteLine("Student ID : {0}", StudentId);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student Age : {0}", Age);
            Console.WriteLine("Student City : {0}", City);
            Console.ReadLine();
        }
        
    }
}
