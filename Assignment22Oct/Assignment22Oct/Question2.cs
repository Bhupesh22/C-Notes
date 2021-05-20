using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22Oct
{
    abstract class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public float grade { get; set; }

        public Student(int StudentId, string StudentName, float grade)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.grade = grade;
        }
        public abstract bool isPass(float grade);
    }
    class UnderGraduate : Student
    {
        public UnderGraduate(int StudentId, string StudentName, float grade) : base(StudentId, StudentName, grade)
        {

        }
        public override bool isPass( float grade)
        {
            if (grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : Student
    {
        public Graduate(int StudentId, string StudentName, float grade) : base(StudentId, StudentName, grade)
        {

        }
        public override bool isPass(float grade)
        {
            if (grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Question2
    {
        static void Main()
        {
            Console.WriteLine(" 1 - Undergraduate \n 2 - Graduate (Enter 1/2)");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x == 1)
            {
                Console.WriteLine("Enter Student ID : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Grade :");
                float grade = float.Parse(Console.ReadLine());
                
                UnderGraduate UG = new UnderGraduate(id, name, grade);
                if (UG.isPass(grade))
                {
                    Console.WriteLine("Congratulation !!");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("Enter Student ID : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Grade :");
                float grade = float.Parse(Console.ReadLine());

                Graduate UG = new Graduate(id, name, grade);
                if (UG.isPass(grade))
                {
                    Console.WriteLine("Congratulation !!");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            else
            {
                Console.WriteLine("Invalid input !!!");
            }
            Console.ReadLine();
        }
    }
}
