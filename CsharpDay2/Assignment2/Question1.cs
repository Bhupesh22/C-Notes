using System;


namespace Assignment2
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
            Console.WriteLine("Student ID :{0}",student.ID);
            Console.WriteLine("Student Name :{0} ",student.Name);
            Console.WriteLine("Student Date of Birth : {0}",student.DateOfBirth);
        }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public int Fees { get; set; }

        internal Course(int CourseId, string CourseName, string Duration, int Fees)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            this.Duration = Duration;
            this.Fees = Fees;
        }

    }
    class CourseInfo
    {
        public void DisplayCourse(Course course)
        {
            Console.WriteLine("Course Id: {0} ", course.CourseId);
            Console.WriteLine("Course Name : {0} ", course.CourseName);
            Console.WriteLine("Course Duration :{0} ", course.Duration);
            Console.WriteLine("Course Fees :{0} ", course.Fees);
        }
    }
    class Question1
    {
        static void Main()
        {
            string studentname;
            int id;
            string year;
            
            //Scenario 1
            Console.WriteLine("Scenario 1: \n");
            Student student1 = new Student(12,"Bhupesh","22-03-1998");
            Student student2 = new Student(23,"Rahul","22-08-1997");
            Student student3 = new Student(32,"Rohan","18-05-1998");

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
            for(int i=0; i<Size; i++)
            {
                Console.WriteLine("Enter student id :");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student name :");
                studentname = Console.ReadLine();
                Console.WriteLine("Enter student age :");
                year = Console.ReadLine();
                studentArr[i] = new Student(id, studentname, year);
            }

            for(int i=0; i<Size; i++)
            {
                studentInfo.Display(studentArr[i]);
            }


            //Scenario 4 Creating Course

            Course CourseC1 = new Course(1,"Java","3 Months",1000);
            Course CourseC2 = new Course(2, "DBMS", "2 Months", 2000);
            Course CourseC3 = new Course(3, "C#", "4 Months", 3000);

            CourseInfo courseInfo = new CourseInfo();
            courseInfo.DisplayCourse(CourseC1);
            courseInfo.DisplayCourse(CourseC2);
            courseInfo.DisplayCourse(CourseC3);


            Console.ReadLine();

        }
    }
}
