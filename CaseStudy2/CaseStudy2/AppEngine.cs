using System;


namespace CaseStudy2
{
    class AppEngine
    {
        Student[] studentlist = new Student[20];
        Course[] courselist = new Course[10];
        Enroll[] enrolllist = new Enroll[20];
        int coursecount = 0, studentcount = 0, enrollcount = 0;

        public void Introduce(Course course)
        {
            courselist[coursecount] = course;
            coursecount++;
            Console.WriteLine("Course added successfully");
        }

        public void Register(Student student)
        {
            studentlist[studentcount] = student;
            studentcount++;
            Console.WriteLine("Student Registered Successfully");
        }

        public Student[] ListOfStudents()
        {
            if (studentcount == 0)
            {
                return null;
            }
            return studentlist;
        }

        public Course[] ListOfCourses()
        {
            if (coursecount == 0)
            {
                return null;
            }
            return courselist;
        }

        public void EnrollStudent(Student student, Course course)
        {
            enrolllist[enrollcount] = new Enroll(student, course, DateTime.Now);
            enrollcount++;
            Console.WriteLine("Enrolled Successfully");
        }

        public Enroll[] ListOfEnrollments()
        {
            if (enrollcount == 0)
            {
                return null;
            }
            return enrolllist;
        }
    }
}
