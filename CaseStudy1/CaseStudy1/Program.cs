using System;

namespace CaseStudy1
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dateofbirth { get; set; }

        public Student(int id, string name, string dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }
    }
    class Info
    {
        public void Display(Student student)
        {
            if(student != null)
            {
                Console.WriteLine($"Student ID : {student.id}\t Student Name : {student.name}\t Student Date of Birth :{student.dateofbirth}");
            }
        }
    }
    class App
    {
        static void scenario1()
        {
            Console.WriteLine("\nScenario 1\n");
            Student s1 = new Student(1,"Bhupesh","22/03/1998");
            Student s2 = new Student(2, "Rishabh", "22/03/1998");
            Student s3 = new Student(3, "Rahul", "22/03/1998");
            Student s4 = new Student(4, "Akshay", "22/03/1998");

            Info info = new Info();
            info.Display(s1);
            info.Display(s2);
            info.Display(s3);
            info.Display(s4);
        }
        static void scenario2()
        {
            Console.WriteLine("\nScenario 2\n");
            Student[] students = new Student[4];
            Student s1 = new Student(1, "Bhupesh", "22/03/1998");
            Student s2 = new Student(2, "Rishabh", "22/03/1998");
            Student s3 = new Student(3, "Rahul", "22/03/1998");
            Student s4 = new Student(4, "Akshay", "22/03/1998");
            
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;

            Info info = new Info();
            for(int i =0; i<4; i++)
            {
                info.Display(students[i]);
            }

        }
        static void scenario3()
        {
            Console.WriteLine("\nScenario 3\n");
            Student[] students = new Student[4];
            for(int i=0; i<4; i++)
            {
                Console.WriteLine("Enter student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth :");
                string dateofbirth = Console.ReadLine();
                
                students[i] = new Student(id, name, dateofbirth);
            }
            Info info = new Info();
            for (int i = 0; i < 4; i++)
            {
                info.Display(students[i]);
            }

        }
        static void Main(string[] args)
        {
            scenario1();
            scenario2();
            scenario3();
            Console.Read();
        }
    }
}
