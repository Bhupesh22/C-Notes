using System;


namespace Classes_And_Object
{
    class Student
    {
        //static string CollegeName = "VIT";
        internal static string CollegeName;

        //Non Static method can access static variable
        internal void Display()
        {
            Console.WriteLine("College Name : {0} ", CollegeName);
        }


        internal static void DisplayDetails()
        {
            Console.WriteLine("College Name : {0} ", CollegeName);
        }

    }
    class StaticExample
    {
        static string phone ;

        static void GetPhoneNum()
        {
            //phone = "987654321";
            Console.WriteLine("Phone Number is  :{0}", phone);
        }
        static void Main()
        {
            phone = "987654321"; //can be initialized here also

            Console.WriteLine("Enter College Name : ");
            Student.CollegeName = Console.ReadLine();

            Student Stu = new Student();

            //Calling static method of other class, classname is required not reference name
            Student.DisplayDetails();


            //calling static method in same class no class name is required
            GetPhoneNum();
            Stu.Display();
            Console.ReadKey();
        }
    }
}
