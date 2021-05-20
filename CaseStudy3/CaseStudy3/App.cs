using System;
using System.Collections.Generic;


namespace CaseStudy3
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentDOB { get; set; }

        public Student(int id, string name, string dob)
        {
            StudentID = id;
            StudentName = name;
            StudentDOB = dob;
        }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public decimal CourseFees { get; set; }

        public Course(int id, string name, int duration, decimal fees)
        {
            CourseId = id;
            CourseName = name;
            CourseDuration = duration;
            CourseFees = fees;
        }
    }
    class Info
    {
        public int display(Student student)
        {
            if (student != null)
            {
                Console.WriteLine($"StudentId:{student.StudentID} || StudentName:{student.StudentName} " +
                $"|| StudentDOB:{student.StudentDOB}");
                return 1;
            }
            return 0;

        }

        public int display(Course course)
        {
            if (course != null)
            {
                Console.WriteLine($"CourseId:{course.CourseId} || CourseName:{course.CourseName}" +
                $"|| CourseDuration:{course.CourseDuration} || CourseFees:{course.CourseFees}");
                return 1;
            }
            return 0;
        }

    }

    class Search
    {
        public Student searchdata(List<Student> s, int id)
        {
            foreach (Student stu in s)
            {
                if (stu.StudentID == id)
                {
                    return stu;
                }
            }
            return null;
        }

        public Course searchdata(List<Course> c, int id)
        {
            foreach (Course cou in c)
            {
                if (cou.CourseId == id)
                {
                    return cou;
                }
            }
            return null;
        }
    }

    class App
    {
    }
}
