using System;

namespace Assignment2New
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        internal Student(int ID, string Name, string DateOfBirth)
        {
            this.ID = ID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
    }
    class StudentInfo
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student ID :{0}", student.ID);
            Console.WriteLine("Student Name :{0} ", student.Name);
            Console.WriteLine("Student Date of Birth : {0}", student.DateOfBirth);
        }
    }
    class App
    {
        static void Main()
        {
            string studentname;
            int id;
            string year;

            //Scenario 1
            Console.WriteLine("\n\n");
            Console.WriteLine("Scenario 1: \n");
            Student student1 = new Student(12, "Bhupesh", "22-03-1998");
            Student student2 = new Student(23, "Rahul", "22-08-1997");
            Student student3 = new Student(32, "Rohan", "18-05-1998");

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.Display(student1);
            studentInfo.Display(student2);
            studentInfo.Display(student3);

            //Scenario 2
            Console.WriteLine("\n\n");
            Console.WriteLine("Scenario 2: \n");

            Student[] studentArr2 = new Student[3];
            studentArr2[0] = new Student(12, "Bhupesh", "22-03-1998");
            studentArr2[1] = new Student(23, "Rahul", "22-08-1997");
            studentArr2[2] = new Student(32, "Rohan", "18-05-1998");

            for (int i = 0; i < 3; i++)
            {
                studentInfo.Display(studentArr2[i]);
            }

            //Scenario 3

            Console.WriteLine("\n\n");
            Console.WriteLine("Scenario 3: \n");
            Console.WriteLine("Enter the number of students");
            int Size = Convert.ToInt32(Console.ReadLine());
            Student[] studentArr = new Student[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Enter student id :");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student name :");
                studentname = Console.ReadLine();
                Console.WriteLine("Enter student age :");
                year = Console.ReadLine();
                studentArr[i] = new Student(id, studentname, year);
            }

            for (int i = 0; i < Size; i++)
            {
                studentInfo.Display(studentArr[i]);
            }
            Console.ReadLine();
        }
    }
}
